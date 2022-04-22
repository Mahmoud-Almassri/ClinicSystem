using System.Web;
using System.Web.Optimization;

namespace ClinicSystem
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Styles/Login").Include(
                "~/Content/bootstrap.css",
                      "~/Styles/LoginStyles.css"));

            bundles.Add(new StyleBundle("~/Styles/HomePage").Include(
                "~/Styles/bootstrap.css",
                "~/Styles/Panel_Title_Form.css",
                "~/Styles/premium.css",
                "~/Styles/theme.css"));

            bundles.Add(new ScriptBundle("~/NewScripts/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/NewScripts/jquery-1.11.1.min.js",
                "~/Scripts/NewScripts/jquery.knob.js"));
        }
    }
}
