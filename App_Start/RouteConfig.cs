using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Home page route defined. This request was responsed by Post Controller Index Action

            routes.MapRoute("AnaSayfa", "", new { controller = "Posts", action = "Index" }); //Anonim bir tip yaratıyoruz new ile daha sonra başka yerdeb ulaşamaycağımız
            routes.MapRoute("Login", "login", new { controller = "Auth", action = "Login" }); //Anonim bir tip yaratıyoruz new ile daha sonra başka yerdeb ulaşamaycağımız
            //Name,url adı,..



        }
    }
}
