using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2_Stefano
{
    public abstract class Animal
    {
        public int Age { get; set; }
        public string Weight { get; set; }
        public string Sound { get; set; }
        
        


        public virtual string Introduction()

        {
            return String.Format("The age of the animal is {0}, the weight of it is {1},",
                                   Age,
                                   Weight
                                  

                                     );
                                   
        }
    }
}