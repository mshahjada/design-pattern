namespace Iterator
{
    internal class Program
    {
        /// <summary>
        /// It's provides a way of accessing data from a aggregate without 
        /// exposing it's underlaying representation. 
        /// An object named iterator is used to access data, which encapsulate 
        /// the traversing details of the aggregate.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
               new Student() {Id = 1, Name = "Jone", Department = "CSE" },
               new Student() {Id = 2, Name = "Sabina", Department = "EEE" },
               new Student() {Id = 3, Name = "Hamid", Department = "ARC" }
            };

            IIterator<Student> studentIterator = new ConcreteAggegate<Student>(students)
                .CreateIterator();

            while(studentIterator.HasNext())
            {
                Student student = studentIterator.Next();

                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Department: {student.Department}");
            }

            Console.ReadKey();


        }
    }
}