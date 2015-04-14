using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Burkina.Donations.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new {controller = "Donation", action = "Index", id = UrlParameter.Optional }
                //Nesse caso, a página default está: http://localhost:51945/Donation/Index 
                //Se eu não informar nenhum controller por exemplo, ele acessa por default o controller Home.
                //Se eu não informar nenhuma action por exemplo, ele acessa por default a action DonationsTotal.
            );
        }
    }
}
