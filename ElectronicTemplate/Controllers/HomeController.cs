using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectronicTemplate.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult About()
        {
           

            return View();
        }

        public ActionResult Contact()
        {
           

            return View();
        }
        public ActionResult Brand()
        {
            

            return View();
        }
        public ActionResult Special()
        {


            return View();
        }
    }
}