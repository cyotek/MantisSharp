using System;
using System.Collections.Generic;
using System.Reflection;
using PetaJson;

namespace MantisSharp
{
  internal static class DeserializationUtilties
  {
    #region Static Methods

    public static void CopyTo(this Dictionary<string, object> props, object item)
    {
      props.CopyTo(item, null);
    }

    public static void CopyTo(this Dictionary<string, object> props, object item, LookupCache cache)
    {
      foreach (PropertyInfo property in item.GetType().GetProperties())
      {
        JsonAttribute attribute;

        attribute = property.GetCustomAttribute<JsonAttribute>();

        if (attribute != null)
        {
          string key;
          object value;

          key = attribute.Key;

          if (props.TryGetValue(key, out value))
          {
            Type type;

            type = property.PropertyType;

            if (Type.GetTypeCode(type) == TypeCode.Object && cache != null)
            {
              // HACk: This is pretty awful

              if (typeof(NamedMantisEntity).IsAssignableFrom(type))
              {
                Dictionary<string, object> childProps;

                childProps = (Dictionary<string, object>)value;

                switch (key)
                {
                  case "reporter":
                  case "user":
                    value = cache.User.Get(childProps);
                    break;
                  case "view_state":
                    value = cache.ViewState.Get(childProps);
                    break;
                  case "project":
                    value = cache.Project.Get(childProps);
                    break;
                  case "access_level_r":
                  case "access_level_rw":
                    value = cache.AccessLevel.Get(childProps);
                    break;
                  default: throw new NotImplementedException("Property '" + key + "' not supported.");
                }
              }
              else
              {
                throw new NotImplementedException("Type '" + type.FullName + "' not supported.");
              }
            }

#if NET20 || NET35 || NET40
            property.SetValue(item, Convert.ChangeType(value, type), null);
#else
            property.SetValue(item, Convert.ChangeType(value, type));
#endif
          }
        }
      }
    }

    public static T Create<T>(this Dictionary<string, object> props)
      where T : MantisEntity, new()
    {
      return props.Create<T>(null);
    }

    public static T Create<T>(this Dictionary<string, object> props, LookupCache cache)
      where T : MantisEntity, new()
    {
      T result;

      result = new T();

      props.CopyTo(result, cache);

      return result;
    }

    public static bool GetBoolean(this Dictionary<string, object> props, string key)
    {
      object value;

      return props.TryGetValue(key, out value) && Convert.ToBoolean(value);
    }

    public static TCollection GetChildren<TCollection, TChild>(this Dictionary<string, object> props, string key, LookupCache cache)
      where TCollection : class, ICollection<TChild>, new()
      where TChild : class, new()
    {
      TCollection result;
      object list;

      if (props.TryGetValue(key, out list))
      {
        List<object> childProps;

        result = new TCollection();
        childProps = (List<object>)list;

        for (int i = 0; i < childProps.Count; i++)
        {
          TChild item;
          Dictionary<string, object> values;

          item = new TChild();

          values = (Dictionary<string, object>)childProps[i];
          values.CopyTo(item, cache);

          result.Add(item);
        }
      }
      else
      {
        result = null;
      }

      return result;
    }

    public static DateTime GetDateTime(this Dictionary<string, object> props, string key)
    {
      object value;

      return props.TryGetValue(key, out value) ? DateTime.Parse(Convert.ToString(value)) : DateTime.MinValue;
    }

    public static int GetInteger(this Dictionary<string, object> props, string key)
    {
      object value;

      return props.TryGetValue(key, out value) ? Convert.ToInt32(value) : 0;
    }

    public static T GetReference<T>(this Dictionary<string, object> props, string key, LookupCache<T> cache)
      where T : MantisEntity, new()
    {
      T result;
      object childProps;

      result = props.TryGetValue(key, out childProps) ? cache.Get((Dictionary<string, object>)childProps) : null;

      return result;
    }

    public static TCollection GetReferences<TCollection, TChild>(this Dictionary<string, object> props, string key, LookupCache<TChild> cache)
      where TCollection : class, ICollection<TChild>, new()
      where TChild : MantisEntity, new()
    {
      TCollection result;
      object list;

      if (props.TryGetValue(key, out list))
      {
        List<object> childProps;

        result = new TCollection();
        childProps = (List<object>)list;

        for (int i = 0; i < childProps.Count; i++)
        {
          TChild item;

          item = cache.Get((Dictionary<string, object>)childProps[i]);

          result.Add(item);
        }
      }
      else
      {
        result = null;
      }

      return result;
    }

    public static string GetString(this Dictionary<string, object> props, string key)
    {
      object value;

      return props.TryGetValue(key, out value) ? Convert.ToString(value) : null;
    }

    private static T GetCustomAttribute<T>(this MemberInfo element)
      where T : Attribute
    {
      Attribute attribute;

      attribute = Attribute.GetCustomAttribute(element, typeof(T));

      return (T)attribute;
    }

    #endregion
  }
}
