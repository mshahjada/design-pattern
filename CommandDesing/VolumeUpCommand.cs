using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesing
{
    internal class VolumeUpCommand : ICommand
    {
        private Television _television;
        public VolumeUpCommand(Television television) {
            _television = television;
        }
        public void Execute()
        {
            _television.VolumeUp();
        }
    }
}
