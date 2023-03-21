//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Collections;
//namespace simpleconsoleapplinq
//{
//    class employee 
//    {
//        public int emp_id { get; set; }
//        public string emp_name { get; set; }
//        public int emp_deptid { get; set; }
//        public string emp_gender { get; set; }
//        public int emp_salary { get; set; }
//    }

//    class student 
//    {
//        public int stud_id { get; set; }
//        public string stud_name { get; set; }
//        public int std_id { get; set; }
//    }
//    class standard
//    {
//        public int std_id { get; set; }
//        public string std_name { get; set; }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Console.WriteLine("Hello World!");

//            //string[] name = { "aa", "bb", "cc", "dd", "ee" };

//            //for (int i = 0; i < 5; i++) 
//            //{
//            //    Console.WriteLine(name[i]);
//            //}

//            //string[] name = { "aa", "bb", "cc", "dd", "ee" };

//            //Console.WriteLine("Names starts with a");
//            //var quer1 = from i in name
//            //            where i.StartsWith("a")
//            //            select i;
//            //foreach (var item in quer1) 
//            //{
//            //    Console.WriteLine(item);
//            //}

//            //Console.WriteLine("Names contains a");
//            //var quer2 = from i in name
//            //            where i.Contains("a")
//            //            select i;
//            //foreach (var item in quer2)
//            //{
//            //    Console.WriteLine(item);
//            //}

//            //var quer3 = from i in name
//            //            select i;
//            //foreach (var item in quer3)
//            //{
//            //    Console.WriteLine(item);
//            //}

//            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
//            //var query1 = from i in arr
//            //             where i >4 && i <8 
//            //             select i;
//            //Console.WriteLine("List of numbers");
//            //foreach (var item in query1) 
//            //{
//            //    Console.WriteLine(item);

//            //}

//            //Console.WriteLine("min" + arr.Min());
//            //Console.WriteLine("max" + arr.Max());
//            //Console.WriteLine("avg" + arr.Average());
//            //Console.WriteLine("count" + arr.Count());

//            //List<employee> emp = new List<employee>()
//            //{
//            //    new employee() { emp_id= 101 , emp_name ="aaa" , emp_gender = "M" , emp_deptid=10 , emp_salary = 100000} ,
//            //    new employee() { emp_id= 102 , emp_name ="bbb" , emp_gender = "F" , emp_deptid=10 , emp_salary = 100001} ,
//            //    new employee() { emp_id= 201 , emp_name ="ccc" , emp_gender = "F" , emp_deptid=20 , emp_salary = 100002} ,
//            //    new employee() { emp_id= 202 , emp_name ="ddd" , emp_gender = "M" , emp_deptid=20 , emp_salary = 100003} ,
//            //    new employee() { emp_id= 103 , emp_name ="eee" , emp_gender = "M" , emp_deptid=10 , emp_salary = 100004} ,
//            //    new employee() { emp_id= 203 , emp_name ="fff" , emp_gender = "F" , emp_deptid=20 , emp_salary = 100005} ,
//            //    new employee() { emp_id= 104 , emp_name ="ggg" , emp_gender = "F" , emp_deptid=10 , emp_salary = 100006} ,
//            //    new employee() { emp_id= 105 , emp_name ="hhh" , emp_gender = "M" , emp_deptid=10 , emp_salary = 100007}
//            //};

//            //var res = (from e in emp select e.emp_id).Count();
//            //var maxsal = (from e in emp select e.emp_salary).Max();
//            //var minsal = (from e in emp select e.emp_salary).Min();
//            //Console.WriteLine("total number of emplyess {0}" , res);
//            //Console.WriteLine("maximum salary is {0} " , maxsal );
//            //Console.WriteLine("minimum salary is {0} ", minsal);

//            //var query1 = from i in emp select i.emp_gender;
//            //Console.WriteLine("Employee details : ");
//            //foreach (var item in query1) 
//            //{
//            //    Console.WriteLine(item); ;
//            //}

//            //Console.WriteLine("========= Lamda Expression ======");

//            //var selectresult1 = emp.Select(s => new { Name = s.emp_name, Gender = s.emp_gender });

//            //foreach (var item in selectresult1)
//            //{
//            //    Console.WriteLine("Employee name : {0}, Gender is : {1}" , item.Name, item.Gender);
//            //}

//            //Console.WriteLine("========= where lamda expression");

//            //Console.WriteLine("list of names of female employees are : ");

//            //var gen = emp.Where(c => c.emp_gender == "F").Select(s => s.emp_name);

//            //foreach (var item in gen) 
//            //{
//            //    Console.WriteLine(item);
//            //}

//            //int[] num =  { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 11, 21, 234, 34, 456, 543, 23, 57, 8, 3, 23, 567, 234, 436, 7, 88, 654, 787, 34, 678, 44, 56, 78, 90, 09, 87, 65, 43, 211, 112, 13, 14, 15, 254, 36, 853 };
//            //var result = num.Where(a => (a >= 15 && a <= 35) || (a<=10 && a>=5));
//            //Console.WriteLine("number between 15 and 35");
//            //;
//            //foreach (var i in result) 
//            //{
//            //    Console.WriteLine(i);
//            //}

//            //employee[] emp = 
//            //{
//            //    new employee() { emp_id= 101 , emp_name ="aaa" , emp_gender = "M" , emp_deptid=10 , emp_salary = 100000} ,
//            //    new employee() { emp_id= 102 , emp_name ="bbb" , emp_gender = "F" , emp_deptid=10 , emp_salary = 100001} ,
//            //    new employee() { emp_id= 201 , emp_name ="ccc" , emp_gender = "F" , emp_deptid=20 , emp_salary = 100002} ,
//            //    new employee() { emp_id= 202 , emp_name ="ddd" , emp_gender = "M" , emp_deptid=20 , emp_salary = 100003} ,
//            //    new employee() { emp_id= 103 , emp_name ="eee" , emp_gender = "M" , emp_deptid=10 , emp_salary = 100004} ,
//            //    new employee() { emp_id= 203 , emp_name ="fff" , emp_gender = "F" , emp_deptid=20 , emp_salary = 100005} ,
//            //    new employee() { emp_id= 104 , emp_name ="ggg" , emp_gender = "F" , emp_deptid=10 , emp_salary = 100006} ,
//            //    new employee() { emp_id= 105 , emp_name ="hhh" , emp_gender = "M" , emp_deptid=10 , emp_salary = 100007}
//            //};

//            //var emp_result = emp.Where(a => a.emp_gender == "M");
//            //Console.WriteLine("all male employees are : ");
//            //foreach (var i in emp_result) 
//            //{
//            //    Console.WriteLine("{0} : {1} ", i.emp_id , i.emp_name);
//            //}

//            //int[] num2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 11, 21, 234, 34, 456, 543, 23, 57, 8, 3, 23, 567, 234, 436, 7, 88, 654, 787, 34, 678, 44, 56, 78, 90, 09, 87, 65, 43, 211, 112, 13, 14, 15, 254, 36, 853 };
//            //int[] num3 = { 33, 2, 3, 4, 5, 6, 36, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
//            ////n - number i - indexes
//            //var result1 = num3.Where((n,i) => n%3 == 0 && i >= 6);
//            //Console.WriteLine("divisible by 3 and greater then 6");
//            //;
//            //foreach (var i in result1)
//            //{
//            //    Console.WriteLine(i);
//            //}

//            //string[] words = { "falcon", "oak", "sky", "cloud", "rain", "tree", "master", "school" };
//            //Console.WriteLine("Element at : " + words.ElementAt(2));
//            //Console.WriteLine("Words.first() : " + words.First());
//            //Console.WriteLine("Words.Last() : " + words.Last());

//            //Console.WriteLine("words.First(word => word.Length == 3) : " + words.First(word => word.Length == 3));
//            //Console.WriteLine("words.Last(word => word.Length == 3) : " + words.Last(word => word.Length == 3));

//            //int[] vals = { 1, 2, 3 };

//            //var vals1 = vals.Append(4).Prepend(0);
//            ////vals1 = vals1.Prepend(0);

//            //Console.WriteLine(string.Join(",",vals1));
//            //object vals2 = vals.Append(2);

//            //Console.WriteLine("powered");
//            //var powered = num3.Select(e => Math.Pow(e, 2));
//            //Console.WriteLine(string.Join(',',powered));

//            //Console.WriteLine("word length ");
//            //var wordlen = words.Select(e => e.Length);
//            //Console.WriteLine(string.Join(',',wordlen));

//            //Console.WriteLine();
//            //Console.WriteLine(); 
//            //Console.WriteLine("=============== oftype ===============");
//            //Console.WriteLine();
//            //Console.WriteLine();
//            //IList mixedList = new ArrayList();
//            //mixedList.Add(0);
//            //mixedList.Add("abc");
//            //mixedList.Add("bbhg");
//            //mixedList.Add("rahul");
//            //mixedList.Add("harshit");
//            //mixedList.Add('c');
//            //mixedList.Add('b');
//            //mixedList.Add('a');
//            //mixedList.Add(9.9f);
//            //mixedList.Add(9.98f);
//            //mixedList.Add(9.0987768676);
//            //mixedList.Add(9.99898665);
//            //mixedList.Add(29);
//            //mixedList.Add(93);
//            //mixedList.Add(943);

//            //var stringresult = from s in mixedList.OfType<string>() select s;
//            //var charresult = from s in mixedList.OfType<char>() select s;
//            //var intresult = from s in mixedList.OfType<int>() select s;
//            //var floatresult = from s in mixedList.OfType<float>() select s;
//            //var doubleresult = from s in mixedList.OfType<double>() select s;
//            //Console.WriteLine("printing string result using for each loop");
//            //foreach (var i in stringresult) 
//            //{
//            //    Console.WriteLine(i);
//            //}
//            //Console.WriteLine("printing string result using string join");
//            //Console.WriteLine(String.Join(",",stringresult));

//            //Console.WriteLine("printing char result using for each loop");
//            //foreach (var i in charresult)
//            //{
//            //    Console.WriteLine(i);
//            //}
//            //Console.WriteLine("printing char result using string join");
//            //Console.WriteLine(String.Join(",", charresult));

//            //Console.WriteLine("printing int result using for each loop");
//            //foreach (var i in intresult)
//            //{
//            //    Console.WriteLine(i);
//            //}
//            //Console.WriteLine("printing int result using string join");
//            //Console.WriteLine(String.Join(",", intresult));

//            //Console.WriteLine("printing float result using for each loop");

//            //foreach (var i in floatresult)
//            //{
//            //    Console.WriteLine(i);
//            //}
//            //Console.WriteLine("printing float result using string join");
//            //Console.WriteLine(String.Join(",", floatresult));

//            //Console.WriteLine("printing double result using for each loop");

//            //foreach (var i in doubleresult)
//            //{
//            //    Console.WriteLine(i);
//            //}
//            //Console.WriteLine("printing double result using string join");
//            //Console.WriteLine(String.Join(",", doubleresult));


//            // int[][] jagarray =
//            //     {
//            //      new[] { 1,2,3},
//            //      new[] { 4,5,6},
//            //      new[] { 44,5,6,22,3,1,8}
//            // };

//            // var resl = jagarray.SelectMany(a => a).OrderBy(x => x);
//            // var res2 = jagarray.SelectMany(a => a).OrderBy(x => -x);
//            // var res3 = jagarray.SelectMany(a => a).OrderByDescending(x => x);
//            //// var resl2 = jagarray.Select(a => a).OrderBy(x => x);
//            // Console.WriteLine(string.Join(",",resl));
//            // Console.WriteLine(string.Join(",", res2));
//            // Console.WriteLine(string.Join(",", res3));
//            // //foreach (var i in resl2) 
//            // //{
//            // //    Console.WriteLine(i);
//            // //}
//            // //Console.WriteLine(string.Join(",", resl2));

//            IList<student> student_list = new List<student>() {
//            new student() { std_id = 1 , stud_name = "harshit1" , stud_id = 1},
//            new student() { std_id = 1 , stud_name = "harshit2" , stud_id = 2},
//            new student() { std_id = 1 , stud_name = "harshit3" , stud_id = 3},
//            new student() { std_id = 1 , stud_name = "harshit4" , stud_id = 4},
//            new student() { std_id = 1 , stud_name = "harshit5" , stud_id = 5},
//            new student() { std_id = 3 , stud_name = "harshit6" , stud_id = 6}
//            };

//            IList<standard> standard_list = new List<standard>() {
//            new standard() { std_id = 1 , std_name = "harshit1" },
//            new standard() { std_id = 1 , std_name = "harshit2" },
//            new standard() { std_id = 1 , std_name = "harshit3" }
//            };

//            var groupjoin = standard_list.GroupJoin
//                (
//                    std => std.std_id,
//                    s => s.std_id,
//                    (std, studentsGroup) => new
//                    {
//                        Students = studentsGroup,
//                        StandrdFullName = std.StandardName
//                    }
//                );

//            foreach (var item in groupjoin) 
//            {
//                Console.WriteLine(item.StandrdFullName);

//                foreach(var stud in item.Students)
//                    Console.WriteLine(stud.StudentName);
//            }




//            Console.ReadKey();

//        }
//    }
//}
