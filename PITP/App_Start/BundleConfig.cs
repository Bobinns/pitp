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
                 "~/js/site.js"));

            bundles.Add(new StyleBundle("~/mycss").Include(
                    "~/css/cosmo.css",
                    "~/css/pitp.min.css"
                    ));

            BundleTable.EnableOptimizations = false;
        }
    }
}