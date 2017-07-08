namespace MantisSharp
{
  internal sealed class LookupCache
  {
    #region Constants

    private readonly MantisReferenceCache<LocalizedMantisReference> _accessLevelLookup;

    private readonly MantisReferenceCache<MantisReference> _categoryLookup;

    private readonly MantisReferenceCache<LocalizedMantisReference> _priorityLookup;

    private readonly MantisReferenceCache<Profile> _profileLookup;

    private readonly MantisReferenceCache<MantisReference> _projectLookup;

    private readonly MantisReferenceCache<LocalizedMantisReference> _reproducabilityLookup;

    private readonly MantisReferenceCache<LocalizedMantisReference> _resolutionLookup;

    private readonly MantisReferenceCache<LocalizedMantisReference> _severityLookup;

    private readonly MantisReferenceCache<IssueStatus> _statusLookup;

    private readonly MantisReferenceCache<MantisReference> _tagLookup;

    private readonly MantisReferenceCache<User> _userLookup;

    private readonly MantisReferenceCache<MantisReference> _versionLookup;

    private readonly MantisReferenceCache<LocalizedMantisReference> _viewStateLookup;

    #endregion

    #region Constructors

    public LookupCache()
    {
      _profileLookup = new MantisReferenceCache<Profile>(this);
      _statusLookup = new MantisReferenceCache<IssueStatus>(this);
      _tagLookup = new MantisReferenceCache<MantisReference>(this);
      _categoryLookup = new MantisReferenceCache<MantisReference>(this);
      _versionLookup = new MantisReferenceCache<MantisReference>(this);
      _userLookup = new MantisReferenceCache<User>(this);
      _projectLookup = new MantisReferenceCache<MantisReference>(this);
      _resolutionLookup = new MantisReferenceCache<LocalizedMantisReference>(this);
      _viewStateLookup = new MantisReferenceCache<LocalizedMantisReference>(this);
      _resolutionLookup = new MantisReferenceCache<LocalizedMantisReference>(this);
      _priorityLookup = new MantisReferenceCache<LocalizedMantisReference>(this);
      _severityLookup = new MantisReferenceCache<LocalizedMantisReference>(this);
      _accessLevelLookup = new MantisReferenceCache<LocalizedMantisReference>(this);
      _resolutionLookup = new MantisReferenceCache<LocalizedMantisReference>(this);
      _reproducabilityLookup = new MantisReferenceCache<LocalizedMantisReference>(this);
    }

    #endregion

    #region Properties

    public MantisReferenceCache<LocalizedMantisReference> AccessLevel
    {
      get { return _accessLevelLookup; }
    }

    public MantisReferenceCache<MantisReference> Category
    {
      get { return _categoryLookup; }
    }

    public MantisReferenceCache<LocalizedMantisReference> Priority
    {
      get { return _priorityLookup; }
    }

    public MantisReferenceCache<Profile> Profile
    {
      get { return _profileLookup; }
    }

    public MantisReferenceCache<MantisReference> Project
    {
      get { return _projectLookup; }
    }

    public MantisReferenceCache<LocalizedMantisReference> Reproducability
    {
      get { return _reproducabilityLookup; }
    }

    public MantisReferenceCache<LocalizedMantisReference> Resolution
    {
      get { return _resolutionLookup; }
    }

    public MantisReferenceCache<LocalizedMantisReference> Severity
    {
      get { return _severityLookup; }
    }

    public MantisReferenceCache<IssueStatus> Status
    {
      get { return _statusLookup; }
    }

    public MantisReferenceCache<MantisReference> Tag
    {
      get { return _tagLookup; }
    }

    public MantisReferenceCache<User> User
    {
      get { return _userLookup; }
    }

    public MantisReferenceCache<MantisReference> Version
    {
      get { return _versionLookup; }
    }

    public MantisReferenceCache<LocalizedMantisReference> ViewState
    {
      get { return _viewStateLookup; }
    }

    #endregion
  }
}
