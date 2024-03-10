using System.Web;
using System.Web.Optimization;

namespace eUseControl.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bootstrap
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include("~/Content/bootstrap/bootstrap.min.css",
                new CssRewriteUrlTransform()));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include("~/Content/bootstrap/bootstrap.min.js"));

            //google-map
            bundles.Add(new ScriptBundle("~/bundles/google-map/js").Include("~/Content/google-map/gmap.js"));

            //icofont-css
            bundles.Add(new StyleBundle("~/bundles/icofont/css").Include("~/Content/icofont/icofont.min.css",
                new CssRewriteUrlTransform()));

            //jquery
            bundles.Add(
                new ScriptBundle("~/bundles/jquery/js").Include("~/Content/jquery/jquery.js"));

            //shuffle
            bundles.Add(new ScriptBundle("~/bundles/shuffle/js").Include("~/Content/shuffle/shuffle.min.js"));

            //slick-carousel - css
            bundles.Add(new StyleBundle("~/bundles/slick-carousel/css").Include(
                "~/Content/slick-carousel/slick/slick.css",
                "~/Content/slick-carousel/slick/slick-theme.css"));

            //slick-carousel - js
            bundles.Add(
                new ScriptBundle("~/bundles/slick-carousel/js").Include("~/Content/slick-carousel/slick/slick.min.js"));

            //assets - css
            bundles.Add(
                new StyleBundle("~/bundles/assets/css/style").Include("~/assets/css/style.css",
                    new CssRewriteUrlTransform()));

            //assets - js
            bundles.Add(new ScriptBundle("~/bundles/assets/script/js").Include("~/assets/js/script.js"));
            
            //stiluri pentru register-form   
            bundles.Add(new StyleBundle("~/bundles/assets/login").Include(
                "~/assets/login/css/style.css",
                "~/assets/login/scss/style.css",
                "~/assets/login/fonts/material-icon/css/material-design-iconic-font.min.css",
                "~/assets/login/fonts/material-icon/css/material-design-iconic-font.min.css"));
        }
    }
}