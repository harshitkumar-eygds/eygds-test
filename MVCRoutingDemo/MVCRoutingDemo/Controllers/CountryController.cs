using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRoutingDemo.Controllers
{
    public class CountryController : Controller
    {
        // GET: Country
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult India()
        {
            return View();
        }

        public ActionResult UK()
        {
            return View();
        }

        public ActionResult Japan()
        {
            return View();
        }

        public ActionResult France()
        {
            return View();
        }

        public ActionResult test(int id) 
        {
            return View();
        }
    }
}