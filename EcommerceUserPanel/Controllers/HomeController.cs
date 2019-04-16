using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EcommerceUserPanel.Models;
using EcommerceUserPanel.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EcommerceUserPanel.Controllers
{
    public class HomeController : Controller
    {
        ShoppingDemoooo2Context context = new ShoppingDemoooo2Context();
        public IActionResult Index()
        {
            var product = context.Products.ToList();
            int j = 0;
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int i = 0;
            if (cart != null)
            {
                foreach (var item in cart)
                {
                    i++;
                }
                if (i != 0)
                {
                    foreach (var i1 in cart)
                    {
                        j++;
                    }
                    HttpContext.Session.SetString("cartitem", j.ToString());
                }
            }
            return View(product);
        }
        public IActionResult AboutUs()
        {
            
            return View();
        }
        public IActionResult HomePage()
        {
            var product = context.Products.ToList();
            int j = 0;
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int i = 0;
            if (cart != null)
            {
                foreach (var item in cart)
                {
                    i++;
                }
                if (i != 0)
                {
                    foreach (var i1 in cart)
                    {
                        j++;
                    }
                    HttpContext.Session.SetString("cartitem", j.ToString());
                }
            }
            return View(product);
        }
        [HttpGet]
        public ViewResult Feedback()
        {
            ViewBag.Feed = new SelectList(context.Customers, "CustomerId", "UserName");
            return View();
        }
        [HttpPost]
        public ActionResult Feedback(Feedbacks fed)
        {
            context.Feedbacks.Add(fed);
            context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

    }
}
