using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public int addition(int a, int b)
        {
            return a + b;
        }

        public int division(int a, int b)
        {
            return a / b;
        }

        public int multiplication(int a, int b)
        {
            return a * b;
        }

        public int subtraction(int a, int b)
        {
            return a - b;
        }
    }
}
