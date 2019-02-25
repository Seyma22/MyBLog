using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlog.Controllers
{
    public class PostsController:Controller //ctrl+. ile sarı ampulü açıyoruz // Aynı işleri yapan classları aynı namespace de topluyoruz
    {

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Hello World dönüyor</returns>

        /*Class name ikiye ayrılıyor 1)Fully qualified class name namespace ile birlikte tanımlanmış class  */
        public ActionResult Index(string name)
        {
            string vname = "Şeyma";
            return Content(vname);
        }
    }
}