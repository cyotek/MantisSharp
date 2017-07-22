// Copyright (c) 2017 Cyotek Ltd.
// http://mantissharp.net/
// Licensed under the MIT License. See LICENSE.txt for the full text.

// If you use this control in your applications, attribution, donations or contributions are welcome.

using System;
using System.Windows.Forms;

namespace MantisSharp.Browser
{
  internal partial class CreateIssueDialog : BaseForm
  {
    #region Constants

    private readonly MantisClient _client;

    private readonly Project _project;

    #endregion

    #region Constructors

    public CreateIssueDialog()
    {
      this.InitializeComponent();
    }

    public CreateIssueDialog(MantisClient client, Project project)
      : this()
    {
      _client = client;
      _project = project;
    }

    #endregion

    #region Methods

    protected override void OnShown(EventArgs e)
    {
      base.OnShown(e);

      projectTextBox.Text = _project.Name;
      this.SetDefaultValue(categoryComboBox);
      this.SetDefaultValue(reproducibilityComboBox);
      this.SetDefaultValue(severityComboBox);
      this.SetDefaultValue(priorityComboBox);

#if DEBUG
      categoryComboBox.Text = "1";
      summaryTextBox.Text = "Alpha";
      descriptionTextBox.Text = "Beta";
#endif
    }

    protected override void SetStatusMessage(string message)
    {
      statusToolStripStatusLabel.Text = message;
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }

    private void createButton_Click(object sender, EventArgs e)
    {
      Issue newIssue;

      this.DialogResult = DialogResult.None;

      newIssue = new Issue
                 {
                   Summary = summaryTextBox.Text,
                   Description = descriptionTextBox.Text,
                   StepsToReproduce = stepsToReproduceTextBox.Text,
                   AdditionalInformation = additionalInformationTextBox.Text,
                   Project = new Reference
                             {
                               Id = _project.Id
                             },
                   Category = this.MakeReference<Reference>(categoryComboBox.Text),
                   Reproducibility = this.MakeReference<IssueReproducability>(reproducibilityComboBox.Text),
                   Severity = this.MakeReference<IssueSeverity>(severityComboBox.Text),
                   Priority = this.MakeReference<IssuePriority>(priorityComboBox.Text),
                   Platform = platformTextBox.Text,
                   OperatingSystem = osTextBox.Text,
                   OperatingSystemBuild = osVersionTextBox.Text
                 };

      if (!string.IsNullOrWhiteSpace(tagsTextBox.Text))
      {
        newIssue.Tags = new TagCollection();

        foreach (string tag in tagsTextBox.Text.Split(new[]
                                                      {
                                                        ' '
                                                      }, StringSplitOptions.RemoveEmptyEntries))
        {
          newIssue.Tags.Add(tag);
        }
      }

      if (this.ExecuteRequest(() => { newIssue = _client.CreateIssue(newIssue); }))
      {
        MessageBox.Show(string.Format("Issue {0} successfully created.", newIssue.Id), "Create Issue", MessageBoxButtons.OK, MessageBoxIcon.Information);

        this.DialogResult = DialogResult.OK;
        this.Close();
      }
    }

    private T MakeReference<T>(string text)
      where T : NamedMantisEntity, new()
    {
      T result;

      /*
       * From my testing, it seems that reference fields can use either the
       * name of an item, e.g. "urgent", or the underlying id, e.g. 50.
       */

      if (!string.IsNullOrWhiteSpace(text))
      {
        int id;

        result = new T();

        if (int.TryParse(text, out id))
        {
          result.Id = id;
        }
        else
        {
          result.Name = text;
        }
      }
      else
      {
        result = null;
      }

      return result;
    }

    private void SetDefaultValue(ComboBox control)
    {
      int count;

      count = control.Items.Count;

      if (count > 0)
      {
        int index;

        if (count % 2 == 0)
        {
          index = count / 2;
        }
        else
        {
          index = count / 2 + 1;
        }

        control.SelectedIndex = index;
      }
    }

    #endregion
  }
}
