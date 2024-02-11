using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssignmentMe.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string uname, string pw /*FormCollection values*/)
        {
            /*if (values["username"] == "admin" && values["password"] == "123")

                return RedirectToAction("Products", "Product");
                return Content("Invalid!");*/
            if(uname=="Pheakdey" && pw == "123")
            {
                Session["username"] = uname;
                return RedirectToAction("Products", "Product");
            }
            return Content("Login Failed!");


        }
    }
}