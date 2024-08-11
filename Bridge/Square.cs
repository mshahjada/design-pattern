using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Square : Shape
    {
        public Square(IColor color) : base(color)
        {
            _color = color;
        }

        internal override void ApplyColor()
        {
           Console.Write($"{nameof(Square)} ");
            _color.FillColor();
        }
    }
}
