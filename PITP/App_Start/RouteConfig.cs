using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PITP
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("home", "home", new { controller = "PITP", action = "Index" });
            routes.MapRoute("about", "about", new { controller = "PITP", action = "About" });
            routes.MapRoute("About Us", "about-us", new { controller = "PITP", action = "about-us" });
            routes.MapRoute("Tent City", "tent-city", new { controller = "PITP", action = "tentcity" });
            routes.MapRoute("costs", "costs", new { controller = "PITP", action = "costs" });
            routes.MapRoute("donate", "donate", new { controller = "PITP", action = "Donate" });

            routes.MapRoute("Thank You", "thankyou", new { controller = "PayPal", action = "thankyou" });

            routes.MapRoute("2014", "2014", new { controller = "PITP", action = "year2014" });
            routes.MapRoute("2013", "2013", new { controller = "PITP", action = "year2013" });
            routes.MapRoute("2016", "2016", new { controller = "PITP", action = "year2016" });
            routes.MapRoute("contact", "contact", new { controller = "PITP", action = "contact" });

            routes.MapRoute("origins", "origins", new { controller = "PITP", action = "Origins" });
            routes.MapRoute("volunteer", "volunteer", new { controller = "PITP", action = "Volunteer" });
            //routes.MapRoute("Party2013", "Party2013", new { controller = "PITP", action = "Party2013" });
            routes.MapRoute("upandcoming", "upandcoming", new { controller = "PITP", action = "upandcoming" });
            routes.MapRoute("sponsors", "sponsors", new { controller = "PITP", action = "sponsors" });
            routes.MapRoute("pastevents", "pastevents", new { controller = "PITP", action = "pastevents" });
            routes.MapRoute("SiteMap", "SiteMap", new { controller = "PITP", action = "SiteMap" });
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "PITP", action = "Index", id = UrlParameter.Optional }
            );

            // Add our route registration for MvcSiteMapProvider sitemaps
            MvcSiteMapProvider.Web.Mvc.XmlSiteMapController.RegisterRoutes(routes);
        }
    }
}