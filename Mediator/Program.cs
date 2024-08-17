namespace Mediator
{
    internal class Program
    {
        /// <summary>
        /// Restrict direct calls between objects, it will use a central point
        /// to communicate between themselves which is known as mediator. This pattern 
        /// makes object loosely coupled.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ITrafficMediator mediator = new TrafficMediator();
            ITrafficSignal signalEastWest = new TrafficSignal("East-West", mediator);
            ITrafficSignal signalNorthSouth = new TrafficSignal("North-South", mediator);

            signalEastWest.Close();
            signalNorthSouth.Open();

            Console.ReadKey();
        }
    }
}