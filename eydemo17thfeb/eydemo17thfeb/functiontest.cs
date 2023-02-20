////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace eydemo17thfeb
////{
////    class functiontest
////    {
////        static void Main(string[] args)
////        {
////            Console.WriteLine("inside svm");

////            functiontest obj = new functiontest();

////            obj.function1();
////            function2();
////            function3();

////            Type t1 = typeof(functiontest);
////            Console.WriteLine(t1.Name);
////            Console.WriteLine(t1.FullName);

////            Type t2 = typeof(object);
////            Console.WriteLine(t2);

////            Console.ReadKey();
////        }

////        public void function1() {
////            Console.WriteLine("inside public void funtion");
////        }

////        public static void function2() {
////            Console.WriteLine("inside public static void fucntion");
////        }
////        static void function3()
////        {
////            Console.WriteLine("inside  static void fucntion");
////        }
////    }


////}


//using System;

//class myclass1 { }

//class myclass2 { }

//class MyClasss 
//{
//    static void Main(string[] args)
//    {
//        myclass1 myclass1 = new myclass1();
//        myclass2 myclass2 = new myclass2();

//        test(myclass1);
//        test(myclass2);

//        Console.ReadKey();
//    }

//    static void test(object obj) 
//    {
//        myclass1 obj1;
//        myclass2 obj2;


//        if (obj is myclass1)
//        {
//            Console.WriteLine("obj is myclass1");
//            obj1 = (myclass1)obj;
//        }

//        else if (obj is myclass2)
//        {
//            Console.WriteLine("obj is myclass2");
//            obj2 = (myclass2)obj;
//        }
//        else 
//        {
//            Console.WriteLine("Obj is neither class1 nor class2");
//        }
//    }

//}


