using System.Web.Mvc;
using System.Web.Routing;

namespace JoshuaBaeslerApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Calculator", id = UrlParameter.Optional }
            );
            //     routes.MapRoute(
            //    name: "Hello",
            //    url: "{controller}/{action}/{name}/{id}"
            //);
        }
    }
}
