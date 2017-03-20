using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCDbasePrac2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",//changed the name below from "Home" to "Burgers" 
                //since no home controller was created for this project
                defaults: new { controller = "Burgers", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
