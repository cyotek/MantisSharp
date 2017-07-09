using System;
using PetaJson;

// Copyright (c) 2017 Cyotek Ltd.
// http://mantissharp.net/
// Licensed under the MIT License. See LICENSE.txt for the full text.

// If you use this control in your applications, attribution, donations or contributions are welcome.

namespace MantisSharp
{
  public class Attachment : MantisEntity
  {
    #region Fields

    private string _contentType;

    private DateTime _created;

    private string _downloadUrl;

    private string _fileName;

    private User _reporter;

    private long _size;

    #endregion

    #region Properties

    [Json("content_type")]
    public string ContentType
    {
      get { return _contentType; }
      internal set { _contentType = value; }
    }

    [Json("created_at")]
    public DateTime Created
    {
      get { return _created; }
      internal set { _created = value; }
    }

    [Json("download_url")]
    public string DownloadUrl
    {
      get { return _downloadUrl; }
      internal set { _downloadUrl = value; }
    }

    [Json("filename")]
    public string FileName
    {
      get { return _fileName; }
      internal set { _fileName = value; }
    }

    [Json("reporter")]
    public User Reporter
    {
      get { return _reporter; }
      internal set { _reporter = value; }
    }

    [Json("size")]
    public long Size
    {
      get { return _size; }
      internal set { _size = value; }
    }

    #endregion

    #region Methods

    public override string ToString()
    {
      return _fileName;
    }

    #endregion
  }
}
