//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace eydemo17thfeb
//{
    
//    class delegateprgm
//    {
//        public delegate int mydelegate(int a, int b);
//        static void Main(string[] args)
//        {
//            //mydelegate d1 = new mydelegate(add());
//            //d1();


//            delegateprgm obj1 = new delegateprgm();
//            mydelegate d2 = new mydelegate(obj1.multiply);
//            d2 += divide;
//            d2 += add;

//            Console.WriteLine( ); 

//            int a = d2(10, 10);

//            Console.WriteLine(a);
//            Console.WriteLine(d2(10, 10)); 

//            Console.ReadKey();
//        }

//        static int add(int a , int b) 
//        {
//            // Console.WriteLine("addition result is : " + (5 + 10)); 
//            return a + b;
//        }

//        public int multiply(int a, int b)
//        {
//            //Console.WriteLine("multiplication result is : " + (5 * 10));
//            return a * b;
//        }

//        static int divide(int a, int b)
//        {
//            // Console.WriteLine("divide result is : " + (5 / 10));
//            return a / b;
//        }
//    }
//}
