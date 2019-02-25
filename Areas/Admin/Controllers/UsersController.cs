using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlog.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        // GET: Admin/Users
        public ActionResult Index(int id=0)
        {
            return Content("Users controller index action with parameter"+id.ToString());
        }

        public ActionResult Edit()
        {
            return Content("Edit");
        }

        public ActionResult New()
        {
            return Content("New");
        }

        public ActionResult List()
        {
            return Content("List");
        }



    }
}