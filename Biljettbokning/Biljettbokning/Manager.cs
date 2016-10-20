using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biljettbokning
{
    public class Manager
    {

        public List<Festivals> FestivalGenres { get; set; }



        public List<Concerts> Artists { get; set; }



        public List<Movies> Titels { get; set; }



        public Manager()

        {
            FestivalGenres = new List<Festivals>()
            {
                new Festivals { EventName = "Sweden Rock" },
                new Festivals { EventName = "Metal Town" },
                new Festivals { EventName = "Bråvala" }

            };

            Artists = new List<Concerts>()
            {
                new Concerts { EventName = "Slipknot" },
                new Concerts { EventName = "Metallica" },
                new Concerts { EventName = "Aqua" },

            };

            Titels = new List<Movies>()
            {
                new Movies { EventName = "Gone With The Wind"},
                new Movies { EventName = "Full Metal Jacket" },
                new Movies { EventName = "Saving Private Ryan" }

            };

        }

        public Order BokaNytt()
        {
            Menus.PrintSubMenu();
            Console.Write("Val: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    return BokaFestival();

                case 2:
                    return BokaConcert();

                case 3:
                    return BokaMovies();
            }

            return null;
        }

        public Order BokaFestival()
        {
            Console.Clear();
            Menus.PrintFestivals(FestivalGenres);

            Console.Write("Val:  ");
            int index = int.Parse(Console.ReadLine());

            Console.Write("User Name  ");
            string userName = Console.ReadLine();

            Order newOrder = new Order
            {
                Festival = FestivalGenres[index - 1],

                UserName = userName
            };

            return newOrder;

        }
        public Order BokaConcert()
        {
            Console.Clear();
            Menus.PrintConcerts(Artists);

            Console.Write("Val:  ");
            int index = int.Parse(Console.ReadLine());

            Console.Write("User Name  ");
            string userName = Console.ReadLine();

            Order newOrder1 = new Order
            {
                Concert = Artists[index - 1],

                UserName = userName

            };
            return newOrder1;
        }
        public Order BokaMovies()
        {
            Console.Clear();
            Menus.PrintMovies(Titels);

            Console.Write("Movies Index  ");
            int index = int.Parse(Console.ReadLine());

            Console.Write("User Name  ");
            string userName = Console.ReadLine();

            Order newOrder2 = new Order
            {
                Movie = Titels[index - 1],

                UserName = userName

            };
            return newOrder2;
        }

    }
}

