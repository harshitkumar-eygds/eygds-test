using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using studentmodelproj.Models;


namespace studentmodelproj.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Student()
        {
            ViewBag.Message = "Student Data";

            List<Student> std = new List<Student>()
            {
                new Student() { stud_id = 1 , stud_name = "Harshit" , stud_addno = 1000 , stud_class = 1 , stud_gender ='M' },
                new Student() { stud_id = 2 , stud_name = "Rohit" , stud_addno = 997 , stud_class = 4 , stud_gender ='M' },
                new Student() { stud_id = 3 , stud_name = "Rohini" , stud_addno = 897 , stud_class = 3 , stud_gender ='F' },
                new Student() { stud_id = 4 , stud_name = "Rahul" , stud_addno = 788 , stud_class = 10 , stud_gender ='M' },
                new Student() { stud_id = 5 , stud_name = "Shilpa" , stud_addno = 667 , stud_class = 12 , stud_gender ='F' }

            };

            var res = (from s in std select s);
            ViewBag.result = res;
            ViewBag.Count = res.Count();
            ViewBag.max = (from s in std select s.stud_addno).Max();
            ViewData["details"] = std;

            return View();
        }
    }
}