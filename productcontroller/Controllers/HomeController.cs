using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace productcontroller.Controllers
{
    public class HomeController : Controller
    {
        //GET:Product
        public ActionResult Index()
        {
            int productid = 9000;
            String Name = "apple";
            string Quantity = "1kg";
            Decimal Price = 199.99m;
            bool status = true;

            ViewData["productid"] = productid;
            ViewData["name"] = Name;
            ViewData["quantity"] = Quantity;
            ViewData["price"] = Price;
            ViewData["status"] = status;
            return View();
        }

        public ActionResult About()
        {
            int employeeid = 255;
            String employee = "james";
            String department = "lab";

            ViewBag.employeeid = employeeid;
            ViewBag.employee = employee;
            ViewBag.department = department;

            return View();
        }

        public ActionResult Redirect()
        {

            ViewBag.messages = "this is a viewbag message";
            ViewData["message"] = "this is a viewdata message";
            TempData["data"] = "this is a tempdata message";
            Session["sessiondata"] = "this is a session message";

            return View();
        }
        public ActionResult success()
        {
            TempData["data"] = "this is a tempdata message";
            Session["sessiondata"] = "this is a session message";



            return View();

        }
    
    
    }
}