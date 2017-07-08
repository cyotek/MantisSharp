namespace MantisSharp
{
  internal sealed class LookupCache
  {
    #region Constants

    private readonly MantisReferenceCache<LocalizedMantisReference> _accessLevelLookup;

    private readonly MantisReferenceCache<MantisReference> _categoryLookup;

    private readonly MantisReferenceCache<LocalizedMantisReference> _priorityLookup;

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
      _statusLookup = new MantisReferenceCache<IssueStatus>();
      _tagLookup = new MantisReferenceCache<MantisReference>();
      _categoryLookup = new MantisReferenceCache<MantisReference>();
      _versionLookup = new MantisReferenceCache<MantisReference>();
      _userLookup = new MantisReferenceCache<User>();
      _projectLookup = new MantisReferenceCache<MantisReference>();
      _resolutionLookup = new MantisReferenceCache<LocalizedMantisReference>();
      _viewStateLookup = new MantisReferenceCache<LocalizedMantisReference>();
      _resolutionLookup = new MantisReferenceCache<LocalizedMantisReference>();
      _priorityLookup = new MantisReferenceCache<LocalizedMantisReference>();
      _severityLookup = new MantisReferenceCache<LocalizedMantisReference>();
      _accessLevelLookup = new MantisReferenceCache<LocalizedMantisReference>();
      _resolutionLookup = new MantisReferenceCache<LocalizedMantisReference>();
      _reproducabilityLookup = new MantisReferenceCache<LocalizedMantisReference>();
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
