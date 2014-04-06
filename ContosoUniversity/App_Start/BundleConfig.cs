using System.Web;
using System.Web.Optimization;

namespace ContosoUniversity
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/myjstools").Include(
                        "~/Scripts/jquery-ui-1.10.4.min.js",
                        "~/Scripts/jquery.cookie.js",
                        "~/Scripts/jquery.event.drag-2.2.js",
                        "~/Scripts/slickgrid/slick.core.js",
                        "~/Scripts/slickgrid/slick.formatters.js",
                        "~/Scripts/slickgrid/slick.editors.js",
                        "~/Scripts/slickgrid/slick.grid.js",
                        "~/Scripts/slickgrid/plugins/slick.rowselectionmodel.js",
                        "~/Scripts/slickgrid/slick.dataview.js",
                        "~/Scripts/slickgrid/controls/slick.pager.js",
                        "~/Scripts/slickgrid/controls/slick.columnpicker.js",
                        "~/Scripts/angular.js",
                        "~/Scripts/angular-route.min.js",
                        "~/Scripts/dynatree/jquery.dynatree.js",
                        "~/Scripts/dynatree/univ.tree.js",
                        "~/Scripts/angular/app.js",
                        "~/Scripts/angular/grid.directive.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/slickgrid/slick.grid.css",
                      "~/Scripts/slickgrid/controls/slick.pager.css",
                      "~/Scripts/slickgrid/controls/slick.columnpicker.css",
                      "~/Content/dynatree/skin-vista/ui.dynatree.css",
                      "~/Content/site.css"));
        }
    }
}
