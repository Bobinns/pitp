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
                 "~/js/scrolling-nav.js",
                 "~/js/bootstrap-progressbar.js",
                 "~/js/jquery.number.js"
                 ));

            bundles.Add(new StyleBundle("~/mycss").Include(                
                "~/css/vendors.css",                
                    "~/css/cosmo.css",
                    "~/css/pitp.css",
                    "~/css/style-blue.css",
                    "~/css/bootstrap-progressbar-3.1.1.css"
                    ));

            BundleTable.EnableOptimizations = true;
        }
    }
}