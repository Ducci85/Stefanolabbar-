using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biljettbokning
{
    class Menus
    {
        public static void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Festivaler");
            Console.WriteLine("2. Konserter");
            Console.WriteLine("3. Filmer");
            Console.WriteLine("4. Exit");
        }
            public static void PrintInfo()
        {
            Console.WriteLine("1. Festivalnamn");
            Console.WriteLine("2. Artist");
            Console.WriteLine("3. Titel");

        }
        
        public static void PrintFestivals(List<Festivaler> festivals)
        {
            for (int i = 0; i < festivals.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1,
                    festivals[i].EventName);
            }
        }
    }
    }
