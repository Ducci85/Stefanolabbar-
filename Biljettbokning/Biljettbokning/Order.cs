using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biljettbokning
{
    public class Order
    {
        public Festivals Festival { get; set; }
        public Movies Movie { get; set; }
        public Concerts Concert { get; set; }
        public string UserName { get; set; }

    }
}