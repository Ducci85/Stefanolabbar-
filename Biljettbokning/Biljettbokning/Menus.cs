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
            Console.WriteLine("1. Add Bookings");
            Console.WriteLine("2. Show Bookings");
            Console.WriteLine("3. Show All Event Info");
            Console.WriteLine("4. Exit");

        }
        public static void PrintSubMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Festivals");
            Console.WriteLine("2. Concerts");
            Console.WriteLine("3. Movies");
            Console.WriteLine("4. Return");
        }
        public static void PrintFestivalsInfo()
        {
            Console.WriteLine("Festival Information");

            Console.ReadKey(true);

        }
        //public static void PrintConcertsInfo()
        //{
        //    Console.WriteLine("1. Artist Information");


        //    Console.ReadKey(true);
        //}
        //public static void PrintMoviesInfo()
        //{
        //    Console.WriteLine("1. Movie Information");

        //    Console.ReadKey(true);
        //}
        //public static void PrintBooking()
        //{
        //    Console.WriteLine("1. Book Ticket");
        //    Console.ReadKey(true);

        // }


        public static void PrintFestivals(List<Festivals> festivals)
        {
            for (int i = 0; i < festivals.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1,
                    festivals[i].EventName);
            }

        }

        public static void PrintConcerts(List<Concerts> Concerts)
        {
            for (int i = 0; i < Concerts.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1,
                    Concerts[i].EventName);
            }
        }
        public static void PrintMovies(List<Movies> Movies)
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1,
                    Movies[i].EventName);

            }
        }
    }
}
