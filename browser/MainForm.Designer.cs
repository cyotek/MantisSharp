namespace MantisSharp.Browser
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.projectsSplitContainer = new System.Windows.Forms.SplitContainer();
      this.projectsListBox = new System.Windows.Forms.ListBox();
      this.issuesSplitContainer = new System.Windows.Forms.SplitContainer();
      this.issuesListView = new System.Windows.Forms.ListView();
      this.priorityColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.idColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.categoryColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.severityColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.statusColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.updatedColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.summaryColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.attachmentsSplitContainer = new System.Windows.Forms.SplitContainer();
      this.detailTextBox = new System.Windows.Forms.TextBox();
      this.attachmentsLinkLabel = new System.Windows.Forms.LinkLabel();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.userPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.connectToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.statusToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.userNameToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.accessLevelToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.versionToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      ((System.ComponentModel.ISupportInitialize)(this.projectsSplitContainer)).BeginInit();
      this.projectsSplitContainer.Panel1.SuspendLayout();
      this.projectsSplitContainer.Panel2.SuspendLayout();
      this.projectsSplitContainer.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.issuesSplitContainer)).BeginInit();
      this.issuesSplitContainer.Panel1.SuspendLayout();
      this.issuesSplitContainer.Panel2.SuspendLayout();
      this.issuesSplitContainer.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.attachmentsSplitContainer)).BeginInit();
      this.attachmentsSplitContainer.Panel1.SuspendLayout();
      this.attachmentsSplitContainer.Panel2.SuspendLayout();
      this.attachmentsSplitContainer.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // projectsSplitContainer
      // 
      this.projectsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.projectsSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.projectsSplitContainer.Location = new System.Drawing.Point(0, 49);
      this.projectsSplitContainer.Name = "projectsSplitContainer";
      // 
      // projectsSplitContainer.Panel1
      // 
      this.projectsSplitContainer.Panel1.Controls.Add(this.projectsListBox);
      // 
      // projectsSplitContainer.Panel2
      // 
      this.projectsSplitContainer.Panel2.Controls.Add(this.issuesSplitContainer);
      this.projectsSplitContainer.Size = new System.Drawing.Size(922, 401);
      this.projectsSplitContainer.SplitterDistance = 250;
      this.projectsSplitContainer.TabIndex = 2;
      // 
      // projectsListBox
      // 
      this.projectsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.projectsListBox.IntegralHeight = false;
      this.projectsListBox.Location = new System.Drawing.Point(0, 0);
      this.projectsListBox.Name = "projectsListBox";
      this.projectsListBox.Size = new System.Drawing.Size(250, 401);
      this.projectsListBox.TabIndex = 0;
      this.projectsListBox.SelectedIndexChanged += new System.EventHandler(this.projectsListBox_SelectedIndexChanged);
      // 
      // issuesSplitContainer
      // 
      this.issuesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.issuesSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
      this.issuesSplitContainer.Location = new System.Drawing.Point(0, 0);
      this.issuesSplitContainer.Name = "issuesSplitContainer";
      this.issuesSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // issuesSplitContainer.Panel1
      // 
      this.issuesSplitContainer.Panel1.Controls.Add(this.issuesListView);
      // 
      // issuesSplitContainer.Panel2
      // 
      this.issuesSplitContainer.Panel2.Controls.Add(this.attachmentsSplitContainer);
      this.issuesSplitContainer.Size = new System.Drawing.Size(668, 401);
      this.issuesSplitContainer.SplitterDistance = 201;
      this.issuesSplitContainer.TabIndex = 3;
      // 
      // issuesListView
      // 
      this.issuesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.priorityColumnHeader,
            this.idColumnHeader,
            this.categoryColumnHeader,
            this.severityColumnHeader,
            this.statusColumnHeader,
            this.updatedColumnHeader,
            this.summaryColumnHeader});
      this.issuesListView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.issuesListView.FullRowSelect = true;
      this.issuesListView.HideSelection = false;
      this.issuesListView.Location = new System.Drawing.Point(0, 0);
      this.issuesListView.Name = "issuesListView";
      this.issuesListView.Size = new System.Drawing.Size(668, 201);
      this.issuesListView.TabIndex = 1;
      this.issuesListView.UseCompatibleStateImageBehavior = false;
      this.issuesListView.View = System.Windows.Forms.View.Details;
      this.issuesListView.SelectedIndexChanged += new System.EventHandler(this.issuesListView_SelectedIndexChanged);
      // 
      // priorityColumnHeader
      // 
      this.priorityColumnHeader.Text = "Priority";
      // 
      // idColumnHeader
      // 
      this.idColumnHeader.Text = "Id";
      this.idColumnHeader.Width = 40;
      // 
      // categoryColumnHeader
      // 
      this.categoryColumnHeader.Text = "Category";
      this.categoryColumnHeader.Width = 80;
      // 
      // severityColumnHeader
      // 
      this.severityColumnHeader.Text = "Severity";
      this.severityColumnHeader.Width = 80;
      // 
      // statusColumnHeader
      // 
      this.statusColumnHeader.Text = "Status";
      this.statusColumnHeader.Width = 80;
      // 
      // updatedColumnHeader
      // 
      this.updatedColumnHeader.Text = "Updated";
      this.updatedColumnHeader.Width = 80;
      // 
      // summaryColumnHeader
      // 
      this.summaryColumnHeader.Text = "Summary";
      this.summaryColumnHeader.Width = 360;
      // 
      // attachmentsSplitContainer
      // 
      this.attachmentsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.attachmentsSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
      this.attachmentsSplitContainer.Location = new System.Drawing.Point(0, 0);
      this.attachmentsSplitContainer.Name = "attachmentsSplitContainer";
      // 
      // attachmentsSplitContainer.Panel1
      // 
      this.attachmentsSplitContainer.Panel1.Controls.Add(this.detailTextBox);
      // 
      // attachmentsSplitContainer.Panel2
      // 
      this.attachmentsSplitContainer.Panel2.Controls.Add(this.attachmentsLinkLabel);
      this.attachmentsSplitContainer.Size = new System.Drawing.Size(668, 196);
      this.attachmentsSplitContainer.SplitterDistance = 468;
      this.attachmentsSplitContainer.TabIndex = 1;
      // 
      // detailTextBox
      // 
      this.detailTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.detailTextBox.Location = new System.Drawing.Point(0, 0);
      this.detailTextBox.Multiline = true;
      this.detailTextBox.Name = "detailTextBox";
      this.detailTextBox.ReadOnly = true;
      this.detailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.detailTextBox.Size = new System.Drawing.Size(468, 196);
      this.detailTextBox.TabIndex = 0;
      // 
      // attachmentsLinkLabel
      // 
      this.attachmentsLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.attachmentsLinkLabel.LinkColor = System.Drawing.SystemColors.HotTrack;
      this.attachmentsLinkLabel.Location = new System.Drawing.Point(0, 0);
      this.attachmentsLinkLabel.Name = "attachmentsLinkLabel";
      this.attachmentsLinkLabel.Size = new System.Drawing.Size(196, 196);
      this.attachmentsLinkLabel.TabIndex = 0;
      this.attachmentsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.attachmentsLinkLabel_LinkClicked);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(922, 24);
      this.menuStrip1.TabIndex = 3;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // connectToolStripMenuItem
      // 
      this.connectToolStripMenuItem.Image = global::MantisSharp.Browser.Properties.Resources.Connect;
      this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
      this.connectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.connectToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
      this.connectToolStripMenuItem.Text = "&Connect...";
      this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 6);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
      this.editToolStripMenuItem.Text = "&Edit";
      // 
      // refreshToolStripMenuItem
      // 
      this.refreshToolStripMenuItem.Image = global::MantisSharp.Browser.Properties.Resources.Refresh;
      this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
      this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
      this.refreshToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
      this.refreshToolStripMenuItem.Text = "&Refresh";
      this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
      // 
      // viewToolStripMenuItem
      // 
      this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userPropertiesToolStripMenuItem});
      this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
      this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.viewToolStripMenuItem.Text = "&View";
      // 
      // userPropertiesToolStripMenuItem
      // 
      this.userPropertiesToolStripMenuItem.Name = "userPropertiesToolStripMenuItem";
      this.userPropertiesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
      this.userPropertiesToolStripMenuItem.Text = "&User Properties...";
      this.userPropertiesToolStripMenuItem.Click += new System.EventHandler(this.userPropertiesToolStripMenuItem_Click);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "&Help";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
      this.aboutToolStripMenuItem.Text = "&About...";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripButton,
            this.toolStripSeparator1,
            this.refreshToolStripButton});
      this.toolStrip1.Location = new System.Drawing.Point(0, 24);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(922, 25);
      this.toolStrip1.TabIndex = 4;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // connectToolStripButton
      // 
      this.connectToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.connectToolStripButton.Image = global::MantisSharp.Browser.Properties.Resources.Connect;
      this.connectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.connectToolStripButton.Name = "connectToolStripButton";
      this.connectToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.connectToolStripButton.Text = "Connect";
      this.connectToolStripButton.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // refreshToolStripButton
      // 
      this.refreshToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.refreshToolStripButton.Image = global::MantisSharp.Browser.Properties.Resources.Refresh;
      this.refreshToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.refreshToolStripButton.Name = "refreshToolStripButton";
      this.refreshToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.refreshToolStripButton.Text = "Refresh";
      this.refreshToolStripButton.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusToolStripStatusLabel,
            this.userNameToolStripStatusLabel,
            this.accessLevelToolStripStatusLabel,
            this.versionToolStripStatusLabel});
      this.statusStrip1.Location = new System.Drawing.Point(0, 450);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(922, 22);
      this.statusStrip1.TabIndex = 5;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // statusToolStripStatusLabel
      // 
      this.statusToolStripStatusLabel.Name = "statusToolStripStatusLabel";
      this.statusToolStripStatusLabel.Size = new System.Drawing.Size(859, 17);
      this.statusToolStripStatusLabel.Spring = true;
      this.statusToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // userNameToolStripStatusLabel
      // 
      this.userNameToolStripStatusLabel.Image = global::MantisSharp.Browser.Properties.Resources.User;
      this.userNameToolStripStatusLabel.Name = "userNameToolStripStatusLabel";
      this.userNameToolStripStatusLabel.Size = new System.Drawing.Size(16, 17);
      // 
      // accessLevelToolStripStatusLabel
      // 
      this.accessLevelToolStripStatusLabel.Image = global::MantisSharp.Browser.Properties.Resources.AccessLevel;
      this.accessLevelToolStripStatusLabel.Name = "accessLevelToolStripStatusLabel";
      this.accessLevelToolStripStatusLabel.Size = new System.Drawing.Size(16, 17);
      // 
      // versionToolStripStatusLabel
      // 
      this.versionToolStripStatusLabel.Image = global::MantisSharp.Browser.Properties.Resources.Version;
      this.versionToolStripStatusLabel.Name = "versionToolStripStatusLabel";
      this.versionToolStripStatusLabel.Size = new System.Drawing.Size(16, 17);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(922, 472);
      this.Controls.Add(this.projectsSplitContainer);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.Text = "MantisBT Browser Sample";
      this.projectsSplitContainer.Panel1.ResumeLayout(false);
      this.projectsSplitContainer.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.projectsSplitContainer)).EndInit();
      this.projectsSplitContainer.ResumeLayout(false);
      this.issuesSplitContainer.Panel1.ResumeLayout(false);
      this.issuesSplitContainer.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.issuesSplitContainer)).EndInit();
      this.issuesSplitContainer.ResumeLayout(false);
      this.attachmentsSplitContainer.Panel1.ResumeLayout(false);
      this.attachmentsSplitContainer.Panel1.PerformLayout();
      this.attachmentsSplitContainer.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.attachmentsSplitContainer)).EndInit();
      this.attachmentsSplitContainer.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.SplitContainer projectsSplitContainer;
    private System.Windows.Forms.SplitContainer issuesSplitContainer;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ListBox projectsListBox;
    private System.Windows.Forms.ListView issuesListView;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ColumnHeader priorityColumnHeader;
    private System.Windows.Forms.ColumnHeader idColumnHeader;
    private System.Windows.Forms.ColumnHeader categoryColumnHeader;
    private System.Windows.Forms.ColumnHeader severityColumnHeader;
    private System.Windows.Forms.ColumnHeader statusColumnHeader;
    private System.Windows.Forms.ColumnHeader updatedColumnHeader;
    private System.Windows.Forms.ColumnHeader summaryColumnHeader;
    private System.Windows.Forms.TextBox detailTextBox;
    private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripStatusLabel statusToolStripStatusLabel;
    private System.Windows.Forms.ToolStripStatusLabel userNameToolStripStatusLabel;
    private System.Windows.Forms.ToolStripStatusLabel accessLevelToolStripStatusLabel;
    private System.Windows.Forms.SplitContainer attachmentsSplitContainer;
    private System.Windows.Forms.LinkLabel attachmentsLinkLabel;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    private System.Windows.Forms.ToolStripButton connectToolStripButton;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton refreshToolStripButton;
    private System.Windows.Forms.ToolStripStatusLabel versionToolStripStatusLabel;
    private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem userPropertiesToolStripMenuItem;
  }
}

