using Microsoft.AspNetCore.Http;
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
        private ProductsViewModel pv = new ProductsViewModel();

        // GET: Cart
        public ActionResult Index()
        {
            //var Cart = _context.Cart.ToList();
            //ViewBag.Cart = Cart;
            return View();
        }

        public ActionResult OrderNow(int id)
        {
            if(HttpContext.Session["cart"] == null)
            {
                List<CartItem> cart = new List<CartItem>();
                cart.Add(new CartItem(_context.Products.Find(id), 1));
                Session["cart"] = cart;

            }
            else
            {
                List<CartItem> cart = new List<CartItem>();
                cart.Add(new CartItem(_context.Products.Find(id), 1));
                Session["cart"] = cart;
            }
            return View("ShoppingCart");
        }

        public CartController()
        {
            _context = new ApplicationDbContext();
        }

        private ApplicationDbContext _context;

        //public ActionResult Add()
        //{
        //    var CartItem = new CartItem
        //    {
        //        name = product.name,
        //        price = product.price,
        //        Product = product,
        //        quantityInStock = product.quantityInStock
        //    };
        //    var viewModel = new CartItemViewModel
        //    {
        //        CartItem = new CartItem()
        //    };

        //    return RedirectToAction("Index");
        //}
    }
}