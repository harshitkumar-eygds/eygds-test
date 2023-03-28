using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace newMVCWebAPI2.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        EYdatabaseEntities db = new EYdatabaseEntities();
        public IEnumerable<studentmark> GetStudentmarks()
        {
            var result = db.studentmarks.ToList();
            return result;

        }

        public studentmark Get(int id)
        {
            return db.studentmarks.Find(id);
        }

        public void POST (studentmark sm)
        {
            db.studentmarks.Add(sm);
            db.SaveChanges();
        }

        public void PUT(int id, studentmark sm) 
        {
            var result = db.studentmarks.Find(id);
            result.stud_name = sm.stud_name;
            result.sub_name = sm.sub_name;
            result.marks = sm.marks;

            db.SaveChanges();
        }

        public string DELETE(int id) 
        {
            studentmark sm = db.studentmarks.Find(id);
            db.studentmarks.Remove(sm);
            db.SaveChanges();
            return "Student " + id.ToString() + " deleted";
        }

        // GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/values
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/values/5
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}
