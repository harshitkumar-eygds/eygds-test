//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace eydemo17thfeb
//{
//    class emp 
//    {
//        public int empid;
//        public string empname;
//        public emp() 
//        {
//            empid = 0;
//            empname = "abc";
//        }

//        public emp(int a, string m)
//        {
//            empid = a;
//            empname = m;
//        }

//        public emp(emp k)
//        {
//            empid = k.empid;
//            empname = k.empname;
//        }

//        public void display() 
//        {
//            Console.WriteLine("emp id is : " + empid);
//            Console.WriteLine("emp name is : " + empname);
//        }

//    }

//    class copyconstructor
//    {
//        static void Main(string[] args)
//        {
//            emp obj1 = new emp();
//            obj1.display();
//            emp obj2 = new emp(12, "pqrs");
//            obj2.display();
//            emp obj3 = new emp(obj2);
//            obj3.display();

//            Console.ReadKey();
//        }
//    }
//}
