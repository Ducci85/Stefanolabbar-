using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion2
{
    class Runtime
    {
        public void Start()
        {
            Student myStudent = new Student

            {
                Name = "Råger",
                Age = 23,
                City = "Stockholm",
                Class = "SUN16"
            };
            Teacher myTeacher = new Teacher
            {
                Name = "John",
                Age = 53,
                City = "Stockholm",
                Subject = "Programering"
            };

            Console.WriteLine(myStudent.Introduction());
            Console.WriteLine(myTeacher.Introduction());

        }
    }
}
