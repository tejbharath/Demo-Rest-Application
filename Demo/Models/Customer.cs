using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string Address1 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string TypeDescription { get; set; }
    }
}