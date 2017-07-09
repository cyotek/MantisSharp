using PetaJson;

namespace MantisSharp
{
  public class Category : NamedMantisEntity
  {
    #region Fields

    private NamedMantisEntity _project;

    #endregion

    #region Properties

    [Json("project")]
    public NamedMantisEntity Project
    {
      get { return _project; }
      internal set { _project = value; }
    }

    #endregion
  }
}
