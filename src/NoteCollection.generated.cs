﻿
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;

namespace MantisSharp
{
  public class NoteCollection : ICollection<Note>
  {
    #region Constants

    private readonly Dictionary<int, int> _indexesById;


    private readonly IList<Note> _items;

    #endregion

    #region Constructors

    public NoteCollection()
    {
      _indexesById = new Dictionary<int, int>();
      _items = new List<Note>();
    }

    #endregion

    #region Properties


    public Note this[int key]
    {
      get
      {
        int index;

        if (!_indexesById.TryGetValue(key, out index))
        {
          throw new KeyNotFoundException(string.Format("Cannot find key {0}.", key));
        }

        return _items[index];
      }
    }

    #endregion

    #region Methods


    public bool ContainsKey(int key)
    {
      return _indexesById.ContainsKey(key);
    }


    public bool TryGetValue(int key, out Note value)
    {
      int index;

      if (_indexesById.TryGetValue(key, out index))
      {
        value = _items[index];
      }
      else
      {
        index = -1;
        value = null;
      }

      return index != -1;
    }

    internal void Add(Note item)
    {
      int index;

      if (item == null)
      {
        throw new ArgumentNullException(nameof(item));
      }


      _items.Add(item);

      index = _items.Count - 1;

      _indexesById.Add(item.Id, index);
    }

    internal void Clear()
    {
      _indexesById.Clear();
      _items.Clear();
    }

    internal bool Remove(Note item)
    {
      return false;
    }


    #endregion

    #region ICollection<Note> Interface

    public bool Contains(Note item)
    {
      return this.ContainsKey(item.Id);
    }

    public void CopyTo(Note[] array, int arrayIndex)
    {
      _items.CopyTo(array, arrayIndex);
    }

    public IEnumerator<Note> GetEnumerator()
    {
      return _items.GetEnumerator();
    }

    void ICollection<Note>.Add(Note item)
    {
      this.Add(item);
    }

    void ICollection<Note>.Clear()
    {
      this.Clear();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return this.GetEnumerator();
    }

    bool ICollection<Note>.Remove(Note item)
    {
      return this.Remove(item);
    }

    public int Count
    {
      get { return _items.Count; }
    }

    bool ICollection<Note>.IsReadOnly
    {
      get { return false; }
    }

    #endregion
  }
}
