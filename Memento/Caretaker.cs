using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Caretaker
    {
        List<MementoObject> _mementos = new List<MementoObject>();

        public void AddObjectState(MementoObject mementoObject)
        {
            _mementos.Add(mementoObject); 
        }

        public MementoObject Get(int index)
        {
            if(index<_mementos.Count) return _mementos[index];  
            else
                throw new IndexOutOfRangeException();
        }
    }
}
