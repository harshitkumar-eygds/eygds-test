using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eydemo17thfeb
{
    class bankbalancepracticeprgm
    {
        public class InvalidBalanceException : Exception
        {
            public InvalidBalanceException(string message) : base(message)
            { }

        }
        static void validate(int balance, string type)
        {
            if (type == "savings")
            {
                if(balance <= 2000)
                throw new InvalidBalanceException("Sorry, Your balance is less than minimum balance allowed");
            }

            if (type == "current")
            {
                if (balance <= 0)
                    throw new InvalidBalanceException("Sorry, Your balance is less than minimum balance allowed");
            }
        }

        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Choose Bank account Type");
                Console.WriteLine("1.Savings account" );
                Console.WriteLine("2. Current account");
                int num1 = int.Parse(Console.ReadLine());
                String type = "";
                if (num1 == 1)
                    type = "savings";
                if (num1 == 2)
                    type = "current";

                Console.WriteLine("Enter balance");
                int balance = int.Parse(Console.ReadLine());
                validate(balance,type);
            }
            catch (InvalidBalanceException e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Rest");
            Console.ReadKey();
        }

    }
}


