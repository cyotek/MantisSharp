using System;

namespace MantisSharp
{
  public class Reference : NamedMantisEntity, IEquatable<Reference>
  {
    #region Methods

    public override bool Equals(object obj)
    {
      return !ReferenceEquals(null, obj) && (ReferenceEquals(this, obj) || obj.GetType() == this.GetType() && this.Equals((Reference)obj));
    }

    public override int GetHashCode()
    {
      unchecked
      {
        int result;

        result = this.Id;
        result = (result * 397) ^ (this.Name?.GetHashCode() ?? 0);

        return result;
      }
    }

    #endregion

    #region IEquatable<ProjectReference> Interface

    public bool Equals(Reference other)
    {
      return !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || this.Id == other.Id && string.Equals(this.Name, other.Name));
    }

    #endregion
  }
}
