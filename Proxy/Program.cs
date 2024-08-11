namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var client = new Client(new DatabaseProxy(new Database()));


            client.GetData(1);
            client.GetData(1);
            client.GetData(2);
            Console.ReadLine();
        }
    }
}