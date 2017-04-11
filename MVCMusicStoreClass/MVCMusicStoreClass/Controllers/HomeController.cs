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
                            orderby a.AlbumId
                            select a;

            return View(singers);
        }

        public List<Album> GetAlbumList()
        {

            return new List<Album>
                {
                 new Album
                {
                   AlbumId = 1,
                   GenreId = 100,
                   ArtistId = 100,
                   Title = "MVC Agony",
                    Price = 25,
                    AlbumArtUrl ="http://scarycoders.com"
                },
               new Album
                {
                   AlbumId = 2,
                   GenreId = 200,
                   ArtistId = 200,
                   Title = "C# Revenge",
                    Price = 20,
                    AlbumArtUrl ="http://keyboardtrippers.com"
                },
                                   
                  new Album
                {
                   AlbumId = 3,
                   GenreId = 300,
                   ArtistId = 300,
                   Title = "VS Horrors",
                    Price = 20,
                    AlbumArtUrl ="http://nightprogrammers.com"
                },

                 new Album
                {
                   AlbumId = 4,
                   GenreId = 400,
                   ArtistId = 400,
                   Title = "MVC Agony",
                    Price = 65,
                    AlbumArtUrl ="http://stickycoders.com"
                },
                 new Album
                {
                   AlbumId = 5,
                   GenreId = 500,
                   ArtistId = 500,
                   Title = "Internet Savior",
                    Price = 55,
                    AlbumArtUrl ="http://SaveOurLaptops.com"
                },

            };
        }




    }
}