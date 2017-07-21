namespace MantisSharp.Browser
{
  partial class ListConfigurationValuesDialog
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
      this.settingsGroupBox = new System.Windows.Forms.GroupBox();
      this.getConfigurationButton = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.userNameTextBox = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.projectTextBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.optionComboBox = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.resultsGroupBox = new System.Windows.Forms.GroupBox();
      this.resultsListBox = new System.Windows.Forms.ListBox();
      this.closeButton = new System.Windows.Forms.Button();
      this.settingsGroupBox.SuspendLayout();
      this.resultsGroupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // settingsGroupBox
      // 
      this.settingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.settingsGroupBox.Controls.Add(this.getConfigurationButton);
      this.settingsGroupBox.Controls.Add(this.label5);
      this.settingsGroupBox.Controls.Add(this.label4);
      this.settingsGroupBox.Controls.Add(this.userNameTextBox);
      this.settingsGroupBox.Controls.Add(this.label3);
      this.settingsGroupBox.Controls.Add(this.projectTextBox);
      this.settingsGroupBox.Controls.Add(this.label2);
      this.settingsGroupBox.Controls.Add(this.optionComboBox);
      this.settingsGroupBox.Controls.Add(this.label1);
      this.settingsGroupBox.Location = new System.Drawing.Point(12, 12);
      this.settingsGroupBox.Name = "settingsGroupBox";
      this.settingsGroupBox.Size = new System.Drawing.Size(483, 149);
      this.settingsGroupBox.TabIndex = 0;
      this.settingsGroupBox.TabStop = false;
      this.settingsGroupBox.Text = "Settings";
      // 
      // getConfigurationButton
      // 
      this.getConfigurationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.getConfigurationButton.Location = new System.Drawing.Point(402, 120);
      this.getConfigurationButton.Name = "getConfigurationButton";
      this.getConfigurationButton.Size = new System.Drawing.Size(75, 23);
      this.getConfigurationButton.TabIndex = 8;
      this.getConfigurationButton.Text = "&List";
      this.getConfigurationButton.UseVisualStyleBackColor = true;
      this.getConfigurationButton.Click += new System.EventHandler(this.getConfigurationButton_Click);
      // 
      // label5
      // 
      this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
      this.label5.Location = new System.Drawing.Point(207, 75);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(270, 32);
      this.label5.TabIndex = 7;
      this.label5.Text = "Leave blank for current user, 0 for all users. Specifying a user name requires ad" +
    "ministritive rights";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
      this.label4.Location = new System.Drawing.Point(207, 49);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(134, 13);
      this.label4.TabIndex = 4;
      this.label4.Text = "Leave blank for all projects";
      // 
      // userNameTextBox
      // 
      this.userNameTextBox.Location = new System.Drawing.Point(101, 72);
      this.userNameTextBox.Name = "userNameTextBox";
      this.userNameTextBox.Size = new System.Drawing.Size(100, 20);
      this.userNameTextBox.TabIndex = 6;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 77);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(61, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "&User name:";
      // 
      // projectTextBox
      // 
      this.projectTextBox.Location = new System.Drawing.Point(101, 46);
      this.projectTextBox.Name = "projectTextBox";
      this.projectTextBox.Size = new System.Drawing.Size(100, 20);
      this.projectTextBox.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 49);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(43, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "&Project:";
      // 
      // optionComboBox
      // 
      this.optionComboBox.FormattingEnabled = true;
      this.optionComboBox.Items.AddRange(new object[] {
            "csv_columns",
            "excel_columns",
            "print_issues_page_columns",
            "view_issues_page_columns"});
      this.optionComboBox.Location = new System.Drawing.Point(101, 19);
      this.optionComboBox.Name = "optionComboBox";
      this.optionComboBox.Size = new System.Drawing.Size(194, 21);
      this.optionComboBox.TabIndex = 1;
      this.optionComboBox.Text = "view_issues_page_columns";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(89, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Configuration set:";
      // 
      // resultsGroupBox
      // 
      this.resultsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.resultsGroupBox.Controls.Add(this.resultsListBox);
      this.resultsGroupBox.Location = new System.Drawing.Point(12, 167);
      this.resultsGroupBox.Name = "resultsGroupBox";
      this.resultsGroupBox.Size = new System.Drawing.Size(483, 202);
      this.resultsGroupBox.TabIndex = 1;
      this.resultsGroupBox.TabStop = false;
      this.resultsGroupBox.Text = "Results";
      // 
      // resultsListBox
      // 
      this.resultsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.resultsListBox.FormattingEnabled = true;
      this.resultsListBox.IntegralHeight = false;
      this.resultsListBox.Location = new System.Drawing.Point(6, 19);
      this.resultsListBox.Name = "resultsListBox";
      this.resultsListBox.Size = new System.Drawing.Size(471, 177);
      this.resultsListBox.TabIndex = 0;
      // 
      // closeButton
      // 
      this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.closeButton.Location = new System.Drawing.Point(420, 375);
      this.closeButton.Name = "closeButton";
      this.closeButton.Size = new System.Drawing.Size(75, 23);
      this.closeButton.TabIndex = 2;
      this.closeButton.Text = "Close";
      this.closeButton.UseVisualStyleBackColor = true;
      this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
      // 
      // ListConfigurationValuesDialog
      // 
      this.AcceptButton = this.getConfigurationButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.CancelButton = this.closeButton;
      this.ClientSize = new System.Drawing.Size(507, 410);
      this.Controls.Add(this.closeButton);
      this.Controls.Add(this.resultsGroupBox);
      this.Controls.Add(this.settingsGroupBox);
      this.Name = "ListConfigurationValuesDialog";
      this.Text = "List Configuration Values";
      this.settingsGroupBox.ResumeLayout(false);
      this.settingsGroupBox.PerformLayout();
      this.resultsGroupBox.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox settingsGroupBox;
    private System.Windows.Forms.GroupBox resultsGroupBox;
    private System.Windows.Forms.Button closeButton;
    private System.Windows.Forms.TextBox userNameTextBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox projectTextBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox optionComboBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button getConfigurationButton;
    private System.Windows.Forms.ListBox resultsListBox;
  }
}