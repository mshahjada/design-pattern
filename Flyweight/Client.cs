using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class Client
    {
        private ShapeFactory _shapeFactory;
        private List<(IShape, int, int, int)> _shapes = new();
        public Client(ShapeFactory shapeFactory) 
        { 
            _shapeFactory = shapeFactory;
        }

        public void AddCircle(int x, int y, int size, string color)
        {
            var circle = _shapeFactory.GetCircle(color);
            _shapes.Add((circle, x, y, size));
        }

        public void AddRectangle(int x, int y, int size, string color)
        {
            var rectable = _shapeFactory.GetRectangle(color);
            _shapes.Add((rectable, x, y, size));
        }

        public void DisplayShapes()
        {
            foreach (var (shape, x, y, size) in _shapes)
            {
                shape.Draw(x,y,size);
            }
        }
    }
}
