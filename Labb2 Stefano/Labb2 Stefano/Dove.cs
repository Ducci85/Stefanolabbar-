using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2_Stefano
{
    public class Dove : Bird
    {
        public string Egg { get; set; }

        public override string Introduction()

        {

            return String.Format("{0} Can a dove fly? {1},Can a dove fly? How does a dove sound?", base.Introduction(), Sound);
        }
    }
}