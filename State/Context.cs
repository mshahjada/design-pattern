using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Context
    {
        private IState _state;
        public Context(IState state)
        {
            State = state;
        }

        public IState State
        {
            get { return _state; }
            set
            { 
                _state = value;
            }
        }

        public void DeletegateRequest()
        {
            _state.Handle(this);
        }


    }
}
