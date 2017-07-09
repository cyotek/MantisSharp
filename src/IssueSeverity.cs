using System;

namespace MantisSharp
{
  public class IssueSeverity : LocalizedMantisEntity, IEquatable<IssueSeverity>
  {
    #region Methods

    public override bool Equals(object obj)
    {
      return !ReferenceEquals(null, obj) && (ReferenceEquals(this, obj) || obj.GetType() == this.GetType() && this.Equals((IssueSeverity)obj));
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

    #region IEquatable<IssueSeverity> Interface

    public bool Equals(IssueSeverity other)
    {
      return !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || this.Id == other.Id && string.Equals(this.Name, other.Name) && string.Equals(this.Label, other.Label));
    }

    #endregion
  }
}
