using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    internal class Hashtable<TKey, TValue> : IHashtable<TKey, TValue>
    {
        private readonly Dictionary<TKey, TValue> _dictionary;

        public Hashtable()
        {
            _dictionary = new Dictionary<TKey, TValue>();
        }

        public void Add(TKey key, TValue value)
        {
            _dictionary.Add(key, value);
        }

        public bool ContainsKey(TKey key)
        {
            return _dictionary.ContainsKey(key);
        }

        public TValue Get(TKey key)
        {
            return _dictionary[key];
        }

        public void Remove(TKey key)
        {
            _dictionary.Remove(key);
        }

        public IEnumerable<KeyValuePair<TKey, TValue>> GetAllEntries()
        {
            return _dictionary;
        }
    }
}
