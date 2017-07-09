using System.ComponentModel;

namespace MantisSharp
{
  public class Project
  {
    #region Fields

    private LocalizedMantisReference _accessLevel;

    private CategoryCollection _categories;

    private CustomFieldCollection _customFields;

    private string _description;

    private bool _enabled;

    private int _id;

    private string _name;

    private LocalizedMantisReference _status;

    private ProjectVersionCollection _versions;

    private LocalizedMantisReference _viewState;

    #endregion

    #region Properties

    public LocalizedMantisReference AccessLevel
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

    [Browsable(false)]
    public int Id
    {
      get { return _id; }
      internal set { _id = value; }
    }

    public string Name
    {
      get { return _name; }
      internal set { _name = value; }
    }

    public LocalizedMantisReference Status
    {
      get { return _status; }
      internal set { _status = value; }
    }

    public ProjectVersionCollection Versions
    {
      get { return _versions; }
      internal set { _versions = value; }
    }

    public LocalizedMantisReference ViewState
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
