using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biljettbokning
{
    public class Manager
    {

        public List<Festivaler> Festivaler { get; set; }



        public List<Konserter> Artister { get; set; }



        public List<Filmer> Titlar { get; set; }



        public Manager()

        {
            Festivaler = new List<Festivaler>()
            {
                new Festivaler { EventName = "Sweden Rock" },
                new Festivaler { EventName = "Metal Town" },
                new Festivaler { EventName = "Bråvala" }

            };

            Artister = new List<Konserter>();
            Titlar = new List<Filmer>();


            {

               
            }
        }
        

        public Order BokaFestival()
        {
            Console.Clear();
            Menus.PrintFestivals(Festivaler);

            Console.Write("Festival Index  ");
            int index = int.Parse(Console.ReadLine());

            Console.Write("User Name  ");
            string userName = Console.ReadLine();

            Order newOrder = new Order
            {
                Festival = Festivaler[index - 1],

                UserName = userName
            };

            return newOrder;
        }
      }
    }

