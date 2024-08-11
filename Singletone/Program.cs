namespace Singletone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sigletone Design Pattern with Thread Safety Manner");

            ICacheContext cacheContext = CacheContext.Instance;

            Console.WriteLine($"Connection Status: {cacheContext.GetConnectionStatus()}");

            Console.ReadKey();
        }
    }
}