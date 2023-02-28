//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace eydemo17thfeb
//{
//    class complex 
//    {
//        private int x;
//        private int y;

//        public complex() { }

//        public complex(int i, int j) 
//        {
//            x = i;
//            y = j;
//        }
//        public void show() 
//        {
//            Console.WriteLine(x + " " + y);
//        }

//        public static complex operator -(complex c) 
//        {
//            complex temp = new complex();
//            temp.x = -c.x;
//            temp.y = -c.y;
//            return temp;
//        }

//    }
//    class operatoroverloadingprgm
//    {
//        static void Main(string[] args)
//        {
//            complex obj1 = new complex();
//            Console.Write("obj1 : " );
//            obj1.show();
//            complex obj2 = new complex(10,20);
//            obj2.show();

//            obj1  = -obj2;

//            obj1.show();
//            obj2.show();

//            Console.ReadKey();

//        }
//    }
//}
