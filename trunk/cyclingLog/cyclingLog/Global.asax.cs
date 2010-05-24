using System.Web.Mvc;
using System.Web.Routing;

namespace cyclingLog
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",                                              // Route name
                "{controller}/{action}/{id}",                           // URL with parameters
                new { controller = "Login", action = "Index", id = "" });

            routes.MapRoute(
                "Profiles",                                              // Route name
                "{controller}/{action}/{id}",                           // URL with parameters
                new { controller = "Profiles", action = "Index", id="" });

            routes.MapRoute("Profile", "{controller}/{action}/{id}",
                            new {controller = "Profiles", action = "Detail", id = ""});


        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterRoutes(RouteTable.Routes);
        }
    }
}