using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eydemo17thfeb
{
    class nestedtrycatch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter numbers to divide 10");
            int[] arr1 = new int[5];
            try
            {
                for (int i = 0; i < 5; i++)
                    arr1[i] = int.Parse(Console.ReadLine());
                
                try
                {
                    Console.Write("Numbers you have entered is : ");
                    for (int i = 0; i < 5; i++)
                        Console.Write( arr1[i] + " ");
                    
                    Console.WriteLine();

                    for (int i = 0; i < 5; i++)
                        Console.WriteLine($"10 divide by {arr1[i]} is : {10 / arr1[i]}");
                }
                catch(Exception e) 
                {
                    Console.WriteLine("Exception (Inner block) : " + e.Message);
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine("Exception (Outer block) : " + e.Message);
            }

            Console.ReadKey();

        }
    }
}
