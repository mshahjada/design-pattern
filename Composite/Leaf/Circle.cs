using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Leaf
{
    internal class Circle : IGraphic
    {
        public void Draw()
        {
            Console.WriteLine("Circle");
        }
    }
}
