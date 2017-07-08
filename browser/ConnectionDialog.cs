using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MantisSharp.Browser
{
  internal sealed partial class ConnectionDialog : BaseForm
  {
    #region Fields

    private string _apiKey;

    private string _baseUri;

    #endregion

    #region Constructors

    public ConnectionDialog()
    {
      this.InitializeComponent();
    }

    #endregion

    #region Properties

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string ApiKey
    {
      get { return _apiKey; }
      set
      {
        _apiKey = value;

        apiKeyTextBox.Text = value;
      }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string BaseUri
    {
      get { return _baseUri; }
      set
      {
        _baseUri = value;

        baseUriTextBox.Text = value;
      }
    }

    #endregion

    #region Methods

    private void cancelButton_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }

    private void okButton_Click(object sender, EventArgs e)
    {
      if (this.ValidateFields())
      {
        _baseUri = baseUriTextBox.Text;
        _apiKey = apiKeyTextBox.Text;

        this.DialogResult = DialogResult.OK;
        this.Close();
      }
      else
      {
        this.DialogResult = DialogResult.None;
      }
    }

    private void testConnectionLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      if (this.ValidateFields())
      {
        try
        {
          MantisClient client;
          User user;

          this.UseWaitCursor = true;

          client = new MantisClient(baseUriTextBox.Text, apiKeyTextBox.Text);

          user = client.GetCurrentUser();

          MessageBox.Show("Connection attempt successful. Authorized as user '" + user.Name + "'.", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
          MessageBox.Show("Connection test failed. " + ex.GetBaseException().Message, "Test Connection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        finally
        {
          this.UseWaitCursor = false;
        }
      }
    }

    private bool ValidateFields()
    {
      bool result;

      result = false;

      if (string.IsNullOrEmpty(baseUriTextBox.Text))
      {
        MessageBox.Show("Please enter the base MantisBT URI.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else if (string.IsNullOrEmpty(apiKeyTextBox.Text))
      {
        MessageBox.Show("Please enter the API key used to authenticate.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        result = true;
      }

      return result;
    }

    #endregion
  }
}
