using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TPH.Models;

namespace TPH.ViewModels
{
    public class ProductsViewModel
    {
        public int id { get; set; }

        public List<Product> Products { get; set; }
    }
}