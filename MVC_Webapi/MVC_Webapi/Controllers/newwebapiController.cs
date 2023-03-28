using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC_Webapi.Controllers
{
    public class newwebapiController : ApiController
    {
        public int Get(int id) 
        {
            return id;
        }
    }
}
