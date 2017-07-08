using System;
using System.IO;
using System.Net;
using System.Security;
using System.Text;

namespace MantisSharp
{
  internal sealed class RestClient
  {
    #region Constants

    private const string _jsonContentType = "application/json";

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

    public void ExecuteRequest(string uri, Action<TextReader> action)
    {
      this.ExecuteRequest(uri, null, action);
    }

    public void ExecuteRequest(string uri, string query, Action<TextReader> action)
    {
      this.ExecuteRequest(uri, query, null, response => { this.ProcessTextResponse(response, action); });
    }

    public void ExecuteRequest(string uri, string query, Action<HttpWebRequest> init, Action<HttpWebResponse> action)
    {
      HttpWebRequest request;

      request = this.CreateRequest(uri, query);

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

    private HttpWebRequest CreateRequest(string uri, string query)
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

      return request;
    }

    private void Execute(HttpWebRequest request, Action<HttpWebRequest> init, Action<HttpWebResponse> action)
    {
      init?.Invoke(request);

      using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
      {
        if (response.StatusCode == HttpStatusCode.OK)
        {
          string contentType;

          contentType = this.GetContentType(response.ContentType);

          if (!string.Equals(contentType, _jsonContentType, StringComparison.InvariantCultureIgnoreCase))
          {
            throw new InvalidDataException("Unexpected content type '" + contentType + "'.");
          }

          action(response);

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

    private string GetResponseString(HttpWebResponse response)
    {
      Encoding encoding;
      string result;

      // ReSharper disable once AssignNullToNotNullAttribute
      encoding = !string.IsNullOrEmpty(response.CharacterSet) ? Encoding.UTF8 : Encoding.GetEncoding(response.CharacterSet);

      using (Stream stream = response.GetResponseStream())
      {
        using (StreamReader reader = new StreamReader(stream, encoding))
        {
          result = reader.ReadToEnd();
        }
      }

      return result;
    }

    private void ProcessTextResponse(HttpWebResponse response, Action<TextReader> action)
    {
      Encoding encoding;

      // ReSharper disable once AssignNullToNotNullAttribute
      encoding = !string.IsNullOrEmpty(response.CharacterSet) ? Encoding.UTF8 : Encoding.GetEncoding(response.CharacterSet);

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
        _mantisVersion = response.GetResponseHeader("X-Mantis-Version");
      }
    }

    #endregion
  }
}
