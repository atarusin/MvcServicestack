using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebClient
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // пути к API
            routes.IgnoreRoute("rest/{*pathInfo}");

            routes.MapRoute(
                name: "Parts",
                url: "{controller}/PartsViews/{*viewName}",
                defaults: new { controller = "Operator", action = "PartsViews", viewName = "noview" }
            );

            routes.MapRoute(
                name: "Page",
                url: "{controller}/{*viewName}",
                defaults: new { controller = "Operator", action = "Page", viewName = "mainPage" }
            );
        }
    }
}