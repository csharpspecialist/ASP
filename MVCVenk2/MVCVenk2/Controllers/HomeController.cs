﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCVenk2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            ViewData["Cities"] = new List<string>()
            {
                "Chicago",
                "Maine",
                "Ottawa",
                "Toronto",
                "Canton"

            };
            return View();
        }


        public ActionResult Parallax()
        {
            return View();

        }


        public ActionResult Scroll()
        {
            return View();

        }

        public ActionResult Work()
        {
            return View();

        }

        public ActionResult SmoothV4()
        {
            return View();

        }

    }
}