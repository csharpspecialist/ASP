using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        MusicStoreEntities storeDB = new MusicStoreEntities();

        // GET: Store
        public ActionResult Index()
        {
            var genre = storeDB.Genre.ToList();

            return View(genre);
        }

        // GET: /Store/Browse?genre=Disco
        public ActionResult Browse(string genre)
        {
            // Retrieve Genre and its Associated Albums from Database
            //var genreModel = new Genre { Name = genre };
            var genreModel = storeDB.Genre.Include("Album")
                .Single(g => g.Name == genre);

            return View(genreModel);
        }

        // GET: /Store/Details/5
        public ActionResult Details(int id)
        {
            //var album = new Album { Title = "Album " + id };
            var album = storeDB.Album.Find(id);

            return View(album);
        }
    }
}