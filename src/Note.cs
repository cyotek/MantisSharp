using System;
using PetaJson;

namespace MantisSharp
{
  public class Note
  {
    #region Fields

    private DateTime _created;

    private int _id;

    private DateTime _lastModified;

    private User _reporter;

    private string _text;

    private string _type;

    private ViewState _viewState;

    #endregion

    #region Properties

    [Json("created_at")]
    public DateTime Created
    {
      get { return _created; }
      internal set { _created = value; }
    }

    [Json("id")]
    public int Id
    {
      get { return _id; }
      internal set { _id = value; }
    }

    [Json("updated_at")]
    public DateTime LastModified
    {
      get { return _lastModified; }
      internal set { _lastModified = value; }
    }

    [Json("reporter")]
    public User Reporter
    {
      get { return _reporter; }
      internal set { _reporter = value; }
    }

    [Json("text")]
    public string Text
    {
      get { return _text; }
      internal set { _text = value; }
    }

    [Json("type")]
    public string Type
    {
      get { return _type; }
      internal set { _type = value; }
    }

    [Json("view_state")]
    public ViewState ViewState
    {
      get { return _viewState; }
      internal set { _viewState = value; }
    }

    #endregion

    #region Methods

    public override string ToString()
    {
      return _text;
    }

    #endregion
  }
}
