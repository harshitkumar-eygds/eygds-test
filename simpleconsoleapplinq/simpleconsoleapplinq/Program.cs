using System;
using System.Linq;
namespace simpleconsoleapplinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //string[] name = { "aa", "bb", "cc", "dd", "ee" };

            //for (int i = 0; i < 5; i++) 
            //{
            //    Console.WriteLine(name[i]);
            //}

            //string[] name = { "aa", "bb", "cc", "dd", "ee" };

            //Console.WriteLine("Names starts with a");
            //var quer1 = from i in name
            //            where i.StartsWith("a")
            //            select i;
            //foreach (var item in quer1) 
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Names contains a");
            //var quer2 = from i in name
            //            where i.Contains("a")
            //            select i;
            //foreach (var item in quer2)
            //{
            //    Console.WriteLine(item);
            //}

            //var quer3 = from i in name
            //            select i;
            //foreach (var item in quer3)
            //{
            //    Console.WriteLine(item);
            //}

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            var query1 = from i in arr
                         where i >4 && i <8 
                         select i;
            Console.WriteLine("List of numbers");
            foreach (var item in query1) 
            {
                Console.WriteLine(item);
            
            }


            Console.ReadKey();
        }
    }
}
