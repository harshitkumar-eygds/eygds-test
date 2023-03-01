//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace eydemo17thfeb
//{
//    class account
//    {
//        public int id;
//        public string name;
//        public static float rateofinterest;

//        public account(int a, string k)
//        {
//            id = a;
//            name = k;
//        }
//        static account()
//        {
//            rateofinterest = 9.5f;
//        }
//        public void display() 
//        {
//            Console.WriteLine("id : " + id  +"\n" + "name : " + name + "\n" + "rate of interest : " + rateofinterest);
//        }
//    }
//    class staticconstructorprgm
//    {
//        static void Main(string[] args)
//        {
//            account a1 = new account(12,"abc");
//            account a2 = new account(234,"hasfu");

//            a1.display();
//            a2.display();

//            Console.ReadKey();


//        }
//    }
//}
