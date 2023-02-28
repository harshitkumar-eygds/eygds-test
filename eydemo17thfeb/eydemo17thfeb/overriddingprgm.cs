//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace eydemo17thfeb
//{
//    class overriddingprgm
//    {
//        class india 
//        {
//            public virtual void display() 
//            {
//                Console.WriteLine("this display function is of class india -- virtual");
//            }
//        }

//        class state : india
//        {
//            public override void display()
//            {
//                Console.WriteLine("this display function is of class state -- override");
//            }
//        }

//        static void Main(string[] args)
//        {
//            state obj1 = new state();

//            obj1.display();

//            Console.ReadKey();

//        }
//    }
//}
