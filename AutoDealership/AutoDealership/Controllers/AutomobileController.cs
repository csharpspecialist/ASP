using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoDealership.Models;

namespace AutoDealership.Controllers
{
    public class AutomobileController : Controller
    {
        // GET: Automobile
        public ActionResult Index()
        {



            var drivers = from e in GetAutos()
                            orderby e.AutoID
                            select e;
            return View (drivers);

        }

        public static List<Machines> GetAutos()
        {
            return new List<Machines>

            { 
            new Machines
            {
                AutoID = 1,
                Make = "Dodge"
                , Model = "Charger"
                , Year = 2015
                , Color = "Blue"
            },

            new Machines
            {
                AutoID = 2,
                Make = "Chevy"
                , Model = "Corvette"
                , Year = 2015
                , Color = "Black"
            },

            new Machines
            {
                AutoID = 3,
                Make = "Infiniti"
                , Model = "FX 35"
                , Year = 2013
                , Color = "White"
            },
            new Machines
            {
                AutoID = 4,
                Make = "Lincoln"
                , Model = "MKZ"
                , Year = 2014
                , Color = "Red"
            }

        };

       }

    }
}