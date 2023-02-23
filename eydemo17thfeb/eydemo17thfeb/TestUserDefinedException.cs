//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace eydemo17thfeb
//{
//    class TestUserDefinedException
//    {
//        public class InvalidAgeException : Exception 
//        {
//            public InvalidAgeException(string message): base(message) 
//            { }
            
//        }
//        static void validate(int age) 
//        {
//            if (age < 10)
//            {
//                throw new InvalidAgeException("Sorry, Please enter the correct age");
//            }
//        }

//        public static void Main(string[] args) 
//        {
//            try
//            {
//                Console.WriteLine("Enter the age");
//                int age = int.Parse(Console.ReadLine());
//                validate(age);
//            }
//            catch (InvalidAgeException e)
//            {
//                Console.WriteLine(e);
//            }

//            Console.WriteLine("Rest");
//            Console.ReadKey();
//        }

//    }
//}


