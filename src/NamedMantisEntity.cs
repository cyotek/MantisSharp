using PetaJson;

namespace MantisSharp
{
  public /* abstract */ class NamedMantisEntity : MantisEntity
  {
    #region Fields

    private string _name;

    #endregion

    #region Properties

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
