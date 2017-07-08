namespace MantisSharp.Browser
{
  partial class ConnectionDialog
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionDialog));
      this.label1 = new System.Windows.Forms.Label();
      this.baseUriTextBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.apiKeyTextBox = new System.Windows.Forms.TextBox();
      this.okButton = new System.Windows.Forms.Button();
      this.cancelButton = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.testConnectionLinkLabel = new System.Windows.Forms.LinkLabel();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 25);
      this.label1.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(56, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Base &URI:";
      // 
      // baseUriTextBox
      // 
      this.baseUriTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.baseUriTextBox.Location = new System.Drawing.Point(6, 41);
      this.baseUriTextBox.Name = "baseUriTextBox";
      this.baseUriTextBox.Size = new System.Drawing.Size(323, 20);
      this.baseUriTextBox.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 116);
      this.label2.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(47, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "&API key:";
      // 
      // apiKeyTextBox
      // 
      this.apiKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.apiKeyTextBox.Location = new System.Drawing.Point(6, 132);
      this.apiKeyTextBox.Name = "apiKeyTextBox";
      this.apiKeyTextBox.Size = new System.Drawing.Size(323, 20);
      this.apiKeyTextBox.TabIndex = 4;
      // 
      // okButton
      // 
      this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.okButton.Location = new System.Drawing.Point(191, 189);
      this.okButton.Name = "okButton";
      this.okButton.Size = new System.Drawing.Size(75, 23);
      this.okButton.TabIndex = 2;
      this.okButton.Text = "OK";
      this.okButton.UseVisualStyleBackColor = true;
      this.okButton.Click += new System.EventHandler(this.okButton_Click);
      // 
      // cancelButton
      // 
      this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cancelButton.Location = new System.Drawing.Point(272, 189);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(75, 23);
      this.cancelButton.TabIndex = 3;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
      this.label3.Location = new System.Drawing.Point(3, 64);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(326, 43);
      this.label3.TabIndex = 2;
      this.label3.Text = resources.GetString("label3.Text");
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.baseUriTextBox);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.apiKeyTextBox);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(335, 171);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Connection Settings";
      // 
      // testConnectionLinkLabel
      // 
      this.testConnectionLinkLabel.AutoSize = true;
      this.testConnectionLinkLabel.LinkColor = System.Drawing.SystemColors.HotTrack;
      this.testConnectionLinkLabel.Location = new System.Drawing.Point(9, 194);
      this.testConnectionLinkLabel.Name = "testConnectionLinkLabel";
      this.testConnectionLinkLabel.Size = new System.Drawing.Size(84, 13);
      this.testConnectionLinkLabel.TabIndex = 1;
      this.testConnectionLinkLabel.TabStop = true;
      this.testConnectionLinkLabel.Text = "Test connection";
      this.testConnectionLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.testConnectionLinkLabel_LinkClicked);
      // 
      // ConnectionDialog
      // 
      this.AcceptButton = this.okButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.cancelButton;
      this.ClientSize = new System.Drawing.Size(359, 224);
      this.Controls.Add(this.testConnectionLinkLabel);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.cancelButton);
      this.Controls.Add(this.okButton);
      this.Name = "ConnectionDialog";
      this.Text = "Connect to Mantis";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox baseUriTextBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox apiKeyTextBox;
    private System.Windows.Forms.Button okButton;
    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.LinkLabel testConnectionLinkLabel;
  }
}