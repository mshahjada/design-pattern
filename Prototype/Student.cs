using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Student: ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Department Department { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public Student DeepCopy()
        {
            Student student = (Student)this.Clone();
            student.Department = new Department() { Name = Department.Name};
            student.Name = new string(this.Name);
            return student;
        }
    }
}
