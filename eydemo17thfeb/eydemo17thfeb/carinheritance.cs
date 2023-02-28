//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace eydemo17thfeb
//{
//    class vehicle
//    {
//        string wheel = "four wheel";

//        public void display()
//        {
//            Console.WriteLine("the vehicle has " + wheel);
//        }
//    }

//    class car : vehicle
//    {
//        string color = "red";   //single level

//        public void show() 
//        {
//            Console.WriteLine("the colour of car is " + color);   
//        }
//    }

//    class truck : car
//    {
//        string color = "black";         //multilevel 

//        public void show1()
//        {
//            Console.WriteLine("the colour of car is " + color);
//        }
//    }

//    class jeep : car
//    {
//        string music = "working fine";         //hierarchical

//        public void show1()
//        {
//            Console.WriteLine("the music system is  " + music);
//        }
//    }

//    class carinheritance
//    {
//        static void Main(string[] args)
//        {
//            car obj1 = new car();

//            obj1.display();
//            obj1.display();

//            truck obj2 = new truck();
//            obj2.display();
//            obj2.show();
//            obj2.show1();

//        }
//    }
//}
