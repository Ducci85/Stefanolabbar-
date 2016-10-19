using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2_Stefano
{
    public class Snake : Reptile
    {
        public int Length { get; set; }

        public override string Introduction()
        {
            return String.Format("{0} The length of the Snake is {1}, What sound does the snake do? {2}", base.Introduction(), Length,Sound);
        }
    }
}