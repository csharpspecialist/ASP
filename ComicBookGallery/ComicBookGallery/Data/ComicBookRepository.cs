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
            new ComicBook()
            {
                BookID = 1,
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
               },
            Favorite = false

            },


             new ComicBook()
            {
                BookID = 2,
                SeriesTitle = "The Amazing Spider-man",
                IssueNumber = 657,
                DescriptionHTML = " Fantastic 4 Three Tie In!!! \n Spidey visits the FF for a very private wakeup!!!",
                Artists = new Artists[]
               {
                  new Artists() { Role = "Writer", Name = "Smasher" },
                  new Artists() { Role = "Pencil", Name = "Piper" },
                  new Artists() { Role = "Inks", Name = "Ms Marvel" },
                  new Artists() { Role = "Colors", Name = "Man-Child" },
                  new Artists() { Role = "Letters", Name = "Round Mound" },
               },
                Favorite = false

            },

                      new ComicBook()
            {

                BookID = 3,                          
                SeriesTitle = "Bone",
                IssueNumber = 50,
                DescriptionHTML = " Spidey Fights for his life!!! Villians are smarter than they look!!!",
                Artists = new Artists[]
               {
                  new Artists() { Role = "Writer", Name = "Batman" },
                  new Artists() { Role = "Pencil", Name = "Surfer" },
                  new Artists() { Role = "Inks", Name = "Fire Guy" },
                  new Artists() { Role = "Colors", Name = "Watcher" },
                  new Artists() { Role = "Letters", Name = "Glorious" },
               },
                Favorite = false

            }

        };

        public ComicBook[] GetComicBooks()
        {
            return _comicBooks;
        }


            

     public ComicBook GetComicBook(int id )
        {
            ComicBook comicBookToReturn = null;

            foreach (var comicBook in _comicBooks)
            {
                if(comicBook.BookID == id)
                {
                    comicBookToReturn = comicBook;
                    break;
                }


            }

            return comicBookToReturn;

        }
    }
}