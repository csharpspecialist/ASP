using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloPrac1.Models;

namespace HelloPrac1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Words = "Whatever!!!!";
            ViewBag.Myst = "Get to the chopper!!!";
            //Car auto = new Car();

            
            var vehicles = HelloModel.GetCarInfo();
           

            return View(vehicles);
        }
    }
}