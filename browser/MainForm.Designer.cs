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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.projectsSplitContainer = new System.Windows.Forms.SplitContainer();
      this.projectsListBox = new System.Windows.Forms.ListBox();
      this.projectContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.projectPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.issuesSplitContainer = new System.Windows.Forms.SplitContainer();
      this.issuesListView = new System.Windows.Forms.ListView();
      this.idColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.priorityColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.categoryColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.severityColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.statusColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.updatedColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.summaryColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.issueContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.deleteIssueContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
      this.issuePropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.imageList = new System.Windows.Forms.ImageList(this.components);
      this.webBrowser = new System.Windows.Forms.WebBrowser();
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.userPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
      this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.issueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.createIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.deleteIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStrip = new System.Windows.Forms.ToolStrip();
      this.connectToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.configurationsToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.createIssueToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.deleteIssueToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.statusStrip = new System.Windows.Forms.StatusStrip();
      this.statusToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.userNameToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.accessLevelToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.versionToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      ((System.ComponentModel.ISupportInitialize)(this.projectsSplitContainer)).BeginInit();
      this.projectsSplitContainer.Panel1.SuspendLayout();
      this.projectsSplitContainer.Panel2.SuspendLayout();
      this.projectsSplitContainer.SuspendLayout();
      this.projectContextMenuStrip.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.issuesSplitContainer)).BeginInit();
      this.issuesSplitContainer.Panel1.SuspendLayout();
      this.issuesSplitContainer.Panel2.SuspendLayout();
      this.issuesSplitContainer.SuspendLayout();
      this.issueContextMenuStrip.SuspendLayout();
      this.menuStrip.SuspendLayout();
      this.toolStrip.SuspendLayout();
      this.statusStrip.SuspendLayout();
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
      this.projectsListBox.ContextMenuStrip = this.projectContextMenuStrip;
      this.projectsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.projectsListBox.IntegralHeight = false;
      this.projectsListBox.Location = new System.Drawing.Point(0, 0);
      this.projectsListBox.Name = "projectsListBox";
      this.projectsListBox.Size = new System.Drawing.Size(250, 401);
      this.projectsListBox.TabIndex = 0;
      this.projectsListBox.SelectedIndexChanged += new System.EventHandler(this.projectsListBox_SelectedIndexChanged);
      // 
      // projectContextMenuStrip
      // 
      this.projectContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectPropertiesToolStripMenuItem});
      this.projectContextMenuStrip.Name = "projectContextMenuStrip";
      this.projectContextMenuStrip.Size = new System.Drawing.Size(137, 26);
      // 
      // projectPropertiesToolStripMenuItem
      // 
      this.projectPropertiesToolStripMenuItem.Image = global::MantisSharp.Browser.Properties.Resources.Properties;
      this.projectPropertiesToolStripMenuItem.Name = "projectPropertiesToolStripMenuItem";
      this.projectPropertiesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
      this.projectPropertiesToolStripMenuItem.Text = "Propert&ies...";
      this.projectPropertiesToolStripMenuItem.Click += new System.EventHandler(this.projectPropertiesToolStripMenuItem_Click);
      // 
      // issuesSplitContainer
      // 
      this.issuesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.issuesSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
      this.issuesSplitContainer.Location = new System.Drawing.Point(0, 0);
      this.issuesSplitContainer.Name = "issuesSplitContainer";
      // 
      // issuesSplitContainer.Panel1
      // 
      this.issuesSplitContainer.Panel1.Controls.Add(this.issuesListView);
      // 
      // issuesSplitContainer.Panel2
      // 
      this.issuesSplitContainer.Panel2.Controls.Add(this.webBrowser);
      this.issuesSplitContainer.Size = new System.Drawing.Size(668, 401);
      this.issuesSplitContainer.SplitterDistance = 201;
      this.issuesSplitContainer.TabIndex = 0;
      // 
      // issuesListView
      // 
      this.issuesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumnHeader,
            this.priorityColumnHeader,
            this.categoryColumnHeader,
            this.severityColumnHeader,
            this.statusColumnHeader,
            this.updatedColumnHeader,
            this.summaryColumnHeader});
      this.issuesListView.ContextMenuStrip = this.issueContextMenuStrip;
      this.issuesListView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.issuesListView.FullRowSelect = true;
      this.issuesListView.HideSelection = false;
      this.issuesListView.Location = new System.Drawing.Point(0, 0);
      this.issuesListView.Name = "issuesListView";
      this.issuesListView.Size = new System.Drawing.Size(201, 401);
      this.issuesListView.SmallImageList = this.imageList;
      this.issuesListView.TabIndex = 0;
      this.issuesListView.UseCompatibleStateImageBehavior = false;
      this.issuesListView.View = System.Windows.Forms.View.Details;
      this.issuesListView.SelectedIndexChanged += new System.EventHandler(this.issuesListView_SelectedIndexChanged);
      // 
      // idColumnHeader
      // 
      this.idColumnHeader.Text = "Id";
      this.idColumnHeader.Width = 80;
      // 
      // priorityColumnHeader
      // 
      this.priorityColumnHeader.Text = "Priority";
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
      // issueContextMenuStrip
      // 
      this.issueContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteIssueContextToolStripMenuItem,
            this.toolStripMenuItem3,
            this.issuePropertiesToolStripMenuItem});
      this.issueContextMenuStrip.Name = "issueContextMenuStrip";
      this.issueContextMenuStrip.Size = new System.Drawing.Size(137, 54);
      // 
      // deleteIssueContextToolStripMenuItem
      // 
      this.deleteIssueContextToolStripMenuItem.Image = global::MantisSharp.Browser.Properties.Resources.DeleteIssue;
      this.deleteIssueContextToolStripMenuItem.Name = "deleteIssueContextToolStripMenuItem";
      this.deleteIssueContextToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
      this.deleteIssueContextToolStripMenuItem.Text = "&Delete...";
      this.deleteIssueContextToolStripMenuItem.Click += new System.EventHandler(this.deleteIssueToolStripMenuItem_Click);
      // 
      // toolStripMenuItem3
      // 
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      this.toolStripMenuItem3.Size = new System.Drawing.Size(133, 6);
      // 
      // issuePropertiesToolStripMenuItem
      // 
      this.issuePropertiesToolStripMenuItem.Image = global::MantisSharp.Browser.Properties.Resources.Properties;
      this.issuePropertiesToolStripMenuItem.Name = "issuePropertiesToolStripMenuItem";
      this.issuePropertiesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
      this.issuePropertiesToolStripMenuItem.Text = "Propert&ies...";
      this.issuePropertiesToolStripMenuItem.Click += new System.EventHandler(this.issuePropertiesToolStripMenuItem_Click);
      // 
      // imageList
      // 
      this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
      this.imageList.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList.Images.SetKeyName(0, "issue");
      this.imageList.Images.SetKeyName(1, "issuefiles");
      // 
      // webBrowser
      // 
      this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
      this.webBrowser.Location = new System.Drawing.Point(0, 0);
      this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
      this.webBrowser.Name = "webBrowser";
      this.webBrowser.ScriptErrorsSuppressed = true;
      this.webBrowser.Size = new System.Drawing.Size(463, 401);
      this.webBrowser.TabIndex = 0;
      // 
      // menuStrip
      // 
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.issueToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Size = new System.Drawing.Size(922, 24);
      this.menuStrip.TabIndex = 0;
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
            this.userPropertiesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.configurationToolStripMenuItem});
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
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(159, 6);
      // 
      // configurationToolStripMenuItem
      // 
      this.configurationToolStripMenuItem.Image = global::MantisSharp.Browser.Properties.Resources.Config;
      this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
      this.configurationToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
      this.configurationToolStripMenuItem.Text = "&Configuration...";
      this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
      // 
      // issueToolStripMenuItem
      // 
      this.issueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createIssueToolStripMenuItem,
            this.deleteIssueToolStripMenuItem});
      this.issueToolStripMenuItem.Name = "issueToolStripMenuItem";
      this.issueToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
      this.issueToolStripMenuItem.Text = "&Issue";
      // 
      // createIssueToolStripMenuItem
      // 
      this.createIssueToolStripMenuItem.Image = global::MantisSharp.Browser.Properties.Resources.CreateIssue;
      this.createIssueToolStripMenuItem.Name = "createIssueToolStripMenuItem";
      this.createIssueToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
      this.createIssueToolStripMenuItem.Text = "&Create...";
      this.createIssueToolStripMenuItem.Click += new System.EventHandler(this.createIssueToolStripMenuItem_Click);
      // 
      // deleteIssueToolStripMenuItem
      // 
      this.deleteIssueToolStripMenuItem.Image = global::MantisSharp.Browser.Properties.Resources.DeleteIssue;
      this.deleteIssueToolStripMenuItem.Name = "deleteIssueToolStripMenuItem";
      this.deleteIssueToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
      this.deleteIssueToolStripMenuItem.Text = "&Delete...";
      this.deleteIssueToolStripMenuItem.Click += new System.EventHandler(this.deleteIssueToolStripMenuItem_Click);
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
      // toolStrip
      // 
      this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripButton,
            this.toolStripSeparator1,
            this.refreshToolStripButton,
            this.toolStripSeparator3,
            this.configurationsToolStripButton,
            this.toolStripSeparator2,
            this.createIssueToolStripButton,
            this.deleteIssueToolStripButton});
      this.toolStrip.Location = new System.Drawing.Point(0, 24);
      this.toolStrip.Name = "toolStrip";
      this.toolStrip.Size = new System.Drawing.Size(922, 25);
      this.toolStrip.TabIndex = 1;
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
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
      // 
      // configurationsToolStripButton
      // 
      this.configurationsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.configurationsToolStripButton.Image = global::MantisSharp.Browser.Properties.Resources.Config;
      this.configurationsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.configurationsToolStripButton.Name = "configurationsToolStripButton";
      this.configurationsToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.configurationsToolStripButton.Text = "List Configurations";
      this.configurationsToolStripButton.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // createIssueToolStripButton
      // 
      this.createIssueToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.createIssueToolStripButton.Image = global::MantisSharp.Browser.Properties.Resources.CreateIssue;
      this.createIssueToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.createIssueToolStripButton.Name = "createIssueToolStripButton";
      this.createIssueToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.createIssueToolStripButton.Text = "Create Issue";
      this.createIssueToolStripButton.Click += new System.EventHandler(this.createIssueToolStripMenuItem_Click);
      // 
      // deleteIssueToolStripButton
      // 
      this.deleteIssueToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.deleteIssueToolStripButton.Image = global::MantisSharp.Browser.Properties.Resources.DeleteIssue;
      this.deleteIssueToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.deleteIssueToolStripButton.Name = "deleteIssueToolStripButton";
      this.deleteIssueToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.deleteIssueToolStripButton.Text = "Delete Issue";
      this.deleteIssueToolStripButton.Click += new System.EventHandler(this.deleteIssueToolStripMenuItem_Click);
      // 
      // statusStrip
      // 
      this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusToolStripStatusLabel,
            this.userNameToolStripStatusLabel,
            this.accessLevelToolStripStatusLabel,
            this.versionToolStripStatusLabel});
      this.statusStrip.Location = new System.Drawing.Point(0, 450);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.Size = new System.Drawing.Size(922, 22);
      this.statusStrip.TabIndex = 3;
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
      this.ClientSize = new System.Drawing.Size(922, 472);
      this.Controls.Add(this.projectsSplitContainer);
      this.Controls.Add(this.statusStrip);
      this.Controls.Add(this.toolStrip);
      this.Controls.Add(this.menuStrip);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
      this.MainMenuStrip = this.menuStrip;
      this.MaximizeBox = true;
      this.MinimizeBox = true;
      this.Name = "MainForm";
      this.ShowIcon = true;
      this.ShowInTaskbar = true;
      this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
      this.Text = "MantisSharp Browser Sample";
      this.projectsSplitContainer.Panel1.ResumeLayout(false);
      this.projectsSplitContainer.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.projectsSplitContainer)).EndInit();
      this.projectsSplitContainer.ResumeLayout(false);
      this.projectContextMenuStrip.ResumeLayout(false);
      this.issuesSplitContainer.Panel1.ResumeLayout(false);
      this.issuesSplitContainer.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.issuesSplitContainer)).EndInit();
      this.issuesSplitContainer.ResumeLayout(false);
      this.issueContextMenuStrip.ResumeLayout(false);
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.toolStrip.ResumeLayout(false);
      this.toolStrip.PerformLayout();
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.SplitContainer projectsSplitContainer;
    private System.Windows.Forms.SplitContainer issuesSplitContainer;
    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStrip toolStrip;
    private System.Windows.Forms.StatusStrip statusStrip;
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
    private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripStatusLabel statusToolStripStatusLabel;
    private System.Windows.Forms.ToolStripStatusLabel userNameToolStripStatusLabel;
    private System.Windows.Forms.ToolStripStatusLabel accessLevelToolStripStatusLabel;
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
    private System.Windows.Forms.ContextMenuStrip projectContextMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem projectPropertiesToolStripMenuItem;
    private System.Windows.Forms.ContextMenuStrip issueContextMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem issuePropertiesToolStripMenuItem;
    private System.Windows.Forms.WebBrowser webBrowser;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
    private System.Windows.Forms.ToolStripButton configurationsToolStripButton;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem issueToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem deleteIssueToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem createIssueToolStripMenuItem;
    private System.Windows.Forms.ImageList imageList;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripButton createIssueToolStripButton;
    private System.Windows.Forms.ToolStripButton deleteIssueToolStripButton;
    private System.Windows.Forms.ToolStripMenuItem deleteIssueContextToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
  }
}

