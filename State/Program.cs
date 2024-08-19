namespace State
{
    internal class Program
    {
        /// <summary>
        /// When the internal sate of an object changed then this pattern lets the object 
        /// it's need to alter.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Context context = new Context(new PlugIn());

            context.DeletegateRequest();
            context.DeletegateRequest();

            Console.ReadKey();

        }
    }
}