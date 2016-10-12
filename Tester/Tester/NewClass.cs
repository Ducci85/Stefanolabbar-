using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class NewClass
    {
        public void Start()
        {

            Console.WriteLine("Name");
            string name = Console.ReadLine();

            Console.WriteLine("Age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Breed");
            string breed = Console.ReadLine();

            Dog newDog = new Dog
            {
                Name = name,
                Age = age,
                Breed = breed
            };
            
                List<Dog> dogs = new List<Dog>()
                { 
                new Dog { Name = "Filex", Age = 7, Breed = "Big dog" },
                new Dog { Name = "Ajax", Age = 3, Breed = "Big dog" },
                new Dog { Name = "Max", Age = 10, Breed = "Medium dog" },
                new Dog { Name = "Fluffy", Age = 1, Breed = "Small dog" }

            };
            dogs.Add(new Dog { Name = "Spike", Age = 13, Breed = "Big F*** Dog!" });
            foreach (var dog in dogs)
            {
                Console.WriteLine(dog.Information());
            }
        }
    }
}
