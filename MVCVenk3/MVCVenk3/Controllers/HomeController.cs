using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCVenk3.Controllers
{
    public class HomeController : Controller
    {
    

        public string Index()
        {
            return "hello world";
        }


        public ActionResult Planets()
        {
           ViewBag.Worlds = new List<string>()
            {
                "Earth",
                "Jupiter",
                "Saturn",
                "Mars"

            };

            return View();
        }

    }
}