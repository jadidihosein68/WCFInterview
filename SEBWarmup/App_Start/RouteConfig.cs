using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SEBWarmup
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");




            // attribute routing ! 
            routes.MapMvcAttributeRoutes(); // u need it to enable attribute routing !  // place it before convention based route ! 



            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            // from most specific to most generic ! 


            // test example : http://localhost:1589/Test/Parameter/1/22
            routes.MapRoute(
             "MyrouteName", // should be unique 
             "Test/Parameter/{Pm1}/{Pm2}",
             new { controller = "Test", action = "RouteTest", id = UrlParameter.Optional }
             , new {pm1= @"1|2", Pm2=@"\d{2}" }
         );




            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
