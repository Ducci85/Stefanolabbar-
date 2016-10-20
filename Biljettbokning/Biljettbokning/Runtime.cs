using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biljettbokning
{
    class Runtime
    {
        public void Start()
        {
            List<Order> orders = new List<Order>();
            Manager manager = new Manager();

            bool loop = true;
            while (loop)
            {


                Menus.PrintMainMenu();

                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Order newOrder = manager.BokaNytt();
                        orders.Add(newOrder);
                        break;

                    case 2:
                        foreach (var order in orders)
                        {
                            string eventName = "";
                            if (order.Festival != null)
                                eventName = order.Festival.EventName;
                            else if (order.Concert != null)
                                eventName = order.Concert.EventName;
                            else if (order.Movie != null)
                                eventName = order.Movie.EventName;

                            Console.WriteLine("{0} - {1}", eventName, order.UserName);
                        }
                        Console.ReadKey(true);

                        //Menus.PrintConcertsInfo();
                        //Order newOrder1 = manager.BokaConcert();
                        //orders.Add(newOrder1);

                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Movies:");
                        foreach (var movie in manager.Titels)
                        {
                            Console.WriteLine(movie.EventName);
                        }

                        Console.WriteLine("\nConcerts:");
                        foreach (var concerts in manager.Titels)
                        {
                            Console.WriteLine(concerts.EventName);
                        }

                        Console.WriteLine("\nFestivals:");
                        foreach (var festival in manager.FestivalGenres)
                        {
                            Console.WriteLine(festival.EventName);

                        }

                        Console.ReadLine();
                        break;
                    case 4:
                        loop = false;

                        break;


                }
            }

        }

    }
}

