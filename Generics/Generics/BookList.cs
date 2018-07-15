using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class BookList
    {
        public void Add(Book number)
        {
            throw new NotImplementedException();
        }

        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
    }

    public class GeneralList<T>
    {
        public void Add(T value)
        {

        }

        // return T
        public T this[int index]
        {
            get { throw new NotFiniteNumberException(); }
        }
    }
}
