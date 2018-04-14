using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPH.Models
{
    public class CartItem
    {
        public int id { get; set; }
        public String name { get; set; }
        public int quantityInStock { get; set; }
        public double price { get; set; }
        public virtual Product Product { get; set; }
    }
}