using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RallyProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyVoterInfo()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Vote()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}