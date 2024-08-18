namespace Observer
{
    internal class Program
    {
        /// <summary>
        /// If an object has different state it's known as Subject. When it's 
        /// required to notify others/ broadcast to others then it's act as a publisher.
        /// Other object which is actively listening the changes subscriber.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            TVChannel tvCHannel = new TVChannel(string.Empty);

            IObserver viewerOne = new ViewerOne();
            IObserver viewerTwo= new ViewerTwo();
            tvCHannel.Register(viewerOne);
            tvCHannel.Register(viewerTwo);


            tvCHannel.LatestMessage = "It's a new Bangladesh!";

            Console.ReadLine();

        }
    }
}