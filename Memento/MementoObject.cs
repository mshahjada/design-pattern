using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class MementoObject
    {
        private string _state;

        internal MementoObject(string state)
        {
            _state = state;
        }

        internal string GetMementoState()
        {
            return _state;
        }
    }
}
