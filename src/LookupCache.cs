// Copyright (c) 2017 Cyotek Ltd.
// http://mantissharp.net/
// Licensed under the MIT License. See LICENSE.txt for the full text.

// If you use this control in your applications, attribution, donations or contributions are welcome.

namespace MantisSharp
{
  internal sealed class LookupCache
  {
    #region Constants

    private readonly LookupCache<AccessLevel> _accessLevelLookup;

    private readonly LookupCache<Reference> _categoryLookup;

    private readonly LookupCache<IssueStatus> _issueStatusLookup;

    private readonly LookupCache<IssuePriority> _priorityLookup;

    private readonly LookupCache<Profile> _profileLookup;

    private readonly LookupCache<Reference> _projectLookup;

    private readonly LookupCache<ProjectStatus> _projectStatus;

    private readonly LookupCache<IssueReproducability> _reproducabilityLookup;

    private readonly LookupCache<IssueResolution> _resolutionLookup;

    private readonly LookupCache<IssueSeverity> _severityLookup;

    private readonly LookupCache<Tag> _tagLookup;

    private readonly LookupCache<User> _userLookup;

    private readonly LookupCache<Reference> _versionLookup;

    private readonly LookupCache<ViewState> _viewStateLookup;

    #endregion

    #region Constructors

    public LookupCache()
    {
      _accessLevelLookup = new LookupCache<AccessLevel>(this);
      _categoryLookup = new LookupCache<Reference>(this);
      _issueStatusLookup = new LookupCache<IssueStatus>(this);
      _priorityLookup = new LookupCache<IssuePriority>(this);
      _profileLookup = new LookupCache<Profile>(this);
      _projectLookup = new LookupCache<Reference>(this);
      _projectStatus = new LookupCache<ProjectStatus>(this);
      _reproducabilityLookup = new LookupCache<IssueReproducability>(this);
      _resolutionLookup = new LookupCache<IssueResolution>(this);
      _severityLookup = new LookupCache<IssueSeverity>(this);
      _tagLookup = new LookupCache<Tag>(this);
      _userLookup = new LookupCache<User>(this);
      _versionLookup = new LookupCache<Reference>(this);
      _viewStateLookup = new LookupCache<ViewState>(this);
    }

    #endregion

    #region Properties

    public LookupCache<AccessLevel> AccessLevel
    {
      get { return _accessLevelLookup; }
    }

    public LookupCache<Reference> Category
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

    public LookupCache<Reference> Project
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

    public LookupCache<Reference> Version
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
