using PetaJson;

// Copyright (c) 2017 Cyotek Ltd.
// http://mantissharp.net/
// Licensed under the MIT License. See LICENSE.txt for the full text.

// If you use this control in your applications, attribution, donations or contributions are welcome.

namespace MantisSharp
{
  public abstract class LocalizedMantisEntity : NamedMantisEntity
  {
    #region Fields

    private string _label;

    #endregion

    #region Properties

    [Json("label")]
    public string Label
    {
      get { return _label; }
      internal set { _label = value; }
    }

    #endregion

    #region Methods

    public override string ToString()
    {
      return string.IsNullOrEmpty(_label) ? base.ToString() : _label;
    }

    #endregion
  }
}
