using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TPH.Models;
using TPH.ViewModels;

namespace TPH.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            var Cart = _context.Cart.ToList();
            ViewBag.Cart = Cart;
            return View();
        }
        private ApplicationDbContext _context;

        public ActionResult Add()
        {
            //var CartItem = new CartItem
            //{
            //    name = product.name,
            //    price = product.price,
            //    Product = product,
            //    quantityInStock = product.quantityInStock
            //};
            var viewModel = new CartItemViewModel
            {
                CartItem = new CartItem()
            };

            return RedirectToAction("Index");
        }
    }
}