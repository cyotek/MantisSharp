using PetaJson;

namespace MantisSharp
{
  public class User : NamedMantisEntity
  {
    #region Fields

    private LocalizedMantisEntity _accessLevel;

    private string _emailAddress;

    private string _language;

    private MantisReferenceCollection _projects;

    private string _realName;

    private string _timeZone;

    #endregion

    #region Properties

    [Json("access_level")]
    public LocalizedMantisEntity AccessLevel
    {
      get { return _accessLevel; }
      internal set { _accessLevel = value; }
    }

    [Json("email")]
    public string EmailAddress
    {
      get { return _emailAddress; }
      internal set { _emailAddress = value; }
    }

    [Json("language")]
    public string Language
    {
      get { return _language; }
      internal set { _language = value; }
    }

    [Json("projects")]
    public MantisReferenceCollection Projects
    {
      get { return _projects; }
      internal set { _projects = value; }
    }

    [Json("real_name")]
    public string RealName
    {
      get { return _realName; }
      internal set { _realName = value; }
    }

    [Json("timezone")]
    public string TimeZone
    {
      get { return _timeZone; }
      internal set { _timeZone = value; }
    }

    #endregion
  }
}
