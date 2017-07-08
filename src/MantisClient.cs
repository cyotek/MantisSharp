using System;
using System.Collections.Generic;
using System.Linq;
using PetaJson;

namespace MantisSharp
{
  public class MantisClient
  {
    #region Constants

    private const string _currentUserApi = _usersApi + "me";

    private const int _defaultPage = 1;

    private const int _defaultPageSize = 50; // from issues_rest.php

    private const string _issuesUri = "issues/";

    private readonly LookupCache _lookupCache;

    private const string _mantisApiUri = "api/rest/";

    private const string _projectsUri = "projects/";

    private readonly RestClient _restClient;

    private const string _usersApi = "users/";

    #endregion

    #region Fields

    private string _apiKey;

    private string _baseUri;

    #endregion

    #region Constructors

    public MantisClient()
    {
      _restClient = new RestClient();
    }

    public MantisClient(Uri baseUri, string apiKey)
      : this(baseUri.OriginalString, apiKey)
    { }

    public MantisClient(string baseUri, string apiKey)
      : this()
    {
      _lookupCache = new LookupCache();

      _baseUri = this.NormalizeUri(baseUri);
      _apiKey = apiKey;
      _restClient.Authorization = _apiKey;
    }

    #endregion

    #region Properties

    public string ApiKey
    {
      get { return _apiKey; }
      set
      {
        _apiKey = value;
        _restClient.Authorization = value;
      }
    }

    public string BaseUri
    {
      get { return _baseUri; }
      set { _baseUri = this.NormalizeUri(value); }
    }

    public string MantisVersion
    {
      get { return _restClient?.MantisVersion; }
    }

    #endregion

    #region Methods

    public User GetCurrentUser()
    {
      return this.LoadItem(_currentUserApi, null, this.CreateAndPopulateUser);
    }

    public Issue GetIssue(int issueId)
    {
      QueryStringBuilder qsb;

      qsb = new QueryStringBuilder();
      qsb.Add("id", issueId);

      return this.LoadItems(_issuesUri, qsb.ToString(), "issues", this.CreateAndPopulateIssue).First();
    }

    public IEnumerable<Issue> GetIssues(Project project)
    {
      if (project == null)
      {
        throw new ArgumentNullException(nameof(project));
      }

      return this.GetIssues(project.Id);
    }

    public IEnumerable<Issue> GetIssues()
    {
      return this.GetIssues(0);
    }

    public IEnumerable<Issue> GetIssues(int projectId)
    {
      return this.GetIssues(projectId, 0, 0);
    }

    public IEnumerable<Issue> GetIssues(int page, int pageSize)
    {
      return this.GetIssues(0, page, pageSize);
    }

    public IEnumerable<Issue> GetIssues(int projectId, int page, int pageSize)
    {
      return this.GetIssues(projectId, page, pageSize, 0);
    }

    public IEnumerable<Issue> GetIssues(int projectId, int page, int pageSize, int filterId)
    {
      QueryStringBuilder qsb;

      qsb = new QueryStringBuilder();

      if (projectId > 0)
      {
        qsb.Add("project_id", projectId);
      }

      if (page > 0)
      {
        qsb.Add("page", page);
      }

      if (pageSize > 0)
      {
        qsb.Add("page_size", pageSize);
      }

      if (filterId > 0)
      {
        qsb.Add("filter_id", pageSize);
      }

      return this.LoadItems(_issuesUri, qsb.ToString(), "issues", this.CreateAndPopulateIssue);
    }

    public IEnumerable<Project> GetProjects()
    {
      return this.LoadItems(_projectsUri, null, "projects", this.CreateAndPopulateProject);
    }

    private void CheckConfiguration()
    {
#if NET20 || NET35
      if (string.IsNullOrEmpty(_baseUri))
#else
      if (string.IsNullOrWhiteSpace(_baseUri))
#endif
      {
        throw new InvalidOperationException("MantisBT base URI not set.");
      }

#if NET20 || NET35
      if (string.IsNullOrEmpty(_apiKey))
#else
      if (string.IsNullOrWhiteSpace(_apiKey))
#endif
      {
        throw new InvalidOperationException("API key not set.");
      }
    }

    private Issue CreateAndPopulateIssue(Dictionary<string, object> props)
    {
      return new Issue
             {
               Id = props.GetInteger("id"),
               Summary = props.GetString("summary"),
               Description = props.GetString("description"),
               StepsToReproduce = props.GetString("steps_to_reproduce"),
               AdditionalInformation = props.GetString("additional_information"),
               TargetVersion = props.GetReference("target_version", _lookupCache.Version),
               Version = props.GetReference("version", _lookupCache.Version),
               FixVersion = props.GetReference("fixed_in_version", _lookupCache.Version),
               Category = props.GetReference("category", _lookupCache.Category),
               Reporter = props.GetReference("reporter", _lookupCache.User),
               AssignedTo = props.GetReference("handler", _lookupCache.User),
               Status = props.GetReference("status", _lookupCache.Status),
               Project = props.GetReference("project", _lookupCache.Project),
               Resolution = props.GetReference("resolution", _lookupCache.Resolution),
               ViewState = props.GetReference("view_state", _lookupCache.ViewState),
               Priority = props.GetReference("priority", _lookupCache.Priority),
               Severity = props.GetReference("severity", _lookupCache.Severity),
               Reproducibility = props.GetReference("reproducibility", _lookupCache.Reproducability),
               Sticky = props.GetBoolean("sticky"),
               Created = props.GetDateTime("created_at"),
               LastModified = props.GetDateTime("updated_at"),
               Tags = props.GetReferences<MantisReferenceCollection, MantisReference>("tags", _lookupCache.Tag),
               Attachments = props.GetChildren<AttachmentCollection, Attachment>("attachments", _lookupCache),
               Notes = props.GetChildren<NoteCollection, Note>("notes", _lookupCache)
             };
    }

    private Project CreateAndPopulateProject(Dictionary<string, object> props)
    {
      return new Project
             {
               Id = props.GetInteger("id"),
               Name = props.GetString("name"),
               Description = props.GetString("description"),
               Enabled = props.GetBoolean("enabled")
             };
    }

    private User CreateAndPopulateUser(Dictionary<string, object> props)
    {
      return new User
             {
               Id = props.GetInteger("id"),
               Name = props.GetString("name"),
               RealName = props.GetString("real_name"),
               Language = props.GetString("language"),
               TimeZone = props.GetString("timezone"),
               AccessLevel = props.GetReference("access_level", _lookupCache.AccessLevel),
               Projects = props.GetReferences<MantisReferenceCollection, MantisReference>("projects", _lookupCache.Project),
               EmailAddress = props.GetString("email")
             };
    }

    private string GetUri(string fragment)
    {
      return _baseUri + _mantisApiUri + fragment;
    }

    private T LoadItem<T>(string uriFragment, string query, Func<Dictionary<string, object>, T> createItem)
    {
      string uri;
      Dictionary<string, object> data;

      this.CheckConfiguration();

      uri = this.GetUri(uriFragment);
      data = null;

      _restClient.ExecuteRequest(uri, query, reader => { data = Json.Parse<Dictionary<string, object>>(reader); });

      return createItem(data);
    }

    private IEnumerable<T> LoadItems<T>(string uriFragment, string query, string key, Func<Dictionary<string, object>, T> createItem)
    {
      string uri;
      Dictionary<string, object> data;
      List<object> items;

      this.CheckConfiguration();

      uri = this.GetUri(uriFragment);
      data = null;

      _restClient.ExecuteRequest(uri, query, reader => { data = Json.Parse<Dictionary<string, object>>(reader); });

      items = (List<object>)data[key];

      for (int i = 0; i < items.Count; i++)
      {
        T item;
        Dictionary<string, object> itemProps;

        itemProps = (Dictionary<string, object>)items[i];

        item = createItem(itemProps);

        yield return item;
      }
    }

    private string NormalizeUri(string uri)
    {
      // TODO: Check for query strings and fragements and throw if found

#if NET20 || NET35
      if (!string.IsNullOrEmpty(uri)
#else
      if (!string.IsNullOrWhiteSpace(uri)
#endif
          && uri[uri.Length - 1] != '/')
      {
        uri += "/";
      }

      return uri;
    }

    #endregion
  }
}
