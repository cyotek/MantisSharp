using System;
using System.Windows.Forms;

namespace MantisSharp.Browser
{
  internal partial class ListConfigurationValuesDialog : BaseForm
  {
    #region Constants

    private readonly MantisClient _client;

    #endregion

    #region Constructors

    public ListConfigurationValuesDialog()
    {
      this.InitializeComponent();
    }

    public ListConfigurationValuesDialog(MantisClient client)
      : this()
    {
      _client = client;
    }

    #endregion

    #region Methods

    private void closeButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void FillResults(string[] results)
    {
      ListBox.ObjectCollection items;

      items = resultsListBox.Items;

      if (results != null && results.Length != 0)
      {
        resultsListBox.BeginUpdate();

        items.Clear();

        for (int i = 0; i < results.Length; i++)
        {
          items.Add(results[i]);
        }

        resultsListBox.EndUpdate();
      }
      else
      {
        items.Clear();
      }
    }

    private void getConfigurationButton_Click(object sender, EventArgs e)
    {
      string option;

      option = optionComboBox.Text;

      if (string.IsNullOrEmpty(option))
      {
        MessageBox.Show("Please enter or select the configuration set to load.");
      }
      else
      {
        string[] results;

        results = _client.GetConfigValues(option);

        this.FillResults(results);
      }
    }

    #endregion
  }
}
