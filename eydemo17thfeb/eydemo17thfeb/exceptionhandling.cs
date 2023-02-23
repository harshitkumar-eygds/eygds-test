using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eydemo17thfeb
{
    class exceptionhandling
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a num");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter 2nd num");
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;

                Console.WriteLine("Your division result is : " + result);
            }
            catch (DivideByZeroException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally block executing");
            }


            Console.WriteLine("=========Practice Program===========");

            try
            {
                string a = null;
                Console.WriteLine(a[0]);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("All exception block");
            }

            try 
            {
                int[] a = new int[4];
                Console.WriteLine(a[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("All exception block");
            }
            Console.ReadKey();
        }
    }
}
