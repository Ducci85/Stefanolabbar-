using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2_Stefano
{
    public class Reptile : Animal
    {
        public int NumberOfLegs { get; set; }

        public override string Introduction()

        {
            return String.Format("{0} How many legs does the snake have? {1},",
                                        base.Introduction(),
                                        NumberOfLegs);
        }
    }
}