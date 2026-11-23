using System;
using System.Collections.Generic;
using System.Text;

namespace c_advanced_1
{
    //answer 20
    internal class Cashed<TKey,TValue>
    {
            Dictionary<TKey, TValue> items = new Dictionary<TKey, TValue>();

            Dictionary<TKey, DateTime> time = new Dictionary<TKey, DateTime>();

            public void Add(TKey key, TValue value, int minutes)
            {
                items[key] = value;
                time[key] = DateTime.Now.AddMinutes(minutes);
            }

            public TValue Get(TKey key)
            {
                if (Contains(key))
                {
                    return items[key];
                }

                return default(TValue);
            }

            public void Remove(TKey key)
            {
                items.Remove(key);
                time.Remove(key);
            }

            public bool Contains(TKey key)
            {
                if (items.ContainsKey(key) && time[key] > DateTime.Now)
                {
                    return true;
                }

                Remove(key);
                return false;
            }
        }
    }

