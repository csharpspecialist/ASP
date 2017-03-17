using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCControllerDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
//had to move this newly created route up to the front so that it was looked at first.  This made the project work!!
            routes.MapRoute(
     name: "Employee",
      url: "{Employee}/{name}",
      defaults: new
      {
          controller = "Employee",
          action = "Search",
          name = UrlParameter.Optional
      });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

  

        }
    }
}
