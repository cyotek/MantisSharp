using System;
using PetaJson;

namespace MantisSharp
{
  public class IssueStatus : LocalizedMantisEntity, IEquatable<IssueStatus>
  {
    #region Fields

    private string _color;

    #endregion

    #region Properties

    [Json("color")]
    public string Color
    {
      get { return _color; }
      internal set { _color = value; }
    }

    #endregion

    #region Methods

    public override bool Equals(object obj)
    {
      return !ReferenceEquals(null, obj) && (ReferenceEquals(this, obj) || obj.GetType() == this.GetType() && this.Equals((IssueStatus)obj));
    }

    public override int GetHashCode()
    {
      unchecked
      {
        int result;

        result = this.Id;
        result = (result * 397) ^ (this.Name?.GetHashCode() ?? 0);
        result = (result * 397) ^ (this.Label?.GetHashCode() ?? 0);

        return result;
      }
    }

    #endregion

    #region IEquatable<IssueStatus> Interface

    public bool Equals(IssueStatus other)
    {
      return !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || this.Id == other.Id && string.Equals(this.Name, other.Name) && string.Equals(this.Label, other.Label) && string.Equals(_color, other._color));
    }

    #endregion
  }
}
