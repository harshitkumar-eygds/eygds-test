//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace eydemo17thfeb
//{
//    class loops
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("enter a num");
//            int num = int.Parse(Console.ReadLine());
//            int i;
//            for (i = 1; i <= 10; i++) {
//                Console.WriteLine($"{num} X {i} = {num*i}");
//            }
//            Console.WriteLine("******************************************************");
//            Console.WriteLine("number from 100 to 1");
//            for (i = 100; i >= 1; i--) {
//                Console.Write($"{i} ");
//            }
//            Console.WriteLine("");
//            Console.WriteLine("******************************************************");
//            Console.WriteLine("1 to 50");
//            i = 1;
//            while (i <= 50) {
//                Console.Write($"{i} ");
//                i++;
//            }
//            Console.WriteLine("");
//            Console.WriteLine("******************************************************");
//            Console.WriteLine("50 to 1");
//            i = 50;
//            while (i >= 1)
//            {
//                Console.Write($"{i} ");
//                i--;
//            }
//            Console.WriteLine("");
//            Console.WriteLine("******************************************************");

//            string choice = "yes";
//            Console.WriteLine("Do you want to continue?");
//            choice = Console.ReadLine();
//            do {


//                Console.WriteLine("enter the name");
//                string name = Console.ReadLine();

//                Console.WriteLine("Enter the roll");
//                string roll = Console.ReadLine();

//                Console.WriteLine("Do you want to continue?");
//                choice = Console.ReadLine();


//            }while(choice == "YES" || choice == "Y" || choice == "y" || choice == "yes");


//            Console.ReadLine();
//        }
//    }
//}
