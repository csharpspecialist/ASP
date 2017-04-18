using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NerdHerdAttempt1.Models;

namespace NerdHerdAttempt1.Controllers
{
    public class HomeController : Controller
    {

        NerdDinners nerdDinners = new NerdDinners();

        // GET: Home
        public ActionResult Index()
        {
           
            var dinners = from d in nerdDinners.Dinners
                          where d.EventDate > DateTime.Now
                          select d;

            return View(dinners.ToList());

            //get: Home/Create                 
            

        }

        public ActionResult Create()
        {

            return View();
        }

        //[HttpPost]
        //public ActionResult Create(Dinner dinner)
        //{
        //    if(ModelState.IsValid)
        //    {
        //        nerdDinners.Dinners.Add(dinner);
        //        nerdDinners.SaveChanges();
        //    }

        //    return View(dinner);

        //}

        [HttpPost]
        public ActionResult Create(Dinner dinner)
        {
            if (ModelState.IsValid)
            {
                nerdDinners.Dinners.Add(dinner);
                nerdDinners.SaveChanges();

                return RedirectToAction("Index");

            }

            return View(dinner);

        }




        //POST /HOME CREATE


    }
}