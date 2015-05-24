using System.Web.Optimization;

namespace JustBlog
{
  public class BundleConfig
  {
    public static void RegisterBundles(BundleCollection bundles)
    {
      bundles.UseCdn = true;

      bundles.Add(new ScriptBundle("~/Scripts").Include(
                                    "~/Scripts/jquery-{version}.js",
                                    "~/Scripts/jquery-migrate-{version}.js",
                                    "~/Scripts/bootstrap.js",
                                    "~/Scripts/jquery.validate.js",
                                    "~/scripts/jquery.validate.unobtrusive.js",
                                    "~/Scripts/jquery.validate.unobtrusive-custom-for-bootstrap.js"
                ));

      bundles.Add(new StyleBundle("~/Content").Include(
                                  "~/Content/bootstrap.css",
                                  "~/Content/bootstrap.min.css",
                                  "~/Content/body.css",
                                  "~/Content/bootstrap-responsive.css",
                                  "~/Content/bootstrap-mvc-validation.css",
                                  "~/Content/animate.css",
                                  "~/Content/bootstap-theme.css",
                                  "~/Content/font-awesome.min.css",
                                  "~/Content/main.css",
                                  "~/Content/prettyphoto.css"

          ));
    }
  }
}