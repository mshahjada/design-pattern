namespace CommandDesing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Television television = new Television();

            ICommand volumeDownCommand = new VolumeDownCommand(television);
            ICommand volumeUpCommand = new VolumeUpCommand(television);


            RemoteController remote = new RemoteController();

            remote.SetCommand(volumeDownCommand);
            remote.ButtonPress();

            remote.SetCommand(volumeUpCommand);
            remote.ButtonPress();

            Console.ReadKey();
        }
    }
}