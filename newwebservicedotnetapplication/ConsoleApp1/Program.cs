using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using newwebappservice;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            newwebappservice.ServiceReference1.WebService1SoapClient c1 = new newwebappservice.ServiceReference1.WebService1SoapClient();

            Console.WriteLine("Enter num1: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Num2:");
            int n2 = int.Parse(Console.ReadLine());

            int result = c1.Addition(n1, n2);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
