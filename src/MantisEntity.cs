using System.ComponentModel;
using PetaJson;

// Copyright (c) 2017 Cyotek Ltd.
// http://mantissharp.net/
// Licensed under the MIT License. See LICENSE.txt for the full text.

// If you use this control in your applications, attribution, donations or contributions are welcome.

namespace MantisSharp
{
  [TypeConverter(typeof(ExpandableObjectConverter))]
  public abstract class MantisEntity
  {
    #region Fields

    private int _id;

    #endregion

    #region Properties

    [Json("id")]
    public int Id
    {
      get { return _id; }
      internal set { _id = value; }
    }

    #endregion
  }
}
