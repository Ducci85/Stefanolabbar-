using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link_lektion_3
{
    class Runtime
    {
        public void Start()
        {
            List<Person> people = new List<Person>()
            {

                new Link_lektion_3.Person {FirstName = "John",    LastName = "Fristad" ,  Age = 24, City = "Stockholm"},
                new Link_lektion_3.Person {FirstName = "Niklas",  LastName = "Svensson" , Age = 24, City = "Stockholm"},
                new Link_lektion_3.Person {FirstName = "Fredrik", LastName = "Karlsson" , Age = 24, City = "Stockholm"},
                new Link_lektion_3.Person {FirstName = "Nils",    LastName = "Andersson", Age = 24, City = "Stockholm"},
                new Link_lektion_3.Person {FirstName = "Karl",    LastName = "Nilsson"  , Age = 24, City = "Stockholm"},
                new Link_lektion_3.Person {FirstName = "Kim",     LastName = "Eriksson",  Age = 24, City = "Stockholm"},
                new Link_lektion_3.Person {FirstName = "Jim",     LastName = "Sundell" ,  Age = 24, City = "Stockholm"},
                new Link_lektion_3.Person {FirstName = "Sara",    LastName = "Jacobsson", Age = 24, City = "Stockholm"}
            };
            #region
            Person singlePerson = people.Single(person => String.Equals(person.ToString(), "John Fristad"));

            Console.WriteLine("Single: {0}", singlePerson.ToString());

            Person[] subset = people.Where(person => person.FirstName.Contains("John"))
                            .ToArray();

            foreach (var person in subset)
            {
                Console.WriteLine("Where: {0}", person.ToString());
                
            }
            #endregion
          
            
            #region
            PersonMeta[] peopleMeta = people
                            .Select(person => new PersonMeta { FullName = person.ToString() })
                            .ToArray();


           
            foreach (var meta in peopleMeta)
            {
                Console.WriteLine("MetaData: {0}", meta.FullName);
            }
            string[] firstNames = people
                .Select(person => person.FirstName)
                .ToArray();

            foreach (var firstName in firstNames)
            {
                Console.WriteLine("First names: {0}", firstName);
            }
            #endregion Select 
            #region
            string[] allNiklas = people
                .Where(person => String.Equals(person.FirstName, "Niklas"))
                .Select(person => person.FirstName)
                .ToArray();

            foreach (var niklas in allNiklas)
            {
                Console.WriteLine("Niklas: {0}", niklas);
            }
            #endregion

            Person personToRemove = people
                .SingleOrDefault(person => String.Equals(person.ToString(), "John Fristadt"));

            people.Remove(personToRemove);

            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());  
            }
        }

    }
}
