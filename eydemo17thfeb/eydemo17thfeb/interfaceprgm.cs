////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;


////// implicit way
////namespace eydemo17thfeb
////{
////    interface Imyinterface 
////    {
////        void add();
////        void remove();
////    }

////    interface Inewinterface
////    {
////        void clear();
////    }

////    class myclass : Imyinterface, Inewinterface   //implementation
////    {
////        public void add()
////        {
////            Console.WriteLine("this is add function of Imyinterface");
////        }

////        public void clear()
////        {
////            Console.WriteLine("this is clear function of Inewinterface");
////        }

////        public void remove()
////        {
////            Console.WriteLine("this is remove function of Imyinterface");
////        }
////    }

////    class interfaceprgm 
////    {
////        static void Main(string[] args)
////        {
////            myclass obj1 = new myclass();
////            obj1.add();
////            obj1.clear();
////            obj1.remove();
////        }
////    }
////}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////explicit

//namespace eydemo17thfeb
//{
//    interface Imyinterface
//    {
//        void add();
//        void remove();
//    }

//    interface Inewinterface
//    {
//        void clear();
//    }

//    class myclass : Imyinterface, Inewinterface   //implementation
//    {
//        void Imyinterface.add()
//        {
//            Console.WriteLine("this is add function of Imyinterface(explicit)");
//        }

//        void Inewinterface.clear()
//        {
//            Console.WriteLine("this is clear function of Inewinterface(explicit)");
//        }

//        void Imyinterface.remove()
//        {
//            Console.WriteLine("this is remove function of Imyinterface(explicit)");
//        }
//    }

//    class interfaceprgm
//    {
//        static void Main(string[] args)
//        {
//            myclass obj1 = new myclass();  //cannot invoke explicit interfaces
//            //cannot create object of interface

//            //make object of interface and initiate with class
//            Imyinterface m2 = new myclass();
//            m2.add();
//            m2.remove();

//            Inewinterface m3 = new myclass();
//            m3.clear();

//            //obj1.add();
//            //obj1.clear();
//            //obj1.remove();
//        }
//    }
//}
