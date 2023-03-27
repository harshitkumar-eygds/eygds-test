﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace newwebservicedotnetapplication
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int Addition(int a, int b) 
        {
            return a + b;
        }
        [WebMethod]
        public int Subtraction(int a, int b)
        {
            return a - b;
        }
        [WebMethod]
        public int Multiplication(int a, int b)
        {
            return a * b;
        }
        [WebMethod]
        public int division(int a, int b)
        {
            return a / b;
        }
    }
}
