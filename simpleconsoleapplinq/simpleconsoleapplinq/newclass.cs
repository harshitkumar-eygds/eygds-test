//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace simpleconsoleapplinq
//{
//    class student 
//    {
//        public int std_id { get; set; }
//        public string stud_name { get; set; }
//        public int stud_id { get; set; }
//    }
//    class newclass
//    {
//        static void Main(string[] args)
//        {
//            IList<student> student_list = new List<student>()
//        {
//                        new student() { std_id = 1 , stud_name = "harshit1" , stud_id = 1},
//                        new student() { std_id = 1 , stud_name = "harshit2" , stud_id = 2},
//                        new student() { std_id = 1 , stud_name = "harshit3" , stud_id = 3},
//                        new student() { std_id = 1 , stud_name = "harshit4" , stud_id = 4},
//                        new student() { std_id = 1 , stud_name = "harshit5" , stud_id = 5},
//                        new student() { std_id = 3 , stud_name = "harshit6" , stud_id = 6}
//                        };

//            var thenbyresult = student_list.OrderBy(s => s.std_id).ThenBy(s => s.stud_id);

//            var thenbydescresult = student_list.OrderBy(s => s.std_id).ThenByDescending(s => s.stud_id);

//            Console.WriteLine("Thenbyresult");
//            foreach (var i in thenbyresult) 
//            {
//                Console.WriteLine(i.stud_name + " , " + i.std_id );
//            }

//            Console.WriteLine("Thenbydescresult");
//            foreach (var i in thenbydescresult)
//            {
//                Console.WriteLine(i.stud_name + " , " + i.std_id);
//            }

//            IList<string> strList = new List<string>() { "One", "Two", "Three", "Four", "Five" };

//            Console.WriteLine();
//            Console.WriteLine();
//            var newList = strList.Take(2);
//            Console.WriteLine("take example");
//            foreach(var i in newList)
//                Console.WriteLine(i);

//            Console.WriteLine();
//            Console.WriteLine();
//            var newList2 = strList.TakeWhile(s => s.Length>=3);
//            Console.WriteLine("take while example");
//            foreach (var i in newList2)
//                Console.WriteLine(i);


//            Console.WriteLine();
//            Console.WriteLine();
//            var newList3 = strList.Skip(2);
//            Console.WriteLine("skip example");
//            foreach(var str in newList3)
//                Console.WriteLine(str);

//            IList<string> strList2 = new List<string>()
//            {"one" ,  "three" , "two" , "hundred" , "fivehundread" };


//            Console.WriteLine();
//            Console.WriteLine();
//            var newList4 = strList2.SkipWhile(s=>s.Length<4);
//            Console.WriteLine("skip while example");
//            foreach (var str in newList4)
//                Console.WriteLine(str);




//            Console.WriteLine();
//            Console.WriteLine();
//            Console.WriteLine("============== Int ==========");

//            IList<int> intList = new List<int>() {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30 };

//            Console.WriteLine();
//            Console.WriteLine();
//            Console.WriteLine("take example");
//            var newList5 = intList.Take(2);
//            foreach (var i in newList5)
//                Console.WriteLine(i);

//            Console.WriteLine();
//            Console.WriteLine();
//            Console.WriteLine("take while example");
//            var newList6 = intList.TakeWhile(s => s<10);
//            foreach (var i in newList6)
//                Console.WriteLine(i);


//            Console.WriteLine();
//            Console.WriteLine();
//            Console.WriteLine("skip example");
//            var newList7 = intList.Skip(2);
//            foreach (var i in newList7)
//                Console.WriteLine(i);

//            //IList<string> strList2 = new List<string>()
//            //{"one" ,  "three" , "two" , "hundred" , "fivehundread" };


//            Console.WriteLine();
//            Console.WriteLine();
//            Console.WriteLine("skip while example");
//            var newList8 = intList.SkipWhile(s => s<10);
//            foreach (var i in newList8)
//                Console.WriteLine(i);



//            Console.WriteLine();
//            Console.WriteLine();
//            Console.WriteLine("============== Char ==========");

//            IList<int> charList = new List<int>() {'a' , 'e' , 'i' , 'o' , 'u' };

//            Console.WriteLine();
//            Console.WriteLine();
//            Console.WriteLine("take example");
//            var newList9 = charList.Take(2);
//            foreach (var i in newList9)
//                Console.WriteLine(i);

//            Console.WriteLine();
//            Console.WriteLine();
//            Console.WriteLine("take while example");
//            var newList10 = charList.TakeWhile(s => s < 10);
//            foreach (var i in newList10)
//                Console.WriteLine(i);


//            Console.WriteLine();
//            Console.WriteLine();
//            Console.WriteLine("skip example");
//            var newList11 =  charList.Skip(2);
//            foreach (var i in newList11)
//                Console.WriteLine(i);

//            //IList<string> strList2 = new List<string>()
//            //{"one" ,  "three" , "two" , "hundred" , "fivehundread" };


//            Console.WriteLine();
//            Console.WriteLine();
//            Console.WriteLine("skip while example");
//            var newList12 = charList.SkipWhile(s => s < 10);
//            foreach (var i in newList12)
//                Console.WriteLine(i);


//            Console.WriteLine();
//            Console.WriteLine();
//            Console.WriteLine("==== to array =======");

//            List<string> countries = new List<string> { "india" , "usa" , "UK" , "Canada" , "Mexico"};

//            string[] countryarray = countries.ToArray();

//            foreach (var i in countryarray) 
//            {
//                Console.WriteLine(i) ;
//            }

//            Console.WriteLine("contries type : " + countries.GetType().Name);
//            Console.WriteLine("countryarray type : " + countryarray.GetType().Name);




//            Console.ReadKey();

//        }


//    }
//}
