using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using SampleApplication.CustomViewEngine;

namespace SampleApplication
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new WebFormViewEngine());
            ViewEngines.Engines.Add(new RazorViewEngine());
            ViewEngines.Engines.Add(new XsltViewEngine
                                        {
                                            ViewLocationFormats = new [] { "~/Views/{1}/{0}.xslt", "~/Views/Shared/{0}.xslt" },
                                            PartialViewLocationFormats = new[] { "~/Views/{1}/{0}.xslt", "~/Views/Shared/{0}.xslt" }
                                        });

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}