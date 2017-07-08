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
      string uri;
      string key;

      this.DialogResult = DialogResult.None;

      uri = baseUriTextBox.Text;
      key = apiKeyTextBox.Text;

      if (string.IsNullOrEmpty(uri))
      {
        MessageBox.Show("Please enter the base MantisBT URI.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else if (string.IsNullOrEmpty(key))
      {
        MessageBox.Show("Please enter the API key used to authenticate.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        _baseUri = uri;
        _apiKey = key;

        this.DialogResult = DialogResult.OK;
        this.Close();
      }
    }

    #endregion
  }
}
