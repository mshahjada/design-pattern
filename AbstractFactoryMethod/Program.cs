using AbstractFactoryMethod.Factories.Concrete;
using AbstractFactoryMethod.Products.Abstract;

namespace AbstractFactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LogitechPeripheralFactory logitechPeripheralFactory = new LogitechPeripheralFactory();
            Peripheral peripheral = logitechPeripheralFactory.CreatePeripheral();
            peripheral.Assemble();

            Console.ReadKey();
        }
    }
}