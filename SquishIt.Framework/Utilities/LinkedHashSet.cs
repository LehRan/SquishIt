using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SquishIt.Framework.Utilities
{
    public class LinkedHashSet<T> : IEnumerable<T>
    {
        HashSet<T> hash;
        List<T> list;

        public LinkedHashSet(IEqualityComparer<T> comparer)
        {
            hash = new HashSet<T>(comparer);
            list = new List<T>();
        }

        public bool Add(T item)
        {
            if (hash.Add(item))
            {
                list.Add(item);
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}
