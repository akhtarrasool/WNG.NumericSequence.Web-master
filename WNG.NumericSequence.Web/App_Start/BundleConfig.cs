using System.Web;
using System.Web.Optimization;

namespace WNG.NumericSequence.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {     

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/AngularBundle")
                    .IncludeDirectory("~/Scripts/AngularControllers", "*.js")
                    .Include("~/Scripts/AngularMVCApp.js"));
        }
    }
}
