using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Stefano
{
    class Runtime
    {
        public void Start()
        {


            Console.WriteLine(myDog.Introduction());
            Console.WriteLine(mySnake.Introduction());
            Console.WriteLine(myDove.Introduction());

            

        }
        
        Dog myDog = new Dog

        {
            
            Weight = "15",
            Age = 3,
            Sound = "The dog barks"

        };

        Snake mySnake = new Snake
        {
            NumberOfLegs = "0",
            Weight = "2",
            Age = 5,
            Sound = "The Snake hisses",
            Length = "3"
        };

        Dove myDove = new Dove
        {
            CanFly = "Yes",
            Weight = "1",
            Age = 1,
            Sound = "The Dove tweets"
        };
        
    }
}
