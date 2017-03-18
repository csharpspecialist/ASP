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
            ViewBag.Wind = "I must Break You!!";

            
            var vehicles = HelloModel.GetCarInfo();

       

            return View(vehicles);
         
        }
    }
}