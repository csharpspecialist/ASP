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
            //if(DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)
            //{
            //    return Redirect("/");
            //}
            //else
            //{
            //    return Content("Now we r cooking with gas");
            //}                      
            return View();
        }
    }
}