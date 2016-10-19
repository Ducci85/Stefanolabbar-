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

                        Order newOrder = manager.BokaFestival();
                        orders.Add(newOrder);
                        break;

                    case 4:
                        loop = false;
                        break;

                }
            }




        }
    }
}

