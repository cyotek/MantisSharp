using System;
using System.Globalization;
using System.Text;

namespace MantisSharp
{
  internal sealed class QueryStringBuilder
  {
    #region Fields

    private StringBuilder _sb;

    #endregion

    #region Methods

    public void Add(string name, int value)
    {
      this.Add(name, value.ToString(CultureInfo.InvariantCulture));
    }

    public void Add(string name, string value)
    {
      if (_sb == null)
      {
        _sb = StringBuilderCache.Acquire();
      }

      if (_sb.Length != 0)
      {
        _sb.Append('&');
      }

      _sb.Append(name);
      _sb.Append('=');
      _sb.Append(Uri.EscapeDataString(value));
    }

    public override string ToString()
    {
      return _sb != null ? _sb.ToStringAndRelease() : string.Empty;
    }

    #endregion
  }
}
