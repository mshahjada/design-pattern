using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class PlugIn : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("Laptop Works Properly Until ShutDown.");
            context.State = new PlugOut();
        }
    }
}
