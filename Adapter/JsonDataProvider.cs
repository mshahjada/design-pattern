using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class JsonDataProvider
    {
        internal string GetStudentData()
        {

            List<Student> students = new List<Student>
            {
                new Student { Name = "John", Age = 30, Id = 1 },
                new Student { Name = "Anna", Age = 22, Id = 2 },
                new Student { Name = "Mike", Age = 32, Id = 3 }
            };


            return JsonConvert.SerializeObject(students, Formatting.Indented);

        }
    }
}
