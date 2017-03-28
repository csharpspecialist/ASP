using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Web;
using ComicBookGallery.Models;

namespace ComicBookGallery.Data
{
    public class ComicBookRepository
    {
        private static ComicBook[] _comicBooks = new ComicBook[]
        {

        };

            

     public ComicBook GetComicBook()
        {
            var cBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spiderman",
                IssueNumber = 700,
                DescriptionHTML = "<p> Final Issue!! Spidey Vs Mysterio!!!</p>",
                Artists = new Artists[]
               {
                  new Artists() {Name = "Big shot", Role = "Blind Man" },
                  new Artists() {Name = "Writer", Role = "Good People" },
                  new Artists() {Name = "Heavyweight", Role = "Colossus" },
                  new Artists() {Name = "Hero", Role = "Power Man" },
                  new Artists() {Name = "Side Kick", Role = "Iron Fist" },
               }

            };

            return cBook;

        }
    }
}