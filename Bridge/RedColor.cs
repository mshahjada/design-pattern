using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class RedColor : IColor
    {
        public void FillColor()
        {
            Console.WriteLine("Fill With Red Color");
            Console.WriteLine();
        }
    }
}
