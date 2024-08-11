namespace Flyweight
{
    internal class Program
    {
        /// <summary>
        /// Reuse object component so that application can be more memory efficient.
        /// Only intrinsic part of the object can be resused.
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            var client = new Client(new ShapeFactory());


            client.AddCircle(10, 20, 20, "Red");
            client.AddCircle(40, 50, 20, "Blue");
            client.AddCircle(70, 75, 20, "Blue");

            client.AddRectangle(10, 20, 20, "Orange");
            client.AddCircle(40, 50, 20, "Green");

            client.DisplayShapes();

            Console.ReadLine();
        }
    }
}