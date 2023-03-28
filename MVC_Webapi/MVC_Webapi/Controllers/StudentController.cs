using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Webapi.Model;

namespace MVC_Webapi.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult StudentView()
        {
            List<Student> s = new List<Student>
            {
                new Student () { id=1, name="Harshit" , addno = 112 , gender = "Male"},
                new Student () { id=2, name="Sohan" , addno = 123 , gender = "Male"},
                new Student () { id=3, name="Shilpa" , addno = 145 , gender = "Female"},
                new Student () { id=4, name="Mohit" , addno = 234 , gender = "Male"},
                new Student () { id=5, name="Rohini" , addno = 445 , gender = "Female"}
            };

            var result = from p in s select p;

            ViewBag.result = result;


            return View();
        }
    }
}