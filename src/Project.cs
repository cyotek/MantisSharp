namespace MantisSharp
{
  public class Project : MantisEntity
  {
    #region Fields

    private LocalizedMantisEntity _accessLevel;

    private CategoryCollection _categories;

    private CustomFieldCollection _customFields;

    private string _description;

    private bool _enabled;

    private string _name;

    private ProjectStatus _status;

    private ProjectVersionCollection _versions;

    private ViewState _viewState;

    #endregion

    #region Properties

    public LocalizedMantisEntity AccessLevel
    {
      get { return _accessLevel; }
      internal set { _accessLevel = value; }
    }

    public CategoryCollection Categories
    {
      get { return _categories; }
      internal set { _categories = value; }
    }

    public CustomFieldCollection CustomFields
    {
      get { return _customFields; }
      internal set { _customFields = value; }
    }

    public string Description
    {
      get { return _description; }
      internal set { _description = value; }
    }

    public bool Enabled
    {
      get { return _enabled; }
      internal set { _enabled = value; }
    }

    public string Name
    {
      get { return _name; }
      internal set { _name = value; }
    }

    public ProjectStatus Status
    {
      get { return _status; }
      internal set { _status = value; }
    }

    public ProjectVersionCollection Versions
    {
      get { return _versions; }
      internal set { _versions = value; }
    }

    public ViewState ViewState
    {
      get { return _viewState; }
      internal set { _viewState = value; }
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
