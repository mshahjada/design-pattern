namespace ChainOfResponsibility
{
    internal class Program
    {
        /// <summary>
        /// This approach allows an object to pass a request along a chain of hadlers
        /// In this chain each handler will decide the object will be handled or pass it to
        /// the next handler.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            IRequestHandler handler1 = new RequestLevelHandler1();
            IRequestHandler handler2 = new RequestLevelHandler2();

            handler1.SendToNextHandler(handler2);

            handler1.HandleRequest(new Request() { Priority = "low" });
            handler1.HandleRequest(new Request() { Priority = "high" });

            Console.ReadKey();
        }
    }
}