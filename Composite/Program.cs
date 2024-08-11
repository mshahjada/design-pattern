using Composite.Composite;
using Composite.Leaf;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Circle circle = new Circle();

            CompositeGraphic compositeGraphic1 = new CompositeGraphic();

            compositeGraphic1.Add(rectangle);
            compositeGraphic1.Add(circle);

            CompositeGraphic compositeGraphic2 = new CompositeGraphic();
            compositeGraphic2.Add(circle);
            compositeGraphic2.Add(compositeGraphic1);

            Console.ReadKey();

        }
    }
}