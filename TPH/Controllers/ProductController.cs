using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TPH.Models;
using TPH.ViewModels;
using System.Collections;
using System.Data.Entity;

namespace TPH.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        [AllowAnonymous]
        public ActionResult Index()
        {
            var products = _context.Products.ToList();
            ViewBag.Products = products;
            return View();
        }
        [Authorize]
        public ActionResult Form()
        {
            return View();
        }

        private ApplicationDbContext _context;
        public ProductController()
        {
            _context = new ApplicationDbContext();
        }
        [Authorize]
        public ActionResult New()
        {
            var viewModel = new ProductFormViewModel
            {
                Product = new Product()
            };
            return View("Form", viewModel);
        }
        [Authorize]
        public ActionResult Save(Product product)
        {
            if(!ModelState.IsValid)
            {
                var viewModel = new ProductFormViewModel
                {
                    Product = product
                };
                return View("Form", viewModel);
            }
            else
            {
                _context.Products.Add(product);
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Product");
        }

        [Authorize]
        public ActionResult Remove(Product product)
        {
            _context.Products.Remove(product);
            return RedirectToAction("Index",  "Product");
        }

    }
}