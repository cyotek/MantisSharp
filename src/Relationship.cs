// Copyright (c) 2017 Cyotek Ltd.
// http://mantissharp.net/
// Licensed under the MIT License. See LICENSE.txt for the full text.

// If you use this control in your applications, attribution, donations or contributions are welcome.

using PetaJson;

namespace MantisSharp
{
  public class Relationship : MantisEntity
  {
    #region Fields

    private RelationshipType _relationshipType;

    private int _targetId;

    #endregion

    #region Properties

    [Json("type")]
    public RelationshipType RelationshipType
    {
      get { return _relationshipType; }
      set { _relationshipType = value; }
    }

    [Json("target_id")]
    public int TargetId
    {
      get { return _targetId; }
      set { _targetId = value; }
    }

    #endregion
  }
}
