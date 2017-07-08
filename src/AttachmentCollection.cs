using System.Collections.ObjectModel;

namespace MantisSharp
{
  public class AttachmentCollection : KeyedCollection<int, Attachment>
  {
    #region Methods

    protected override int GetKeyForItem(Attachment item)
    {
      return item.Id;
    }

    #endregion
  }
}
