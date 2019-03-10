using System.Web;
using System.Web.Optimization;

namespace HelloWorld
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
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            //bundle js
            bundles.Add(new ScriptBundle("~/Javascript/js").Include(
                    "~/Scripts/js.js",
                    "~/Scripts/jquery.min.js",
                    "~/Scripts/owl.carousel.js"
                ));
            //bundle css
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",//đường đẫn tương đôi đén file
                      "~/Content/site.css",
                      "~/Content/owl.carousel.min.css",
                "~/Content/owl.theme.default.min.css",
                "~/Content/bootstrap.min.css",
                "~/Content/style.css",
                "~/Content/styleProduct.css"
                ));

            BundleTable.EnableOptimizations = true;//phải có khi muốn thêm 
        }
    }
}
