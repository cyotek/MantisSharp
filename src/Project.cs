// Copyright (c) 2017 Cyotek Ltd.
// http://mantissharp.net/
// Licensed under the MIT License. See LICENSE.txt for the full text.

// If you use this control in your applications, attribution, donations or contributions are welcome.

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
      set { _accessLevel = value; }
    }

    public CategoryCollection Categories
    {
      get { return _categories; }
      set { _categories = value; }
    }

    public CustomFieldCollection CustomFields
    {
      get { return _customFields; }
      set { _customFields = value; }
    }

    public string Description
    {
      get { return _description; }
      set { _description = value; }
    }

    public bool Enabled
    {
      get { return _enabled; }
      set { _enabled = value; }
    }

    public string Name
    {
      get { return _name; }
      set { _name = value; }
    }

    public ProjectStatus Status
    {
      get { return _status; }
      set { _status = value; }
    }

    public ProjectVersionCollection Versions
    {
      get { return _versions; }
      set { _versions = value; }
    }

    public ViewState ViewState
    {
      get { return _viewState; }
      set { _viewState = value; }
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
