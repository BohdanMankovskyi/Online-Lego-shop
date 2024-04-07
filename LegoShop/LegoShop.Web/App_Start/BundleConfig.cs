using System.Web;
using System.Web.Optimization;

public class BundleConfig
{
    // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
    public static void RegisterBundles(BundleCollection bundles)
    {
        // Bundle jQuery scripts
        bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-{version}.js"));

        // Bundle Bootstrap scripts
        bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                  "~/Scripts/bootstrap.js",
                  "~/Scripts/popper.js"));

        // Bundle OwlCarousel scripts
        bundles.Add(new ScriptBundle("~/bundles/owlcarousel").Include(
                  "~/Scripts/owl.carousel.js"));

        // Bundle Google Maps script
        // bundles.Add(new ScriptBundle("~/bundles/googlemaps").Include(
        //           "https://maps.googleapis.com/maps/api/js?key=YOUR_API_KEY&callback=myMap"));

        // Bundle custom scripts
        bundles.Add(new ScriptBundle("~/bundles/custom").Include(
                  "~/Scripts/custom.js"));

        // Bundle CSS
        bundles.Add(new StyleBundle("~/bundle/css").Include(
                  "~/Content/css/bootstrap.css",
                  "~/Content/css/font-awesome.min.css",
                  "~/Content/css/style.css",
                  "~/Content/css/responsive.css"));

        // Optional: Enable optimizations (bundling and minification)
        BundleTable.EnableOptimizations = true;
    }
}
