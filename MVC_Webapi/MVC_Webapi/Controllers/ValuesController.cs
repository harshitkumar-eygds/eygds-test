using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC_Webapi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "Name1", "Name2" };
        //}

        public IEnumerable<string> GetCountry()
        {
            return new string[] { "India", "Sri Lanka", "Japan", "USA", "UK" };
        }

        //public IEnumerable<string> GetDept()
        //{
        //    return new string[] { "HR", "IT" ,"Sales", "Testing","Payroll","Fiance" };
        //}

        // GET api/values/5
        public int Get(int id)
        {
            return id;
        }

        public int Get(int a,int b)
        {
            return a+b;
        }


        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
