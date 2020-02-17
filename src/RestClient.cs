using System;
using System.IO;
using System.Net;
using System.Security;
using System.Text;

// Copyright (c) 2017 Cyotek Ltd.
// http://mantissharp.net/
// Licensed under the MIT License. See LICENSE.txt for the full text.

// If you use this control in your applications, attribution, donations or contributions are welcome.

namespace MantisSharp
{
  internal sealed class RestClient
  {
    #region Constants

    private const string _deleteVerb = "DELETE";

    private const string _getVerb = "GET";

    private const string _jsonContentType = "application/json";

    private const string _mantisVersionHeader = "X-Mantis-Version";

    private const string _postVerb = "POST";

    #endregion

    #region Fields

    private string _authorization;

    private string _mantisVersion;

    #endregion

    #region Properties

    public string Authorization
    {
      get { return _authorization; }
      set { _authorization = value; }
    }

    public string MantisVersion
    {
      get { return _mantisVersion; }
    }

    #endregion

    #region Methods

    public void ExecuteDelete(string uri, string query)
    {
      this.ExecuteRequest(_deleteVerb, uri, query, null, null);
    }

    public void ExecuteGet(string uri, Action<TextReader> action)
    {
      this.ExecuteGet(uri, null, action);
    }

    public void ExecuteGet(string uri, string query, Action<TextReader> action)
    {
      this.ExecuteRequest(_getVerb, uri, query, null, response => { this.ProcessTextResponse(response, action); });
    }

    public void ExecutePost(string uri, Action<TextReader> action)
    {
      this.ExecutePost(uri, null, action);
    }

    public void ExecutePost(string uri, Func<string> getRequestBody, Action<TextReader> action)
    {
      this.ExecuteRequest(_postVerb, uri, null, request =>
                                                {
                                                  request.ContentType = "application/json;charset=UTF-8";
                                                  this.WriteRequestText(request, getRequestBody);
                                                }, response => { this.ProcessTextResponse(response, action); });
    }

    public void ExecuteRequest(string method, string uri, string query, Action<HttpWebRequest> init, Action<HttpWebResponse> action)
    {
      HttpWebRequest request;

      request = this.CreateRequest(method, uri, query);

#if !DEBUG
      try
#endif
      {
        this.Execute(request, init, action);
      }
#if DEBUG
      try
      { }
#endif
      catch (WebException ex) when (ex.Status == WebExceptionStatus.ProtocolError && ex.Response is HttpWebResponse)
      {
        HttpWebResponse response;

        response = (HttpWebResponse)ex.Response;

        switch (response.StatusCode)
        {
          case HttpStatusCode.Unauthorized: throw new SecurityException("Invalid authorization key.", ex);
          default: throw;
        }
      }
    }

    private HttpWebRequest CreateRequest(string method, string uri, string query)
    {
      HttpWebRequest request;

      if (!string.IsNullOrEmpty(query))
      {
        if (query[0] == '?')
        {
          uri += query;
        }
        else
        {
          uri += "?" + query;
        }
      }

#if NET20 || NET35 || NET40
      request = (HttpWebRequest)WebRequest.Create(uri);
#else
      request = WebRequest.CreateHttp(uri);
#endif
      request.Headers.Add("Authorization", _authorization);
      request.Accept = _jsonContentType;
      request.Method = method;

      return request;
    }

    private void Execute(HttpWebRequest request, Action<HttpWebRequest> init, Action<HttpWebResponse> action)
    {
      init?.Invoke(request);

      using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
      {
        HttpStatusCode statusCode;

        statusCode = response.StatusCode;

        if (statusCode == HttpStatusCode.OK || statusCode == HttpStatusCode.NoContent && this.IsDelete(request) || statusCode == HttpStatusCode.Created && this.IsPost(request))
        {
          if (statusCode != HttpStatusCode.NoContent)
          {
            string contentType;

            contentType = this.GetContentType(response.ContentType);

            if (!string.Equals(contentType, _jsonContentType, StringComparison.InvariantCultureIgnoreCase))
            {
              throw new InvalidDataException("Unexpected content type '" + contentType + "'.");
            }
          }

          action?.Invoke(response);

          this.UpdateVersion(response);
        }
        else
        {
          throw new InvalidOperationException("Unexpected response code.");
        }
      }
    }

    private string GetContentType(string value)
    {
      if (!string.IsNullOrEmpty(value))
      {
        int index;

        index = value.IndexOf(';');

        if (index != -1)
        {
          value = value.Substring(0, index);
        }
      }

      return value;
    }

    private string GetResponseString(WebResponse response)
    {
      HttpWebResponse webResponse;
      Encoding encoding;
      string result;

      webResponse = response as HttpWebResponse;

      // ReSharper disable once MergeSequentialChecks
      if (webResponse != null && !string.IsNullOrEmpty(webResponse.CharacterSet))
      {
        encoding = Encoding.GetEncoding(webResponse.CharacterSet);
      }
      else
      {
        encoding = Encoding.UTF8;
      }

      using (Stream stream = response.GetResponseStream())
      {
        if (stream != null)
        {
          using (StreamReader reader = new StreamReader(stream, encoding))
          {
            result = reader.ReadToEnd();
          }
        }
        else
        {
          result = null;
        }
      }

      return result;
    }

    private bool IsDelete(WebRequest request)
    {
      return string.Equals(request.Method, _deleteVerb, StringComparison.OrdinalIgnoreCase);
    }

    private bool IsPost(WebRequest request)
    {
      return string.Equals(request.Method, _postVerb, StringComparison.OrdinalIgnoreCase);
    }

    private void ProcessTextResponse(HttpWebResponse response, Action<TextReader> action)
    {
      Encoding encoding;

      encoding = string.IsNullOrEmpty(response.CharacterSet) ? Encoding.UTF8 : Encoding.GetEncoding(response.CharacterSet);

      using (Stream stream = response.GetResponseStream())
      {
        using (StreamReader reader = new StreamReader(stream, encoding))
        {
          action(reader);
        }
      }
    }

    private void UpdateVersion(HttpWebResponse response)
    {
      if (_mantisVersion == null)
      {
        _mantisVersion = response.GetResponseHeader(_mantisVersionHeader);
      }
    }

    private void WriteRequestText(WebRequest request, Func<string> bodyFunc)
    {
      if (bodyFunc != null)
      {
        Stream stream;
        byte[] buffer;

        stream = request.GetRequestStream();
        buffer = Encoding.UTF8.GetBytes(bodyFunc());

        stream.Write(buffer, 0, buffer.Length);
      }
    }

    #endregion
  }
}
