//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace eydemo17thfeb
//{
//    abstract class myclass 
//    {
//        public abstract void function1() ;
//        public abstract void function2();

//        public void function3() 
//        {
//            Console.WriteLine("this is 3rd function written inside abstract class");
//        }

//    }

//    class car : myclass 
//    {
//        public override void function1()
//        {
//            Console.WriteLine("this is the override function1 in car");
//        }

//        public override void function2()
//        {
//            Console.WriteLine("this is the override function2 in car");
//        }
//    }
//    class abstractclassprgm
//    {
//        static void Main(string[] args)
//        {
//            car obj1 = new car();
//            obj1.function1();
//            obj1.function2();
//            obj1.function3();

//            Console.ReadKey();
//        }
//    }
//}
