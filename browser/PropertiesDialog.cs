using System;

// Copyright (c) 2017 Cyotek Ltd.
// http://mantissharp.net/
// Licensed under the MIT License. See LICENSE.txt for the full text.

// If you use this control in your applications, attribution, donations or contributions are welcome.

namespace MantisSharp.Browser
{
  internal sealed partial class PropertiesDialog : BaseForm
  {
    #region Constructors

    public PropertiesDialog()
    {
      this.InitializeComponent();
    }

    public PropertiesDialog(object item)
      : this()
    {
      propertyGrid.SelectedObject = item;
    }

    #endregion

    #region Static Methods

    public static void ShowDialog(object item)
    {
      using (PropertiesDialog dialog = new PropertiesDialog(item))
      {
        dialog.ShowDialog();
      }
    }

    #endregion

    #region Methods

    protected override void OnLoad(EventArgs e)
    {
      this.MinimumSize = this.Size;

      base.OnLoad(e);
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    #endregion
  }
}
