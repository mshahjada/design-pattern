using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal interface IShape
    {
        void Draw(int x, int y, int size);
    }
}
