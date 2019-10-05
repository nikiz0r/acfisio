using System.Web.Optimization;

namespace acfisio
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                "~/Scripts/jquery-1.12.4.min.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/bootstrap-select.min.js",
                "~/Scripts/jquery.bootstrap-touchspin.min.js",
                "~/Scripts/magnific-popup.min.js",
                "~/Scripts/waypoints.min.js",
                "~/Scripts/counterup.min.js",
                "~/Scripts/waypoints-sticky.min.js",
                "~/Scripts/isotope.pkgd.min.js",
                "~/Scripts/owl.carousel.min.js",
                "~/Scripts/jquery.owl-filter.js",
                "~/Scripts/stellar.min.js",
                "~/Scripts/scrolla.min.js",
                "~/Scripts/custom.js",
                "~/Scripts/shortcode.js",
                "~/Scripts/jquery.bgscroll.js"));
            
            bundles.Add(new ScriptBundle("~/Revolution/scripts").Include(
                "~/plugins/revolution/revolution/js/jquery.themepunch.tools.min.js",
                "~/plugins/revolution/revolution/js/jquery.themepunch.revolution.min.js",
                "~/plugins/revolution/revolution/js/extensions/revolution-plugin.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/css/animate.min.css",
                "~/Content/css/bootstrap-select.min.css",
                "~/Content/css/bootstrap.min.css",
                "~/Content/css/custom.css",
                "~/Content/css/flaticon.min.css",
                "~/Content/css/loader.min.css",
                "~/Content/css/magnific-popup.min.css",
                "~/Content/css/owl.carousel.min.css",
                "~/Content/css/style.css",
                "~/Content/css/fontawesome/css/font-awesome.min.css",
                "~/Content/css/skin/skin-3.css"));
            
            bundles.Add(new StyleBundle("~/Revolution/css").Include(
                "~/plugins/revolution/revolution/css/settings.css",
                "~/plugins/revolution/revolution/css/navigation.css"));
        }
    }
}