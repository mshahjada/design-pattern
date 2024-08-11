namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adapter Patter");

            IXmlClient xmlClient = new XMLAdapter();
            var data = xmlClient.ConvertJsonToXml();

            Console.WriteLine($"{data}");

            Console.ReadKey();

        }
    }   
}