﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMusicStoreClass.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index()
        {
            return "Hello From Store.Index";
        }

        //GET: /STORE/BROWSE
        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            return (message);
        }


        //Get STORE/DETAILS
        public string Details(string id)
        {
            string message = "Store.Details ID =" + id;
            return (message);
        }


    }
}