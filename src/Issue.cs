using System;

// Copyright (c) 2017 Cyotek Ltd.
// http://mantissharp.net/
// Licensed under the MIT License. See LICENSE.txt for the full text.

// If you use this control in your applications, attribution, donations or contributions are welcome.


namespace MantisSharp
{
  public class Issue : MantisEntity
  {
    #region Fields

    private string _additionalInformation;

    private User _assignedTo;

    private AttachmentCollection _attachments;

    private Reference _category;

    private DateTime _created;

    private string _description;

    private Reference _fixVersion;

    private DateTime _lastModified;

    private UserCollection _monitors;

    private NoteCollection _notes;

    private string _operatingSystem;

    private string _operatingSystemBuild;

    private string _platform;

    private IssuePriority _priority;

    private Profile _profile;

    private Reference _project;

    private User _reporter;

    private IssueReproducability _reproducibility;

    private IssueResolution _resolution;

    private IssueSeverity _severity;

    private IssueStatus _status;

    private string _stepsToReproduce;

    private bool _sticky;

    private string _summary;

    private TagCollection _tags;

    private Reference _targetVersion;

    private Reference _version;

    private ViewState _viewState;

    #endregion

    #region Properties

    public string AdditionalInformation
    {
      get { return _additionalInformation; }
      internal set { _additionalInformation = value; }
    }

    public User AssignedTo
    {
      get { return _assignedTo; }
      internal set { _assignedTo = value; }
    }

    public AttachmentCollection Attachments
    {
      get { return _attachments; }
      internal set { _attachments = value; }
    }

    public Reference Category
    {
      get { return _category; }
      internal set { _category = value; }
    }

    public DateTime Created
    {
      get { return _created; }
      internal set { _created = value; }
    }

    public string Description
    {
      get { return _description; }
      internal set { _description = value; }
    }

    public Reference FixVersion
    {
      get { return _fixVersion; }
      internal set { _fixVersion = value; }
    }

    public DateTime LastModified
    {
      get { return _lastModified; }
      internal set { _lastModified = value; }
    }

    public UserCollection Monitors
    {
      get { return _monitors; }
      internal set { _monitors = value; }
    }

    public NoteCollection Notes
    {
      get { return _notes; }
      internal set { _notes = value; }
    }

    public string OperatingSystem
    {
      get { return _operatingSystem; }
      internal set { _operatingSystem = value; }
    }

    public string OperatingSystemBuild
    {
      get { return _operatingSystemBuild; }
      internal set { _operatingSystemBuild = value; }
    }

    public string Platform
    {
      get { return _platform; }
      internal set { _platform = value; }
    }

    public IssuePriority Priority
    {
      get { return _priority; }
      internal set { _priority = value; }
    }

    public Profile Profile
    {
      get { return _profile; }
      set { _profile = value; }
    }

    public Reference Project
    {
      get { return _project; }
      internal set { _project = value; }
    }

    public User Reporter
    {
      get { return _reporter; }
      internal set { _reporter = value; }
    }

    public IssueReproducability Reproducibility
    {
      get { return _reproducibility; }
      internal set { _reproducibility = value; }
    }

    public IssueResolution Resolution
    {
      get { return _resolution; }
      internal set { _resolution = value; }
    }

    public IssueSeverity Severity
    {
      get { return _severity; }
      internal set { _severity = value; }
    }

    public IssueStatus Status
    {
      get { return _status; }
      internal set { _status = value; }
    }

    public string StepsToReproduce
    {
      get { return _stepsToReproduce; }
      internal set { _stepsToReproduce = value; }
    }

    public bool Sticky
    {
      get { return _sticky; }
      internal set { _sticky = value; }
    }

    public string Summary
    {
      get { return _summary; }
      internal set { _summary = value; }
    }

    public TagCollection Tags
    {
      get { return _tags; }
      internal set { _tags = value; }
    }

    public Reference TargetVersion
    {
      get { return _targetVersion; }
      internal set { _targetVersion = value; }
    }

    public Reference Version
    {
      get { return _version; }
      internal set { _version = value; }
    }

    public ViewState ViewState
    {
      get { return _viewState; }
      internal set { _viewState = value; }
    }

    #endregion
  }
}
