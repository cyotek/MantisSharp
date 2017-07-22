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
      System.Windows.Forms.GroupBox settingsGroupBox;
      System.Windows.Forms.Label label5;
      System.Windows.Forms.Label label4;
      System.Windows.Forms.Label label3;
      System.Windows.Forms.Label label2;
      System.Windows.Forms.Label label1;
      System.Windows.Forms.GroupBox resultsGroupBox;
      System.Windows.Forms.StatusStrip statusStrip;
      this.getConfigurationButton = new System.Windows.Forms.Button();
      this.userNameTextBox = new System.Windows.Forms.TextBox();
      this.projectTextBox = new System.Windows.Forms.TextBox();
      this.optionComboBox = new System.Windows.Forms.ComboBox();
      this.resultsListBox = new System.Windows.Forms.ListBox();
      this.closeButton = new System.Windows.Forms.Button();
      this.statusToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      settingsGroupBox = new System.Windows.Forms.GroupBox();
      label5 = new System.Windows.Forms.Label();
      label4 = new System.Windows.Forms.Label();
      label3 = new System.Windows.Forms.Label();
      label2 = new System.Windows.Forms.Label();
      label1 = new System.Windows.Forms.Label();
      resultsGroupBox = new System.Windows.Forms.GroupBox();
      statusStrip = new System.Windows.Forms.StatusStrip();
      settingsGroupBox.SuspendLayout();
      resultsGroupBox.SuspendLayout();
      statusStrip.SuspendLayout();
      this.SuspendLayout();
      //
      // settingsGroupBox
      //
      settingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      settingsGroupBox.Controls.Add(this.getConfigurationButton);
      settingsGroupBox.Controls.Add(label5);
      settingsGroupBox.Controls.Add(label4);
      settingsGroupBox.Controls.Add(this.userNameTextBox);
      settingsGroupBox.Controls.Add(label3);
      settingsGroupBox.Controls.Add(this.projectTextBox);
      settingsGroupBox.Controls.Add(label2);
      settingsGroupBox.Controls.Add(this.optionComboBox);
      settingsGroupBox.Controls.Add(label1);
      settingsGroupBox.Location = new System.Drawing.Point(12, 12);
      settingsGroupBox.Name = "settingsGroupBox";
      settingsGroupBox.Size = new System.Drawing.Size(483, 149);
      settingsGroupBox.TabIndex = 0;
      settingsGroupBox.TabStop = false;
      settingsGroupBox.Text = "Settings";
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
      label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      label5.ForeColor = System.Drawing.SystemColors.GrayText;
      label5.Location = new System.Drawing.Point(207, 75);
      label5.Name = "label5";
      label5.Size = new System.Drawing.Size(270, 32);
      label5.TabIndex = 7;
      label5.Text = "Leave blank for current user, 0 for all users. Specifying a user name requires ad" +
    "ministritive rights";
      //
      // label4
      //
      label4.AutoSize = true;
      label4.ForeColor = System.Drawing.SystemColors.GrayText;
      label4.Location = new System.Drawing.Point(207, 49);
      label4.Name = "label4";
      label4.Size = new System.Drawing.Size(134, 13);
      label4.TabIndex = 4;
      label4.Text = "Leave blank for all projects";
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
      label3.AutoSize = true;
      label3.Location = new System.Drawing.Point(6, 77);
      label3.Name = "label3";
      label3.Size = new System.Drawing.Size(61, 13);
      label3.TabIndex = 5;
      label3.Text = "&User name:";
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
      label2.AutoSize = true;
      label2.Location = new System.Drawing.Point(6, 49);
      label2.Name = "label2";
      label2.Size = new System.Drawing.Size(43, 13);
      label2.TabIndex = 2;
      label2.Text = "&Project:";
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
      label1.AutoSize = true;
      label1.Location = new System.Drawing.Point(6, 22);
      label1.Name = "label1";
      label1.Size = new System.Drawing.Size(89, 13);
      label1.TabIndex = 0;
      label1.Text = "Configuration set:";
      //
      // resultsGroupBox
      //
      resultsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      resultsGroupBox.Controls.Add(this.resultsListBox);
      resultsGroupBox.Location = new System.Drawing.Point(12, 167);
      resultsGroupBox.Name = "resultsGroupBox";
      resultsGroupBox.Size = new System.Drawing.Size(483, 189);
      resultsGroupBox.TabIndex = 1;
      resultsGroupBox.TabStop = false;
      resultsGroupBox.Text = "Results";
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
      this.resultsListBox.Size = new System.Drawing.Size(471, 164);
      this.resultsListBox.TabIndex = 0;
      //
      // closeButton
      //
      this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.closeButton.Location = new System.Drawing.Point(420, 362);
      this.closeButton.Name = "closeButton";
      this.closeButton.Size = new System.Drawing.Size(75, 23);
      this.closeButton.TabIndex = 2;
      this.closeButton.Text = "Close";
      this.closeButton.UseVisualStyleBackColor = true;
      this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
      //
      // statusStrip
      //
      statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusToolStripStatusLabel});
      statusStrip.Location = new System.Drawing.Point(0, 388);
      statusStrip.Name = "statusStrip";
      statusStrip.Size = new System.Drawing.Size(507, 22);
      statusStrip.SizingGrip = false;
      statusStrip.TabIndex = 6;
      //
      // statusToolStripStatusLabel
      //
      this.statusToolStripStatusLabel.Name = "statusToolStripStatusLabel";
      this.statusToolStripStatusLabel.Size = new System.Drawing.Size(461, 17);
      this.statusToolStripStatusLabel.Spring = true;
      this.statusToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      //
      // ListConfigurationValuesDialog
      //
      this.AcceptButton = this.getConfigurationButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.CancelButton = this.closeButton;
      this.ClientSize = new System.Drawing.Size(507, 410);
      this.Controls.Add(statusStrip);
      this.Controls.Add(this.closeButton);
      this.Controls.Add(resultsGroupBox);
      this.Controls.Add(settingsGroupBox);
      this.Name = "ListConfigurationValuesDialog";
      this.Text = "List Configuration Values";
      settingsGroupBox.ResumeLayout(false);
      settingsGroupBox.PerformLayout();
      resultsGroupBox.ResumeLayout(false);
      statusStrip.ResumeLayout(false);
      statusStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button closeButton;
    private System.Windows.Forms.TextBox userNameTextBox;
    private System.Windows.Forms.TextBox projectTextBox;
    private System.Windows.Forms.ComboBox optionComboBox;
    private System.Windows.Forms.Button getConfigurationButton;
    private System.Windows.Forms.ListBox resultsListBox;
    private System.Windows.Forms.ToolStripStatusLabel statusToolStripStatusLabel;
  }
}
