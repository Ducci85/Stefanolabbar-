using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }

        public Dog()
        {

        }
        public Dog(string name, int age, string breed)
        {
            Name = name;
            Age = age;
            Breed = breed;
        }
        public string Information()
        {
            return String.Format("Dog name is {0} and it is {1} years old, it is a {2}", Name, Age, Breed);

        }
    }
}
