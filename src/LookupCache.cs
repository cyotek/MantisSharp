﻿namespace MantisSharp
{
  internal sealed class LookupCache
  {
    #region Constants

    private readonly LookupCache<AccessLevel> _accessLevelLookup;

    private readonly LookupCache<NamedMantisEntity> _categoryLookup;

    private readonly LookupCache<IssueStatus> _issueStatusLookup;

    private readonly LookupCache<IssuePriority> _priorityLookup;

    private readonly LookupCache<Profile> _profileLookup;

    private readonly LookupCache<NamedMantisEntity> _projectLookup;

    private readonly LookupCache<ProjectStatus> _projectStatus;

    private readonly LookupCache<IssueReproducability> _reproducabilityLookup;

    private readonly LookupCache<IssueResolution> _resolutionLookup;

    private readonly LookupCache<IssueSeverity> _severityLookup;

    private readonly LookupCache<Tag> _tagLookup;

    private readonly LookupCache<User> _userLookup;

    private readonly LookupCache<NamedMantisEntity> _versionLookup;

    private readonly LookupCache<ViewState> _viewStateLookup;

    #endregion

    #region Constructors

    public LookupCache()
    {
      _accessLevelLookup = new LookupCache<AccessLevel>(this);
      _categoryLookup = new LookupCache<NamedMantisEntity>(this);
      _issueStatusLookup = new LookupCache<IssueStatus>(this);
      _priorityLookup = new LookupCache<IssuePriority>(this);
      _profileLookup = new LookupCache<Profile>(this);
      _projectLookup = new LookupCache<NamedMantisEntity>(this);
      _projectStatus = new LookupCache<ProjectStatus>(this);
      _reproducabilityLookup = new LookupCache<IssueReproducability>(this);
      _resolutionLookup = new LookupCache<IssueResolution>(this);
      _severityLookup = new LookupCache<IssueSeverity>(this);
      _tagLookup = new LookupCache<Tag>(this);
      _userLookup = new LookupCache<User>(this);
      _versionLookup = new LookupCache<NamedMantisEntity>(this);
      _viewStateLookup = new LookupCache<ViewState>(this);
    }

    #endregion

    #region Properties

    public LookupCache<AccessLevel> AccessLevel
    {
      get { return _accessLevelLookup; }
    }

    public LookupCache<NamedMantisEntity> Category
    {
      get { return _categoryLookup; }
    }

    public LookupCache<IssueStatus> IssueStatus
    {
      get { return _issueStatusLookup; }
    }

    public LookupCache<IssuePriority> Priority
    {
      get { return _priorityLookup; }
    }

    public LookupCache<Profile> Profile
    {
      get { return _profileLookup; }
    }

    public LookupCache<NamedMantisEntity> Project
    {
      get { return _projectLookup; }
    }

    public LookupCache<ProjectStatus> ProjectStatus
    {
      get { return _projectStatus; }
    }

    public LookupCache<IssueReproducability> Reproducability
    {
      get { return _reproducabilityLookup; }
    }

    public LookupCache<IssueResolution> Resolution
    {
      get { return _resolutionLookup; }
    }

    public LookupCache<IssueSeverity> Severity
    {
      get { return _severityLookup; }
    }

    public LookupCache<Tag> Tag
    {
      get { return _tagLookup; }
    }

    public LookupCache<User> User
    {
      get { return _userLookup; }
    }

    public LookupCache<NamedMantisEntity> Version
    {
      get { return _versionLookup; }
    }

    public LookupCache<ViewState> ViewState
    {
      get { return _viewStateLookup; }
    }

    #endregion
  }
}
