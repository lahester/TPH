using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TPH.Models;
using TPH.ViewModels;

namespace TPH.Models
{
    public class CartItem
    {
        public Product pr = new Product();
        public Product Pr { get => pr; set => pr = value; }

        public int id { get; set; }
        public int quantityOrdered { get; set; }
        //public virtual Product Product { get; set; }
        
        public CartItem() { }

        public CartItem(Product product, int quantityOrdered )
        {
            this.pr = product;
            this.quantityOrdered = quantityOrdered;
        }
    }
}