using FactoryMethod.Factories;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory Method Design Pattern");

            MsSqlContextFactory msSqlContextFactory = new MsSqlContextFactory();
            msSqlContextFactory.CreateDBContext()
                .CreateConnection();

            MongoContextFactory mongoContextFactory = new MongoContextFactory();
            mongoContextFactory.CreateDBContext()
                .CreateConnection();

            Console.ReadKey();

        }
    }
}