using System.Collections.ObjectModel;

namespace MantisSharp
{
  public class NoteCollection : KeyedCollection<int, Note>
  {
    #region Methods

    protected override int GetKeyForItem(Note item)
    {
      return item.Id;
    }

    #endregion
  }
}
