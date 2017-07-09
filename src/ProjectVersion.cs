using System;
using PetaJson;

namespace MantisSharp
{
  public class ProjectVersion : MantisReference
  {
    #region Fields

    private string _description;

    private bool _obsolete;

    private bool _released;

    private DateTime _timestamp;

    #endregion

    #region Properties

    [Json("description")]
    public string Description
    {
      get { return _description; }
      internal set { _description = value; }
    }

    [Json("obsolete")]
    public bool Obsolete
    {
      get { return _obsolete; }
      internal set { _obsolete = value; }
    }

    [Json("released")]
    public bool Released
    {
      get { return _released; }
      internal set { _released = value; }
    }

    [Json("timestamp")]
    public DateTime Timestamp
    {
      get { return _timestamp; }
      internal set { _timestamp = value; }
    }

    #endregion
  }
}
