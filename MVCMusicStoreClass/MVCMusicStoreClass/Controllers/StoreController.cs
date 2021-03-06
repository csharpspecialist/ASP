﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMusicStoreClass.Models;

namespace MVCMusicStoreClass.Controllers
{
    public class StoreController : Controller
    {
        MusicStoreEntities storeDB = new MusicStoreEntities();
        // GET: Store
        //public ActionResult Index()
        //{
        //    var genres = new List<Genre>
        //    {
        //    new Genre { Name = "Disco"},
        //    new Genre { Name = "Jazz"},
        //    new Genre { Name = "Rock"}
        //    };
        //      return View(genres);
        //}


        public ActionResult Index()
        {
            var genres = storeDB.Genres.ToList();
            return View(genres);
        }
        
        //GET: /STORE/BROWSE
        public ActionResult Browse(string genre)
        {
            {
            // Retrieve Genre and its Associated Albums from database
                var genreModel = storeDB.Genres.Include("Albums")
                 .Single(g => g.Name == genre);
                return View(genreModel);
            }
        }


        //Get STORE/DETAILS    

        public ActionResult Details(int id)
        {

            //var album = new Album { Title = "Album " + id };
            var album = storeDB.Albums.Find(id);
            return View(album);
        }


    }
}