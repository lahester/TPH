using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPH.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string State { get; set; }
        public string CardNumber { get; set; }
        public string ExpDate { get; set; }
        public string CEV { get; set; }
    }
}