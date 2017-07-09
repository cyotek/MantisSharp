using PetaJson;

namespace MantisSharp
{
  public class Category : MantisReference
  {
    #region Fields

    private MantisReference _project;

    #endregion

    #region Properties

    [Json("project")]
    public MantisReference Project
    {
      get { return _project; }
      internal set { _project = value; }
    }

    #endregion
  }
}
