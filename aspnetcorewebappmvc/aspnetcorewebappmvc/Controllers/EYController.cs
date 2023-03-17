using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcorewebappmvc.Controllers
{
    public class EYController : Controller
    {
        public IActionResult Index(int id)
        {
            View.ID = id;
            return View();
        }
    }
}
