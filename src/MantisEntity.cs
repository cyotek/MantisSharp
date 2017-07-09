using System.ComponentModel;
using PetaJson;

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
