using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TPH.Models;

namespace TPH.ViewModels
{
    public class CartViewModel
    {
        public List<CartItem> Cart { get; set; }
    }
}