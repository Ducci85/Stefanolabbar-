﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2_Stefano
{
    public class Dog : Mammal
    {
        public string Race { get; set; }

        public override string Introduction()

        {
            return String.Format("{0} {1} Yes it is!, How does a dog sound? {2} ",
                                        base.Introduction()
                                                  ,WarmBlooded,Sound);
        }
    }
}