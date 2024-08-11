using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class ShapeFactory
    {
        private readonly Dictionary<string, IShape> _shapes = new();

        public IShape GetCircle(string color)
        {
            string key = $"{nameof(Circle)}-{color}";

            if (!_shapes.ContainsKey(key))
            {
                _shapes[key] = new Circle(color);
            }
            return _shapes[key];
        }

        public IShape GetRectangle(string color)
        {
            string key = $"{nameof(Rectangle)}-{color}";

            if (!_shapes.ContainsKey(key))
            {
                _shapes[key] = new Rectangle(color);
            }
            return _shapes[key];
        }
    }
}
