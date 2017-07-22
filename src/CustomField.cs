using PetaJson;

// Copyright (c) 2017 Cyotek Ltd.
// http://mantissharp.net/
// Licensed under the MIT License. See LICENSE.txt for the full text.

// If you use this control in your applications, attribution, donations or contributions are welcome.

namespace MantisSharp
{
  public class CustomField : NamedMantisEntity
  {
    #region Fields

    private string _defaultValue;

    private int _maximumLength;

    private int _minimumLength;

    private string _possibleValues;

    private AccessLevel _readAccessLevel;

    private bool _requireOnClose;

    private bool _requireOnReport;

    private bool _requireOnResolve;

    private bool _requireOnUpdate;

    private bool _showOnClose;

    private bool _showOnReport;

    private bool _showOnResolve;

    private bool _showOnUpdate;

    private string _type;

    private string _validationExpression;

    private AccessLevel _writeAccessLevel;

    #endregion

    #region Properties

    [Json("default_value")]
    public string DefaultValue
    {
      get { return _defaultValue; }
      set { _defaultValue = value; }
    }

    [Json("length_min")]
    public int MaximumLength
    {
      get { return _maximumLength; }
      set { _maximumLength = value; }
    }

    [Json("length_max")]
    public int MinimumLength
    {
      get { return _minimumLength; }
      set { _minimumLength = value; }
    }

    [Json("possible_values")]
    public string PossibleValues
    {
      get { return _possibleValues; }
      set { _possibleValues = value; }
    }

    [Json("access_level_r")]
    public AccessLevel ReadAccessLevel
    {
      get { return _readAccessLevel; }
      set { _readAccessLevel = value; }
    }

    [Json("require_closed")]
    public bool RequireOnClose
    {
      get { return _requireOnClose; }
      set { _requireOnClose = value; }
    }

    [Json("require_report")]
    public bool RequireOnReport
    {
      get { return _requireOnReport; }
      set { _requireOnReport = value; }
    }

    [Json("require_resolved")]
    public bool RequireOnResolve
    {
      get { return _requireOnResolve; }
      set { _requireOnResolve = value; }
    }

    [Json("require_update")]
    public bool RequireOnUpdate
    {
      get { return _requireOnUpdate; }
      set { _requireOnUpdate = value; }
    }

    [Json("display_closed")]
    public bool ShowOnClose
    {
      get { return _showOnClose; }
      set { _showOnClose = value; }
    }

    [Json("display_report")]
    public bool ShowOnReport
    {
      get { return _showOnReport; }
      set { _showOnReport = value; }
    }

    [Json("display_resolved")]
    public bool ShowOnResolve
    {
      get { return _showOnResolve; }
      set { _showOnResolve = value; }
    }

    [Json("display_update")]
    public bool ShowOnUpdate
    {
      get { return _showOnUpdate; }
      set { _showOnUpdate = value; }
    }

    [Json("type")]
    public string Type
    {
      get { return _type; }
      set { _type = value; }
    }

    [Json("valid_regexp")]
    public string ValidationExpression
    {
      get { return _validationExpression; }
      set { _validationExpression = value; }
    }

    [Json("access_level_rw")]
    public AccessLevel WriteAccessLevel
    {
      get { return _writeAccessLevel; }
      set { _writeAccessLevel = value; }
    }

    #endregion
  }
}
