using System.Web;
using System.Web.Optimization;

namespace GridMVCAjaxDemo
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterStyleBundles(bundles);
            RegisterScriptBundles(bundles);
        }
        private static void RegisterStyleBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/Content/bootstrap.css",
                     "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/gridmvc").Include(
                     "~/Content/GridMvc/Gridmvc.css"));
        }

        private static void RegisterScriptBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/gridmvc").Include(
                      "~/Scripts/GridMvc/ladda-bootstrap/*.min.js",
                      "~/Scripts/GridMvc/URI.js",
                      "~/Scripts/GridMvc/gridmvc.min.js",
                      "~/Scripts/GridMvc/gridmvc-ext.js"));

            bundles.Add(new ScriptBundle("~/bundles/application/home").Include(
                      "~/Scripts/Application/home.js"));
        }        
    }
}
