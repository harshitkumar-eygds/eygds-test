using System;
using newwebappservice.ServiceReference1;
using System.ServiceModel;


namespace NewConsoleCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WebService1SoapClient c1 = new WebService1SoapClient();

            Console.WriteLine("Enter num1: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Num2:");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Addition of num1 and num2 is : ");
            int result = c1.Addition(n1, n2);
            Console.WriteLine(result);

            Console.ReadKey();

        }
    }
}
