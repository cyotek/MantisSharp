using System.ComponentModel;
using PetaJson;

namespace MantisSharp
{
  [TypeConverter(typeof(ExpandableObjectConverter))]
  public class MantisReference
  {
    #region Fields

    private int _id;

    private string _name;

    #endregion

    #region Properties

    [Json("id")]
    public int Id
    {
      get { return _id; }
      internal set { _id = value; }
    }

    [Json("name")]
    public string Name
    {
      get { return _name; }
      internal set { _name = value; }
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
