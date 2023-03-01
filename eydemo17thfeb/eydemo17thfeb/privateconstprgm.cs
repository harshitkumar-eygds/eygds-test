//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace eydemo17thfeb
//{

//    class emp
//    {
//        public int x;
//        private emp() 
//        {
//            Console.WriteLine("this is a private constructor");
//        }

//        public emp(int a) 
//        {
//            x = a;
//            Console.WriteLine("the value a for parameterized constructor is : " + a);
//        }

//        public emp func(int a) 
//        {
//            emp obj1 = new emp(a);
//            return obj1;
        
//        }
//    }
//    class privateconstprgm
//    {
//        static void Main(string[] args)
//        {
//            emp obj1 = new emp(3);
//            emp obj2 = obj1.func(2);

//            Console.WriteLine(obj2.x);

//            Console.ReadKey();


//        }
//    }
//}
