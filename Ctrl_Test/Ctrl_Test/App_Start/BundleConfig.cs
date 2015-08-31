using System.Web;
using System.Web.Optimization;

namespace Ctrl_Test
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            #if DEBUG
                        BundleTable.EnableOptimizations = false;
            #else
                        BundleTable.EnableOptimizations = true;
            #endif

            bundles.Add(new StyleBundle("~/css/vendor")
                            .Include("~/Content/bootstrap.min.css")
                            .Include("~/Content/font-awesome.min.css")
                            .Include("~/Content/bootstrap-additions.min.css")
                            .Include("~/Content/awesome-bootstrap-checkbox.css")
            );

            bundles.Add(new StyleBundle("~/css/onlineApp")
                            .Include("~/Content/2015-tc.css")
                            .Include("~/Content/onlineapp.css")
            );

            // angular stuff
            bundles.Add(new ScriptBundle("~/js/onlineApp")
                // .Include("~/Scripts/umnhf-2015.js")
                // .Include("~/includes/googleanalyticstracking.js")
                            .Include("~/Scripts/app/onlineApp.js")
                            .IncludeDirectory("~/Scripts/services/", "*.js")
                            .IncludeDirectory("~/Scripts/filters/", "*.js")
                            .IncludeDirectory("~/Scripts/directives/", "*.js")
                            .IncludeDirectory("~/Scripts/controllers/", "*.js"));
            // everything else
            bundles.Add(new ScriptBundle("~/bundles/vendor")
                            .IncludeDirectory("~/Scripts/vendor/", "*.js")
                );
        }
    }
}
