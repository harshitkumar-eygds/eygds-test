using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_EY
{
    /// <summary>
    /// Summary description for ado_demo1_asps
    /// </summary>
    public class ado_demo1_asps : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}