using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2_Stefano
{
    public class Bird : Animal
    {
        public string CanFly { get; set; }

        public override string Introduction()
        {
            return String.Format("{0},{1}", base.Introduction(), Sound);
        }
    }
}