using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2_Stefano
{
    public class Mammal : Animal
    {
        public string WarmBlooded { get; set; }

        public override string Introduction()
        {
            return String.Format("{0} {1} Is the dog warm blooded?", base.Introduction(), WarmBlooded);
        }
    }
}