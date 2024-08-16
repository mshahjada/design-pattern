using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class ConcreteAggegate<T> : IAggregate<T>
    {
        private readonly List<T> _list;
        public ConcreteAggegate(List<T> list)
        {
            _list = list;       
        }

        public IIterator<T> CreateIterator()
        {
            return new ListIterator<T>(_list);
        }
    }
}
