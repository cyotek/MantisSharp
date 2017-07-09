using System;
using PetaJson;

// Copyright (c) 2017 Cyotek Ltd.
// http://mantissharp.net/
// Licensed under the MIT License. See LICENSE.txt for the full text.

// If you use this control in your applications, attribution, donations or contributions are welcome.

namespace MantisSharp
{
  public class ProjectVersion : NamedMantisEntity
  {
    #region Fields

    private string _description;

    private bool _obsolete;

    private bool _released;

    private DateTime _timestamp;

    #endregion

    #region Properties

    [Json("description")]
    public string Description
    {
      get { return _description; }
      internal set { _description = value; }
    }

    [Json("obsolete")]
    public bool Obsolete
    {
      get { return _obsolete; }
      internal set { _obsolete = value; }
    }

    [Json("released")]
    public bool Released
    {
      get { return _released; }
      internal set { _released = value; }
    }

    [Json("timestamp")]
    public DateTime Timestamp
    {
      get { return _timestamp; }
      internal set { _timestamp = value; }
    }

    #endregion
  }
}
