using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    /// <summary>
    /// Represents a hashtable data structure that stores key-value pairs of student objects.
    /// </summary>
    /// <typeparam name="TKey">The key of the pair.</typeparam>
    /// <typeparam name="TValue">The value of the pair.</typeparam>
    public interface IHashtable<TKey, TValue>
    {
        /// <summary>
        /// Adds a key-value pair to the hashtable
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        void Add(TKey key, TValue value);

        /// <summary>
        /// Gets the value associated with the specified key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        TValue Get(TKey key);

        /// <summary>
        /// Determines whether the hashtable contains the specified key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        bool ContainsKey(TKey key);

        /// <summary>
        /// Removes the key and its associated value from the hashtable.
        /// </summary>
        /// <param name="key"></param>
        void Remove(TKey key);

        IEnumerable<KeyValuePair<TKey, TValue>> GetAllEntries();
    }
}
