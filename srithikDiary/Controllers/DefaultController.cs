using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace srithikDiary.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult DairyFormManagement()
        {
            return View();
        }
        public ActionResult Ourproducts()
        {
            return View();
        }
    }
}