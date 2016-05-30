using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace PITP
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles) 
        {
            bundles.Add(new ScriptBundle("~/Scripts").Include(
                 "~/js/jquery-{version}.js",
                 "~/js/bootstrap.min.js",
                 "~/js/site.js",
                 "~/js/jquery.easing.min.js",
                 "~/js/scrolling-nav.js"
                 ));

            bundles.Add(new StyleBundle("~/mycss").Include(                
                "~/css/vendors.css",                
                    "~/css/cosmo.css",
                    "~/css/pitp.css"
                    ));

            BundleTable.EnableOptimizations = false;
        }
    }
}