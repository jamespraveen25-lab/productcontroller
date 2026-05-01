using System;
using System.Collections.Generic;
using System.Linq;
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

            ViewData["productid"]=productid;
            ViewData["name"]=Name;
            ViewData["quantity"]=Quantity;
            ViewData["price"]=Price;
            ViewData["status"]=status;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}