using System.Collections.ObjectModel;

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
