using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallery.Models;


namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
         public ActionResult Detail()
        {
            var cBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spiderman",
                IssueNumber = 700,
                DescriptionHTML = "<p> Final Issue!! Spidey Vs Mysterio!!!</p>",
                Artists = new Artists[]
                {
                   new Artists(){Name = "Big shot", Role = "Blind Man" },
                  new Artists() {Name = "Writer", Role = "Good People" },
                  new Artists()   {Name = "Heavyweight", Role = "Colossus" },
                   new Artists()   {Name = "Hero", Role = "Power Man" },
                   new Artists()    {Name = "Side Kick", Role = "Iron Fist" },                                          
                }

            };                                   

            return View(cBook);
        }
    }
}