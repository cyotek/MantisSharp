using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MantisSharp.Browser
{
  // Copyright (c) 2017 Cyotek Ltd.
  // http://mantissharp.net/
  // Licensed under the MIT License. See LICENSE.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  internal partial class BaseForm : Form
  {
    #region Constructors

    public BaseForm()
    {
      this.AutoScaleMode = AutoScaleMode.Font;
      this.MinimizeBox = false;
      this.MaximizeBox = false;
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
    }

    #endregion

    #region Properties

    [DefaultValue(typeof(AutoScaleMode), "Font")]

    public new AutoScaleMode AutoScaleMode
    {
      get { return base.AutoScaleMode; }
      set { base.AutoScaleMode = value; }
    }

    [DefaultValue(typeof(FormBorderStyle), "FixedDialog")]

    public new FormBorderStyle FormBorderStyle
    {
      get { return base.FormBorderStyle; }
      set { base.FormBorderStyle = value; }
    }

    [DefaultValue(false)]

    public new bool MaximizeBox
    {
      get { return base.MaximizeBox; }
      set { base.MaximizeBox = value; }
    }

    [DefaultValue(false)]

    public new bool MinimizeBox
    {
      get { return base.MinimizeBox; }
      set { base.MinimizeBox = value; }
    }

    [DefaultValue(false)]

    public new bool ShowIcon
    {
      get { return base.ShowIcon; }
      set { base.ShowIcon = value; }
    }

    [DefaultValue(false)]

    public new bool ShowInTaskbar
    {
      get { return base.ShowInTaskbar; }
      set { base.ShowInTaskbar = value; }
    }

    [DefaultValue(typeof(FormStartPosition), "CenterParent")]

    public new FormStartPosition StartPosition
    {
      get { return base.StartPosition; }
      set { base.StartPosition = value; }
    }

    #endregion

    #region Methods

    protected override void OnLoad(EventArgs e)
    {
      if (!this.DesignMode)
      {
        this.Font = SystemFonts.MessageBoxFont;
      }

      base.OnLoad(e);
    }

    protected override void OnShown(EventArgs e)
    {
      base.OnShown(e);

      Cursor.Current = Cursors.Default;
    }

    #endregion
  }
}
