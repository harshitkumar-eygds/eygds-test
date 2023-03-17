using System;
using System.Collections.Generic;
using System.Linq;
namespace simpleconsoleapplinq
{
    class employee 
    {
        public int emp_id { get; set; }
        public string emp_name { get; set; }
        public int emp_deptid { get; set; }
        public string emp_gender { get; set; }
        public int emp_salary { get; set; }
    }
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

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            //var query1 = from i in arr
            //             where i >4 && i <8 
            //             select i;
            //Console.WriteLine("List of numbers");
            //foreach (var item in query1) 
            //{
            //    Console.WriteLine(item);

            //}

            //Console.WriteLine("min" + arr.Min());
            //Console.WriteLine("max" + arr.Max());
            //Console.WriteLine("avg" + arr.Average());
            //Console.WriteLine("count" + arr.Count());

            List<employee> emp = new List<employee>()
            {
                new employee() { emp_id= 101 , emp_name ="aaa" , emp_gender = "M" , emp_deptid=10 , emp_salary = 100000} ,
                new employee() { emp_id= 102 , emp_name ="bbb" , emp_gender = "F" , emp_deptid=10 , emp_salary = 100001} ,
                new employee() { emp_id= 201 , emp_name ="ccc" , emp_gender = "F" , emp_deptid=20 , emp_salary = 100002} ,
                new employee() { emp_id= 202 , emp_name ="ddd" , emp_gender = "M" , emp_deptid=20 , emp_salary = 100003} ,
                new employee() { emp_id= 103 , emp_name ="eee" , emp_gender = "M" , emp_deptid=10 , emp_salary = 100004} ,
                new employee() { emp_id= 203 , emp_name ="fff" , emp_gender = "F" , emp_deptid=20 , emp_salary = 100005} ,
                new employee() { emp_id= 104 , emp_name ="ggg" , emp_gender = "F" , emp_deptid=10 , emp_salary = 100006} ,
                new employee() { emp_id= 105 , emp_name ="hhh" , emp_gender = "M" , emp_deptid=10 , emp_salary = 100007}
            };

            var res = (from e in emp select e.emp_id).Count();
            var maxsal = (from e in emp select e.emp_salary).Max();
            var minsal = (from e in emp select e.emp_salary).Min();
            Console.WriteLine("total number of emplyess {0}" , res);
            Console.WriteLine("maximum salary is {0} " , maxsal );
            Console.WriteLine("minimum salary is {0} ", minsal);



            Console.ReadKey();
        }
    }
}
