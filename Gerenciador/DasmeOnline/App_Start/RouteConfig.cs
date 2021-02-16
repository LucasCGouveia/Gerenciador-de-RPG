using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DasmeOnline
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{cod}",
                defaults: new { controller = "Login", action = "LogOut", cod = UrlParameter.Optional, cod2 = UrlParameter.Optional }
            );
        }
    }
}
