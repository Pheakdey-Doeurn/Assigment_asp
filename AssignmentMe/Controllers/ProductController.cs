using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssignmentMe.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Products()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Products(FormCollection doc)
        {
            TempData["productName"] = doc["proName"];
            TempData["price"] = doc["price"];
            return RedirectToAction("Order", "Product");
        }
        public ActionResult Order()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Order(int qty,int discount)
        {
            decimal price = Convert.ToDecimal(TempData["price"]);

            TempData["qty"] = qty;
            TempData["discount"] = discount;
            TempData["total"] = (price * qty);
            TempData["SubTotal"] = (price * qty) - discount;
            
            return RedirectToAction("Invoice", "Product");
        }
        public ActionResult Invoice()
        {
            return View();
        }
    }
}