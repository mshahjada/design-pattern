using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class Rectangle : IShape
    {
        private readonly string _color;
        public Rectangle(string color)
        {
            _color = color;
        }
        public void Draw(int x, int y, int size)
        {
            Console.WriteLine($"A {_color} {nameof(Rectangle)} drawn at point ({x},{y}) with size {size}");
        }
    }
}
