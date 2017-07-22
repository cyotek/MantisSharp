using PetaJson;

// Copyright (c) 2017 Cyotek Ltd.
// http://mantissharp.net/
// Licensed under the MIT License. See LICENSE.txt for the full text.

// If you use this control in your applications, attribution, donations or contributions are welcome.

namespace MantisSharp
{
  public abstract class NamedMantisEntity : MantisEntity
  {
    #region Fields

    private string _name;

    #endregion

    #region Properties

    [Json("name")]
    public string Name
    {
      get { return _name; }
      set { _name = value; }
    }

    #endregion

    #region Methods

    public override string ToString()
    {
      return _name;
    }

    #endregion
  }
}
