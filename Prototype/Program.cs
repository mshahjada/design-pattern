namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prototype Pattern");

            Student student = new Student()
            {
                Id = 1,
                Name = "Mick",
                Age = 20,
                Department = new Department()
                {
                    Name = "CSE"
                }
            };

            var shallowStudent = (Student)student.Clone();
            var deepStudent = student.DeepCopy();

            StudentInfo(student);
            StudentInfo(shallowStudent);
            StudentInfo(deepStudent);

            student.Name = "Rick";
            student.Age = 22;
            student.Department.Name = "EEE";

           Console.WriteLine("------------------------------------");

            StudentInfo(student);
            StudentInfo(shallowStudent);
            StudentInfo(deepStudent);

            Console.ReadKey();

        }

        static void StudentInfo(Student student)
        {
            Console.WriteLine("Student Info Name: {0}, Age: {1}, Dept: {2} ", 
                student.Name, student.Age, student.Department.Name);   
        }
    }
}