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
    [Authorize]
    public class CartController : Controller
    {
        

        // GET: Cart
        
        public ActionResult Index()
        {
            //var Cart = _context.Cart.ToList();
            //ViewBag.Cart = Cart;
            return View();
        }

        List<CartItem> cart = new List<CartItem>();
        
        public ActionResult OrderNow(int id)
        {
            cart.Add(new CartItem(_context.Products.Find(id), 1));
            ViewBag.Cart = cart;
            return View("Index");
        }
        
        public ActionResult AddToCart(int id, int quantityOrdered)
        {
            cart = new List<CartItem>();
            cart.Add(new CartItem(_context.Products.Find(id), quantityOrdered));
            ViewBag.Cart = cart;
            return View("Index");
        }

        public ActionResult RemoveFromCart(CartItem c, int? quanity)
        {
            cart.Remove(c);
            return View("Index");
        }

        public CartController()
        {
            _context = new ApplicationDbContext();
        }

        private ApplicationDbContext _context;

        public ActionResult CheckOut()
        {
            var viewModel = new CustomerViewModel
            {
                C = new Customer()
            };
            return View("CheckOut", viewModel);
        }
    }
}