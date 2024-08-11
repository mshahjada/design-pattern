using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class Circle : IShape
    {
        private readonly string _color;
        public Circle(string color)
        {
            _color = color;
        }
        public void Draw(int x, int y, int size)
        {
            Console.WriteLine($"A {_color} {nameof(Circle)} drawn at point ({x},{y}) with size {size}");
        }
    }
}
