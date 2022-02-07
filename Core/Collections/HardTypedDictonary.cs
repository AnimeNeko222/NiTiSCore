﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace NiTiS.Core.Collections
{
    public class HardTypedDictonary : IEnumerable
    {
        private Dictionary<Type, object> dict = new Dictionary<Type, object>();

        public HardTypedDictonary() { }

        public void Add<T>(T obj)
        {
            dict.Add(typeof(T), obj);
        }

        public void Clear()
        {
            dict.Clear();
        }
        public int Count => dict.Count;

        public bool Exists<T>()
        {
            return dict.ContainsKey(typeof(T));
        }
        public bool Exists<T>(T item)
        {
            return dict.ContainsKey(typeof(T));
        }

        internal Dictionary<Type, object> Dictonary => dict;

        public T Get<T>()
        {
            return (T)dict[typeof(T)];
        }

        public IEnumerator GetEnumerator()
        {
            return dict.GetEnumerator();
        }

        public bool Remove(Type item)
        {
            return dict.Remove(item);
        }
    }
}
