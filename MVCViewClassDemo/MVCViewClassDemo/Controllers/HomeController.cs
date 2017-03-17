using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCViewClassDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Pepsi = "Good eats";

            return View();
        }

        public string MyController()
        {
            ViewBag.Cow = "Women can be very Nice!!";
            return "I am the Big Boy Controller";
        }

        public string Dude()
        {
            ViewBag.Small = "Clear Water";
            return "Whatever";
        }

        public ActionResult MyView()
        {
            ViewBag.Color = "No Way";
            return View();
        }


    }
}