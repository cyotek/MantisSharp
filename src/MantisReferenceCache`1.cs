using System.Collections.Generic;

namespace MantisSharp
{
  internal sealed class MantisReferenceCache<T>
    where T : MantisReference, new()
  {
    #region Constants

    private readonly Dictionary<int, T> _cache;

    private readonly object _lock;

    #endregion

    #region Constructors

    public MantisReferenceCache()
    {
      _cache = new Dictionary<int, T>();
      _lock = new object();
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

          newItem = props.Create<T>();

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
