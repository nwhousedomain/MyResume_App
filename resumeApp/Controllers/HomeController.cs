using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace resumeApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My bio page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "my contact page.";

            return View();
        }
        public ActionResult modal()
        {

            return View();
        }
    }
}