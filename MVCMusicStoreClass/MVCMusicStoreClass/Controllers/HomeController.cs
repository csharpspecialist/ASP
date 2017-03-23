using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMusicStoreClass.Models;

namespace MVCMusicStoreClass.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var singers = from a in GetAlbumList()
                            orderby a.AlbumID
                            select a;

            return View(singers);
        }

        public List<Album> GetAlbumList()
        {

            return new List<Album>
                {
                 new Album
                {
                   AlbumID = 1,
                   GenreID = 100,
                   ArtistID = 100,
                   Title = "MVC Agony",
                    Price = 25,
                    AlbumArtUrl ="http://scarycoders.com"
                },
               new Album
                {
                   AlbumID = 2,
                   GenreID = 200,
                   ArtistID = 200,
                   Title = "C# Revenge",
                    Price = 20,
                    AlbumArtUrl ="http://keyboardtrippers.com"
                },
                                   
                  new Album
                {
                   AlbumID = 3,
                   GenreID = 300,
                   ArtistID = 300,
                   Title = "VS Horrors",
                    Price = 20,
                    AlbumArtUrl ="http://nightprogrammers.com"
                },

                 new Album
                {
                   AlbumID = 4,
                   GenreID = 400,
                   ArtistID = 400,
                   Title = "MVC Agony",
                    Price = 65,
                    AlbumArtUrl ="http://stickycoders.com"
                },
                 new Album
                {
                   AlbumID = 5,
                   GenreID = 500,
                   ArtistID = 500,
                   Title = "Internet Savior",
                    Price = 55,
                    AlbumArtUrl ="http://SaveOurLaptops.com"
                },

            };
        }




    }
}