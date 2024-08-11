using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class GreenColor : IColor
    {
        public void FillColor()
        {
            Console.Write("Fill With Green Color");
            Console.WriteLine();
        }
    }
}
