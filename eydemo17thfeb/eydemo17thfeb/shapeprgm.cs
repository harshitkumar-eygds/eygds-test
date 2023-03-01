//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace eydemo17thfeb
//{
//    class shape 
//    {
//        public int mx;
//        public int my;
//        public shape(int x, int y) 
//        {
//            mx = x;
//            my = y;
//        }
//        public void draw() 
//        {
//            Console.WriteLine($"Drawing shape at : {mx} , {my}");
//        }
//    }

//    class square : shape
//    {
        
//        public square (int x, int y) : base (x, y)
//        { } 
//        public new void draw()
//        {
//            Console.WriteLine($"Drawing square at : {mx} , {my}");
//        }
//    }

//    class circle : shape
//    {
       
//        public circle(int x, int y) : base(x, y)
//        { }
//        public new void draw()
//        {
//            Console.WriteLine($"Drawing circle at : {mx} , {my}");
//        }

//        public void fillcircle() 
//        {
//            Console.WriteLine("filling circle");
//        }
//    }

//    class shapeprgm
//    {
//        static void Main(string[] args)
//        {
//            shape sh = new shape(100, 100);
//            sh.draw();

//            square sh1 = new square(200, 200);
//            sh1.draw();

//            circle sh2 = new circle(300,300);
//            sh2.draw();


//            //=========================

//            shape[] shape = new shape[3];
//            shape[0] = new shape(100, 100);
//            shape[1] = new square(200, 200);
//            shape[2] = new circle(300, 300);

//            foreach (shape obj1 in shape) 
//            {
//                obj1.draw();
//            }

//            Console.WriteLine("=====down casting=========");

//            shape f1 = new circle(500, 500);

//            circle c = (circle)f1;

//            c.fillcircle();

//            Console.ReadKey();

//        }
//    }
//}
