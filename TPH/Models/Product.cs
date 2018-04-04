using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPH.Models
{
    public class Product
    {
        public int id { get; set; }
        public String name { get; set; }
        public String color { get; set; }
        public int quantityInStock { get; set; }
        public double price { get; set; }
        public String category { get; set; }
        public String size { get; set; }
        public String weight { get; set; }
        public String image_URL { get; set; }


    }
}