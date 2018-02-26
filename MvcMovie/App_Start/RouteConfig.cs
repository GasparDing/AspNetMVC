using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcMovie
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // When we don't supply any URL segments when application run.
            // it defaults to "Home" controller and the "Index" action method
            // because of the the defaults routing path below.
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            // we can add custom routing rule
            routes.MapRoute(
                name: "Hello",
                url: "{controller}/{action}/{name}/{num}"
            );
        }
    }
}
