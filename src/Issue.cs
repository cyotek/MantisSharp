using System;
using PetaJson;

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

    private RelationshipCollection _relationships;

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

    [Json("additional_information")]
    public string AdditionalInformation
    {
      get { return _additionalInformation; }
      set { _additionalInformation = value; }
    }

    [Json("handler")]
    public User AssignedTo
    {
      get { return _assignedTo; }
      set { _assignedTo = value; }
    }

    [Json("attachments")]

    public AttachmentCollection Attachments
    {
      get { return _attachments; }
      set { _attachments = value; }
    }

    [Json("category")]
    public Reference Category
    {
      get { return _category; }
      set { _category = value; }
    }

    public DateTime Created
    {
      get { return _created; }
      set { _created = value; }
    }

    [Json("description")]
    public string Description
    {
      get { return _description; }
      set { _description = value; }
    }

    [Json("fixed_in_version")]
    public Reference FixVersion
    {
      get { return _fixVersion; }
      set { _fixVersion = value; }
    }

    public DateTime LastModified
    {
      get { return _lastModified; }
      set { _lastModified = value; }
    }

    [Json("monitors")]
    public UserCollection Monitors
    {
      get { return _monitors; }
      set { _monitors = value; }
    }

    [Json("notes")]
    public NoteCollection Notes
    {
      get { return _notes; }
      set { _notes = value; }
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

    [Json("priority")]
    public IssuePriority Priority
    {
      get { return _priority; }
      set { _priority = value; }
    }

    [Json("profile")]
    public Profile Profile
    {
      get { return _profile; }
      set { _profile = value; }
    }

    [Json("project")]
    public Reference Project
    {
      get { return _project; }
      set { _project = value; }
    }

    [Json("relationships")]
    public RelationshipCollection Relationships
    {
      get { return _relationships; }
      set { _relationships = value; }
    }

    [Json("reporter")]
    public User Reporter
    {
      get { return _reporter; }
      set { _reporter = value; }
    }

    [Json("reproducibility")]
    public IssueReproducability Reproducibility
    {
      get { return _reproducibility; }
      set { _reproducibility = value; }
    }

    [Json("resolution")]
    public IssueResolution Resolution
    {
      get { return _resolution; }
      set { _resolution = value; }
    }

    [Json("severity")]
    public IssueSeverity Severity
    {
      get { return _severity; }
      set { _severity = value; }
    }

    [Json("status")]
    public IssueStatus Status
    {
      get { return _status; }
      set { _status = value; }
    }

    [Json("steps_to_reproduce")]
    public string StepsToReproduce
    {
      get { return _stepsToReproduce; }
      set { _stepsToReproduce = value; }
    }

    [Json("sticky")]
    public bool Sticky
    {
      get { return _sticky; }
      set { _sticky = value; }
    }

    [Json("summary")]
    public string Summary
    {
      get { return _summary; }
      set { _summary = value; }
    }

    [Json("tags")]
    public TagCollection Tags
    {
      get { return _tags; }
      set { _tags = value; }
    }

    [Json("target_version")]
    public Reference TargetVersion
    {
      get { return _targetVersion; }
      set { _targetVersion = value; }
    }

    [Json("version")]
    public Reference Version
    {
      get { return _version; }
      set { _version = value; }
    }

    [Json("view_state")]
    public ViewState ViewState
    {
      get { return _viewState; }
      set { _viewState = value; }
    }

    #endregion
  }
}
