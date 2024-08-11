using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal abstract class Shape
    {
        protected IColor _color;

        internal Shape(IColor color)
        {
            _color = color;
        }

        internal abstract void ApplyColor();

    }
}
