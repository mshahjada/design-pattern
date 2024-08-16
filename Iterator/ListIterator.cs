using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class ListIterator<T> : IIterator<T>
    {
        private readonly List<T> _list;
        private int _index;
        public ListIterator(List<T> list)
        {
                _list = list;
                _index = 0;
        }
        public bool HasNext()
        {
            return _list.Count > _index;
        }

        public T Next()
        {
            if(HasNext())
            {
                return _list[_index++];
            }
            else
            {
                return default(T);
            }
        }
    }
}
