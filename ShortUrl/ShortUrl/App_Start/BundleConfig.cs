using System;
using System.Web.Optimization;
using System.Web.UI;

namespace ShortUrl
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            Bundle bootstrap = new StyleBundle("~/bundle/Bootstrap")
                                .Include("~/Content/bootstrap-theme.min.css",
                                         "~/Content/bootstrap.min.css");
           
            
            bundles.Add(bootstrap);
            
        }
    }
}