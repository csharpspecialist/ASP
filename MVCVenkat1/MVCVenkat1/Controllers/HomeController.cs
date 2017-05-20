using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCVenkat1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Countries = new List<string>
            {
                "Guatemala",
                "Pakistan",
                "England",
                "South America",
                "France"

            };
            return View();
        }

        public string GetDetails()
        {
            return "We Know what we r talking about!!!";
        }





    }
}