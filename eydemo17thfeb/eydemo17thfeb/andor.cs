//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace eydemo17thfeb
//{
//    class andor
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter a number : ");
//            int num = int.Parse(Console.ReadLine());
//            int fact = 1;
//            for (int i = 1; i <= num; i++) 
//            {
//                fact = fact * i;    
//            }
//            Console.WriteLine("factorial is : " + fact);




//            Console.Write("Enter a number : ");
//            string str = Console.ReadLine();
//            bool ispalindrome = true;

//            for (int i = 0; i <= str.Length/2; i++) 
//            {
//                if (str[i] == str[str.Length - 1 - i])
//                    ispalindrome = true;
//                else
//                    ispalindrome = false;
//            }
//            if(ispalindrome)
//                   Console.WriteLine("The given string is Palindrome ");
//            else
//                Console.WriteLine("The given string is not a Palindrome ");

//            Console.ReadKey();
//        }
//    }
//}
