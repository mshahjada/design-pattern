namespace Memento
{
    internal class Program
    {
        /// <summary>
        /// This pattern is used to create & store the current value of an object 
        /// so that later on we can resote the value without violating encapsulation.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Caretaker caretaker = new Caretaker();

            Originator originator= new Originator("Hello, how are you? \n");
            originator.CreateMementoObject();
            caretaker.AddObjectState(originator.CreateMementoObject());

            originator.AddDescription("I'm fine! What about you?\n");
            caretaker.AddObjectState(originator.CreateMementoObject());
            

            originator.RestorePreviousVersion(caretaker.Get(0));

            Console.ReadKey();

        }
    }
}