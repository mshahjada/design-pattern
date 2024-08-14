using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesing
{
    internal class RemoteController
    {
        private ICommand _command;
        public void SetCommand(ICommand command) {
            _command = command;
        }

        public void ButtonPress()
        {
            if(_command != null) { _command.Execute();  }
            else
            {
                Console.WriteLine("Invalid Command");
            }
            
        }
    }
}
