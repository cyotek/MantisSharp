using System;
using System.Text;

namespace MantisSharp
{
  internal static class StringBuilderCache
  {
    #region Constants

    private const int _maxBuilderSize = 360;

    #endregion

    #region Static Methods

    public static StringBuilder Acquire(int capacity = 16)
    {
      StringBuilder result;

      result = null;

      if (capacity <= _maxBuilderSize)
      {
        StringBuilder cachedInstance;

        cachedInstance = _cachedInstance;

        if (cachedInstance != null && capacity <= cachedInstance.Capacity)
        {
          _cachedInstance = null;
          cachedInstance.Length = 0;
          result = cachedInstance;
        }
      }

      return result ?? new StringBuilder(capacity);
    }

    public static string GetStringAndRelease(StringBuilder sb)
    {
      string result;

      if (sb != null)
      {
        result = sb.ToString();
        Release(sb);
      }
      else
      {
        result = null;
      }

      return result;
    }

    public static void Release(StringBuilder sb)
    {
      if (sb.Capacity <= _maxBuilderSize)
      {
        _cachedInstance = sb;
      }
    }

    public static string ToStringAndRelease(this StringBuilder sb)
    {
      return GetStringAndRelease(sb);
    }

    #endregion

    #region Other

    [ThreadStatic]
    private static StringBuilder _cachedInstance;

    #endregion
  }
}
