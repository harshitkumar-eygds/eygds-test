using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace test_aspdotnetmvcwebapi_3003.Controllers
{
    [RoutePrefix("students")]

    public class ValuesController : ApiController
    {
        EYdatabaseEntities db = new EYdatabaseEntities();
        [HttpGet]
        [Route]
        public IEnumerable<studentmark> GetStudentmarks()
        {
            var result = db.studentmarks.ToList();
            return result;

        }

        [HttpGet]
        [Route("get/{id}")]
        public studentmark Get(int id)
        {
            return db.studentmarks.Find(id);
        }

        public void POST (studentmark sm)
        {
            db.studentmarks.Add(sm);
            db.SaveChanges();
        }

        public string PUT(int id, studentmark sm) 
        {
            var result = db.studentmarks.Find(id);
            result.stud_name = sm.stud_name;
            result.sub_name = sm.sub_name;
            result.marks = sm.marks;

            db.SaveChanges();
            var updateresult = db.studentmarks.Find(id);
            return updateresult.stud_name + " " + updateresult.sub_name + " " + updateresult.marks.ToString();
        }

        public string DELETE(int id) 
        {
            studentmark sm = db.studentmarks.Find(id);
            db.studentmarks.Remove(sm);
            db.SaveChanges();
            return "Student " + id.ToString() + " deleted";
        }
    }
}
