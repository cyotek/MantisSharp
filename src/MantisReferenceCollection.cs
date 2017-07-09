using System.Collections.ObjectModel;

namespace MantisSharp
{
  public class MantisReferenceCollection : KeyedCollection<int, NamedMantisEntity>
  {
    #region Methods

    protected override int GetKeyForItem(NamedMantisEntity item)
    {
      return item.Id;
    }

    #endregion
  }
}
