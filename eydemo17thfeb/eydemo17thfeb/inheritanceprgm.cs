using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eydemo17thfeb
{
    class india 
    {
        static private int custid;
        static private string custname;

        public void display() 
        {
            Console.WriteLine("customer id is " + custid);
            Console.WriteLine("customer name is " + custname);
        }
    }

    class uk
    {
        protected int empid;
        protected string empname;
    }

    class us
    {
        public int studid;
        public string studname;
    }

    class inheritanceprgm
    {
        static void Main(string[] args)
        {
            india obj1 = new india();
            //obj1.xxx;
            obj1.display();


            uk obj2 = new uk();
            //obj2.xx

            us obj3 = new us();
            obj3.studid = 3;
            obj3.studname = "jk";


            Console.ReadKey();
        }
    }
}
