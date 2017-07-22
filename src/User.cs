using PetaJson;

// Copyright (c) 2017 Cyotek Ltd.
// http://mantissharp.net/
// Licensed under the MIT License. See LICENSE.txt for the full text.

// If you use this control in your applications, attribution, donations or contributions are welcome.

namespace MantisSharp
{
  public class User : NamedMantisEntity
  {
    #region Fields

    private LocalizedMantisEntity _accessLevel;

    private string _emailAddress;

    private string _language;

    private ReferenceCollection _projects;

    private string _realName;

    private string _timeZone;

    #endregion

    #region Properties

    [Json("access_level")]
    public LocalizedMantisEntity AccessLevel
    {
      get { return _accessLevel; }
      set { _accessLevel = value; }
    }

    [Json("email")]
    public string EmailAddress
    {
      get { return _emailAddress; }
      set { _emailAddress = value; }
    }

    [Json("language")]
    public string Language
    {
      get { return _language; }
      set { _language = value; }
    }

    [Json("projects")]
    public ReferenceCollection Projects
    {
      get { return _projects; }
      set { _projects = value; }
    }

    [Json("real_name")]
    public string RealName
    {
      get { return _realName; }
      set { _realName = value; }
    }

    [Json("timezone")]
    public string TimeZone
    {
      get { return _timeZone; }
      set { _timeZone = value; }
    }

    #endregion
  }
}
