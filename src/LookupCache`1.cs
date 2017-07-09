using System.Collections.Generic;

namespace MantisSharp
{
  internal sealed class LookupCache<T>
    where T : MantisReference, new()
  {
    #region Constants

    private readonly Dictionary<int, T> _cache;

    private readonly object _lock;

    private readonly LookupCache _owner;

    #endregion

    #region Constructors

    public LookupCache(LookupCache owner)
    {
      _cache = new Dictionary<int, T>();
      _lock = new object();
      _owner = owner;
    }

    #endregion

    #region Methods

    public T Get(int id)
    {
      T result;

      _cache.TryGetValue(id, out result);

      return result;
    }

    public T Get(Dictionary<string, object> props)
    {
      T result;
      int id;

      id = props.GetInteger("id");
      result = null;

      if (id > 0 && !_cache.TryGetValue(id, out result))
      {
        lock (_lock)
        {
          T newItem;

          newItem = props.Create<T>(_owner);

          if (!_cache.TryGetValue(id, out result))
          {
            _cache.Add(id, newItem);

            result = newItem;
          }
        }
      }

      return result;
    }

    #endregion
  }
}
