namespace Bridge
{
    internal class Program
    {

        //decopule abstraction from it's implementation 
        //can vary independently
        static void Main(string[] args)
        {
            Shape greenCirlce = new Circle(new GreenColor());
            Shape redCirlce = new Circle(new RedColor());
            Shape greenSquare = new Square(new GreenColor());
            Shape redSquare = new Square(new RedColor());

            greenCirlce.ApplyColor();
            redCirlce.ApplyColor();
            greenSquare.ApplyColor();
            redSquare.ApplyColor();

            Console.ReadKey();
        }
    }
}