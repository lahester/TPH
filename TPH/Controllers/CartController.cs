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

        List<CartItem> cart;

        public ActionResult OrderNow(int id)
        {
            if(cart == null)
            {
                cart = new List<CartItem>();
                cart.Add(new CartItem(_context.Products.Find(id), 1));
                ViewBag.Cart = cart;

            }
            else
            {
                cart.Add(new CartItem(_context.Products.Find(id), 1));
                ViewBag.Cart = cart;
            }
            return View("Index");
        }

        public ActionResult AddToCart(int id, int quantityOrdered)
        {
            if(cart == null)
            {
                cart = new List<CartItem>();
                cart.Add(new CartItem(_context.Products.Find(id), quantityOrdered));
                ViewBag.Cart = cart;
            }
            return View();
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