using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class ViewerOne: IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"{message} broadcast to {nameof(ViewerOne)}");
        }
    }
}
