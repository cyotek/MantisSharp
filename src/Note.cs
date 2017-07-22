using System;
using PetaJson;

// Copyright (c) 2017 Cyotek Ltd.
// http://mantissharp.net/
// Licensed under the MIT License. See LICENSE.txt for the full text.

// If you use this control in your applications, attribution, donations or contributions are welcome.

namespace MantisSharp
{
  public class Note : MantisEntity
  {
    #region Fields

    private DateTime _created;

    private DateTime _lastModified;

    private User _reporter;

    private string _text;

    private string _type;

    private ViewState _viewState;

    #endregion

    #region Properties

    [Json("created_at")]
    public DateTime Created
    {
      get { return _created; }
      set { _created = value; }
    }

    [Json("updated_at")]
    public DateTime LastModified
    {
      get { return _lastModified; }
      set { _lastModified = value; }
    }

    [Json("reporter")]
    public User Reporter
    {
      get { return _reporter; }
      set { _reporter = value; }
    }

    [Json("text")]
    public string Text
    {
      get { return _text; }
      set { _text = value; }
    }

    [Json("type")]
    public string Type
    {
      get { return _type; }
      set { _type = value; }
    }

    [Json("view_state")]
    public ViewState ViewState
    {
      get { return _viewState; }
      set { _viewState = value; }
    }

    #endregion

    #region Methods

    public override string ToString()
    {
      return _text;
    }

    #endregion
  }
}
