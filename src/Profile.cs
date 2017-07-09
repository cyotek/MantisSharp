﻿using PetaJson;

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
      internal set { _description = value; }
    }

    [Json("os")]
    public string OperatingSystem
    {
      get { return _operatingSystem; }
      internal set { _operatingSystem = value; }
    }

    [Json("os_build")]
    public string OperatingSystemBuild
    {
      get { return _operatingSystemBuild; }
      internal set { _operatingSystemBuild = value; }
    }

    [Json("platform")]
    public string Platform
    {
      get { return _platform; }
      internal set { _platform = value; }
    }

    [Json("user")]
    public User User
    {
      get { return _user; }
      internal set { _user = value; }
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
