// Copyright (c) 2017 Cyotek Ltd.
// http://mantissharp.net/
// Licensed under the MIT License. See LICENSE.txt for the full text.

// If you use this control in your applications, attribution, donations or contributions are welcome.

namespace MantisSharp
{
  partial class TagCollection
  {
    #region Methods

    public Tag Add(string name)
    {
      Tag result;

      result = new Tag
               {
                 Name = name
               };

      this.Add(result);

      return result;
    }

    public Tag Add(int id)
    {
      Tag result;

      result = new Tag
               {
                 Id = id
               };

      this.Add(result);

      return result;
    }

    #endregion
  }
}
