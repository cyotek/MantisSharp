using System.Collections.ObjectModel;

namespace MantisSharp
{
  public class MantisReferenceCollection : KeyedCollection<int, MantisReference>
  {
    #region Methods

    protected override int GetKeyForItem(MantisReference item)
    {
      return item.Id;
    }

    #endregion
  }
}
