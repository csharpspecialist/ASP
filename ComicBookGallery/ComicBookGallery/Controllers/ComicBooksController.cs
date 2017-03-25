using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
         public ActionResult Detail()
        {
            ViewBag.Desc = " Final Issue!! Spidey Vs Mysterio!!!";
            ViewBag.SeriesTitle = "The Amazing Spiderman";
            ViewBag.IssNum = 700;
            ViewBag.Pea = 320;

            ViewBag.Artists = new string[]
                {
            "Blind Man",
            "Good People",
            "Strong Guy",
            "Power Man",
            "Iron Fist",
                };


            return View();
        }
    }
}