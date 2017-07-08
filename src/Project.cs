using System.ComponentModel;

namespace MantisSharp
{
  public class Project
  {
    #region Fields

    private string _description;

    private bool _enabled;

    private int _id;

    private string _name;

    #endregion

    #region Properties

    public string Description
    {
      get { return _description; }
      internal set { _description = value; }
    }

    public bool Enabled
    {
      get { return _enabled; }
      internal set { _enabled = value; }
    }

    [Browsable(false)]
    public int Id
    {
      get { return _id; }
      internal set { _id = value; }
    }

    public string Name
    {
      get { return _name; }
      internal set { _name = value; }
    }

    #endregion

    #region Methods

    public override string ToString()
    {
      return _name;
    }

    #endregion
  }
}
