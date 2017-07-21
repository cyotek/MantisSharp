using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;

// Copyright (c) 2017 Cyotek Ltd.
// http://mantissharp.net/
// Licensed under the MIT License. See LICENSE.txt for the full text.

// If you use this control in your applications, attribution, donations or contributions are welcome.

namespace MantisSharp.Browser
{
  internal sealed partial class MainForm : BaseForm
  {
    #region Fields

    private MantisClient _client;

    private User _currentUser;

    private Dictionary<int, Issue[]> _issuesByProject;

    private Project[] _projects;

    private Issue _selectedIssue;

    private Project _selectedProject;

    #endregion

    #region Constructors

    public MainForm()
    {
      this.InitializeComponent();
    }

    #endregion

    #region Methods

    protected override void OnShown(EventArgs e)
    {
      base.OnShown(e);

      this.InitializeClient();

      this.RequestCurrentUser();
      this.RequestLoadProjects();
    }

    protected override void SetStatusMessage(string message)
    {
      statusToolStripStatusLabel.Text = message;
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (AboutDialog dialog = new AboutDialog())
      {
        dialog.ShowDialog(this);
      }
    }

    private bool CanMakeRequests()
    {
      return !string.IsNullOrWhiteSpace(_client?.BaseUri) && !string.IsNullOrWhiteSpace(_client.ApiKey);
    }

    private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (ListConfigurationValuesDialog dialog = new ListConfigurationValuesDialog(_client))
      {
        dialog.ShowDialog(this);
      }
    }

    private void connectToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (ConnectionDialog dialog = new ConnectionDialog
                                       {
                                         ApiKey = _client.ApiKey,
                                         BaseUri = _client.BaseUri
                                       })
      {
        if (dialog.ShowDialog(this) == DialogResult.OK)
        {
          _client.ApiKey = dialog.ApiKey;
          _client.BaseUri = dialog.BaseUri;

          this.Reconnect();
        }
      }
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void InitializeClient()
    {
      NameValueCollection appSettings;
      string uri;
      string key;
      string[] commandLine;

      ServicePointManager.Expect100Continue = true;
      ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

      commandLine = Environment.GetCommandLineArgs();
      appSettings = ConfigurationManager.AppSettings;

      uri = appSettings["baseUri"];
      key = appSettings["apiKey"];

      if (commandLine.Length == 3)
      {
        uri = commandLine[1];
        key = commandLine[2];
      }

      _client = new MantisClient(uri, key);
    }

    private void issuePropertiesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      PropertiesDialog.ShowDialog(_selectedIssue);
    }

    private void issuesListView_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (issuesListView.SelectedItems.Count != 0)
      {
        _selectedIssue = (Issue)issuesListView.SelectedItems[0].Tag;
      }
      else
      {
        _selectedIssue = null;
      }

      this.LoadHtmlIssueView();
    }

    private void LoadHtmlIssueView()
    {
      webBrowser.DocumentText = _selectedIssue != null ? new HtmlBuilder().BuildHtml(_selectedIssue) : string.Empty;
    }

    private void projectPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      PropertiesDialog.ShowDialog(_selectedProject);
    }

    private void projectsListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      int index;

      index = projectsListBox.SelectedIndex;

      if (index != -1)
      {
        _selectedProject = (Project)projectsListBox.Items[index];
      }
      else
      {
        _selectedProject = null;
      }

      this.RequestLoadIssues();
    }

    private void Reconnect()
    {
      _selectedIssue = null;
      _currentUser = null;
      _issuesByProject.Clear();
      _projects = null;

      projectsListBox.Items.Clear();
      issuesListView.Items.Clear();
      webBrowser.DocumentText = string.Empty;

      this.RequestLoadProjects();
      this.RequestCurrentUser();
    }

    private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Reconnect();
    }

    private void RequestCurrentUser()
    {
      if (this.CanMakeRequests())
      {
        ThreadPool.QueueUserWorkItem(state =>
                                     {
                                       this.ExecuteRequest(() =>
                                                           {
                                                             _currentUser = _client.GetCurrentUser();

                                                             this.UpdateUserDisplay();
                                                           });
                                     });
      }
      else
      {
        _currentUser = new User();
        this.UpdateUserDisplay();
      }
    }

    private void RequestLoadIssues()
    {
      if (_selectedProject != null && !_issuesByProject.ContainsKey(_selectedProject.Id) && this.CanMakeRequests())
      {
        ThreadPool.QueueUserWorkItem(state =>
                                     {
                                       this.ExecuteRequest(() =>
                                                           {
                                                             int projectId;
                                                             Issue[] issues;

                                                             projectId = (int)state;

                                                             issues = _client.GetIssues(projectId).ToArray();

                                                             _issuesByProject[projectId] = issues;

                                                             this.UpdateIssuesList();
                                                           });
                                     }, _selectedProject.Id);
      }
      else
      {
        this.UpdateIssuesList();
      }
    }

    private void RequestLoadProjects()
    {
      _issuesByProject = new Dictionary<int, Issue[]>();

      if (this.CanMakeRequests())
      {
        ThreadPool.QueueUserWorkItem(state =>
                                     {
                                       this.ExecuteRequest(() =>
                                                           {
                                                             _projects = _client.GetProjects().ToArray();

                                                             this.UpdateProjectsList();
                                                           });
                                     });
      }
      else
      {
        _projects = new Project[0];
        this.UpdateProjectsList();
      }
    }

    private void UpdateIssuesList()
    {
      if (this.InvokeRequired)
      {
        this.Invoke(new MethodInvoker(this.UpdateIssuesList));
      }
      else
      {
        ListView.ListViewItemCollection items;
        Issue[] issues;

        _selectedIssue = null;
        items = issuesListView.Items;

        issuesListView.BeginUpdate();

        items.Clear();

        if (_selectedProject != null && _issuesByProject.TryGetValue(_selectedProject.Id, out issues))
        {
          foreach (Issue issue in issues)
          {
            ListViewItem item;

            item = new ListViewItem
                   {
                     Name = issue.Id.ToString(),
                     Tag = issue,
                     UseItemStyleForSubItems = false
                   };

            item.Text = issue.Priority.Label;
            item.SubItems.Add(issue.Id.ToString("######"));
            item.SubItems.Add(issue.Category.Name);
            item.SubItems.Add(issue.Severity.Label);
            item.SubItems.Add(issue.Status.Label).ForeColor = ColorTranslator.FromHtml(issue.Status.Color);
            item.SubItems.Add(issue.LastModified.ToShortDateString());
            item.SubItems.Add(issue.Summary);

            items.Add(item);
          }
        }

        issuesListView.EndUpdate();

        if (items.Count > 0)
        {
          issuesListView.SelectedIndices.Add(0);
        }
      }
    }

    private void UpdateProjectsList()
    {
      if (this.InvokeRequired)
      {
        this.Invoke(new MethodInvoker(this.UpdateProjectsList));
      }
      else
      {
        ListBox.ObjectCollection items;

        items = projectsListBox.Items;

        projectsListBox.BeginUpdate();

        items.Clear();

        foreach (Project project in _projects)
        {
          items.Add(project);
        }

        projectsListBox.EndUpdate();

        if (projectsListBox.Items.Count > 0)
        {
          projectsListBox.SelectedIndex = 0;
        }
      }
    }

    private void UpdateUserDisplay()
    {
      if (this.InvokeRequired)
      {
        this.Invoke(new MethodInvoker(this.UpdateUserDisplay));
      }
      else
      {
        userNameToolStripStatusLabel.Text = _currentUser.Name;
        accessLevelToolStripStatusLabel.Text = _currentUser.AccessLevel?.Label;
        versionToolStripStatusLabel.Text = "MantisBT: " + _client.MantisVersion;
      }
    }

    private void userPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      PropertiesDialog.ShowDialog(_currentUser);
    }

    #endregion
  }
}
