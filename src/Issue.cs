using System;
using System.ComponentModel;

namespace MantisSharp
{
  public class Issue
  {
    #region Fields

    private string _additionalInformation;

    private User _assignedTo;

    private AttachmentCollection _attachments;

    private MantisReference _category;

    private DateTime _created;

    private string _description;

    private MantisReference _fixVersion;

    private int _id;

    private DateTime _lastModified;

    private NoteCollection _notes;

    private string _operatingSystem;

    private string _operatingSystemBuild;

    private string _platform;

    private LocalizedMantisReference _priority;

    private Profile _profile;

    private MantisReference _project;

    private User _reporter;

    private LocalizedMantisReference _reproducibility;

    private LocalizedMantisReference _resolution;

    private LocalizedMantisReference _severity;

    private IssueStatus _status;

    private string _stepsToReproduce;

    private bool _sticky;

    private string _summary;

    private MantisReferenceCollection _tags;

    private MantisReference _targetVersion;

    private MantisReference _version;

    private LocalizedMantisReference _viewState;

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

    public MantisReference Category
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

    public MantisReference FixVersion
    {
      get { return _fixVersion; }
      internal set { _fixVersion = value; }
    }

    [Browsable(false)]
    public int Id
    {
      get { return _id; }
      internal set { _id = value; }
    }

    public DateTime LastModified
    {
      get { return _lastModified; }
      internal set { _lastModified = value; }
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

    public LocalizedMantisReference Priority
    {
      get { return _priority; }
      internal set { _priority = value; }
    }

    public Profile Profile
    {
      get { return _profile; }
      set { _profile = value; }
    }

    public MantisReference Project
    {
      get { return _project; }
      internal set { _project = value; }
    }

    public User Reporter
    {
      get { return _reporter; }
      internal set { _reporter = value; }
    }

    public LocalizedMantisReference Reproducibility
    {
      get { return _reproducibility; }
      internal set { _reproducibility = value; }
    }

    public LocalizedMantisReference Resolution
    {
      get { return _resolution; }
      internal set { _resolution = value; }
    }

    public LocalizedMantisReference Severity
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

    public MantisReferenceCollection Tags
    {
      get { return _tags; }
      internal set { _tags = value; }
    }

    public MantisReference TargetVersion
    {
      get { return _targetVersion; }
      internal set { _targetVersion = value; }
    }

    public MantisReference Version
    {
      get { return _version; }
      internal set { _version = value; }
    }

    public LocalizedMantisReference ViewState
    {
      get { return _viewState; }
      internal set { _viewState = value; }
    }

    #endregion
  }
}
