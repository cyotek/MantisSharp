using PetaJson;

// Copyright (c) 2017 Cyotek Ltd.
// http://mantissharp.net/
// Licensed under the MIT License. See LICENSE.txt for the full text.

// If you use this control in your applications, attribution, donations or contributions are welcome.

namespace MantisSharp
{
  public class Profile : NamedMantisEntity
  {
    #region Fields

    private string _description;

    private string _operatingSystem;

    private string _operatingSystemBuild;

    private string _platform;

    private User _user;

    #endregion

    #region Properties

    [Json("description")]
    public string Description
    {
      get { return _description; }
      set { _description = value; }
    }

    [Json("os")]
    public string OperatingSystem
    {
      get { return _operatingSystem; }
      set { _operatingSystem = value; }
    }

    [Json("os_build")]
    public string OperatingSystemBuild
    {
      get { return _operatingSystemBuild; }
      set { _operatingSystemBuild = value; }
    }

    [Json("platform")]
    public string Platform
    {
      get { return _platform; }
      set { _platform = value; }
    }

    [Json("user")]
    public User User
    {
      get { return _user; }
      set { _user = value; }
    }

    #endregion

    #region Methods

    public override string ToString()
    {
      return _platform;
    }

    #endregion
  }
}
