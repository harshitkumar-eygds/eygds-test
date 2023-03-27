using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using newmvcwebapplicationlinq.Models;

namespace newmvcwebapplicationlinq.Controllers
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

        public ActionResult studentmarksview()
        {
            //ViewBag.Message = "Student Marks View";

            //display
            DataClasses1DataContext LTS = new DataClasses1DataContext
                (@"Data Source=Lab-Host\SQLEXPRESS03; Initial Catalog=EYdatabase; Integrated Security=True");

            var dispres = from s in LTS.studentmarks
                              select s;

            ViewBag.disp_res = dispres;



            return View();
        }

        public ActionResult studentinsert(studentmark s)
        {

            DataClasses1DataContext LTS = new DataClasses1DataContext
                (@"Data Source=Lab-Host\SQLEXPRESS03; Initial Catalog=EYdatabase; Integrated Security=True");

            studentmark obj = new studentmark();

            obj.stud_name = s.stud_name;
            obj.sub_name = s.sub_name;
            obj.marks = s.marks;
            
            if (obj.stud_name != null && obj.stud_name !=null && obj.marks!=null) 
            {
                LTS.studentmarks.InsertOnSubmit(obj);
                LTS.SubmitChanges();
            }
            return View();
        }

        public ActionResult studentmarksdelete(studentmark s)
        {

            DataClasses1DataContext LTS = new DataClasses1DataContext
                (@"Data Source=Lab-Host\SQLEXPRESS03; Initial Catalog=EYdatabase; Integrated Security=True");

            int id = s.id;

            if (id>0)
            {
                var deleterow = from e in LTS.studentmarks
                                where e.id == id
                                select e;
                LTS.studentmarks.DeleteAllOnSubmit(deleterow);
                LTS.SubmitChanges();
            }
            return View();
        }

        public ActionResult delete(int sid)
        {

            DataClasses1DataContext LTS = new DataClasses1DataContext
                (@"Data Source=Lab-Host\SQLEXPRESS03; Initial Catalog=EYdatabase; Integrated Security=True");

            int id = sid;

            if (id > 0)
            {
                var deleterow = from e in LTS.studentmarks
                                where e.id == id
                                select e;
                LTS.studentmarks.DeleteAllOnSubmit(deleterow);
                LTS.SubmitChanges();
            }
            return RedirectToAction("studentmarksview");
           // return RedirectToRoute()
        }

        public ActionResult update(int sid, string sname, string subname, int marks)
        {

            DataClasses1DataContext LTS = new DataClasses1DataContext
                (@"Data Source=Lab-Host\SQLEXPRESS03; Initial Catalog=EYdatabase; Integrated Security=True");

            int id = sid;

            if (id > 0 && sname != null && subname != null)
            {
                var updateres = from e in LTS.studentmarks
                                where e.id == id
                                select e;


                foreach (var i in updateres)
                {
                    i.stud_name = sname;
                    i.sub_name = subname;
                    i.marks = marks;
                }

                LTS.SubmitChanges();
            }
            return View();
        }

        public ActionResult studentmarksupdate(studentmark s)
        {

            DataClasses1DataContext LTS = new DataClasses1DataContext
                (@"Data Source=Lab-Host\SQLEXPRESS03; Initial Catalog=EYdatabase; Integrated Security=True");

            int id = s.id;

            if (id > 0 && s.stud_name != null && s.sub_name != null)
            {
                var updateres = from e in LTS.studentmarks
                                where e.id == id
                                select e;

               
                foreach (var i in updateres)
                {
                    i.stud_name = s.stud_name;
                    i.sub_name = s.sub_name;
                    i.marks = s.marks;
                }

                LTS.SubmitChanges();
            }
            return View();
        }
    }
}