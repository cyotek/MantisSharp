using System.Collections.ObjectModel;

// Copyright (c) 2017 Cyotek Ltd.
// http://mantissharp.net/
// Licensed under the MIT License. See LICENSE.txt for the full text.

// If you use this control in your applications, attribution, donations or contributions are welcome.

namespace MantisSharp
{
  public class UserCollection : KeyedCollection<int, User>
  {
    #region Methods

    protected override int GetKeyForItem(User item)
    {
      return item.Id;
    }

    #endregion
  }
}
