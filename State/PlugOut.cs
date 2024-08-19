using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class PlugOut : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("Laptop will may alive at moust 2 hours");
            context.State = new PlugIn();
        }
    }
}
