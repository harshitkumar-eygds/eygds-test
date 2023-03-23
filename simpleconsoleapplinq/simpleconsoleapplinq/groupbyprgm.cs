//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace simpleconsoleapplinq
//{
//    class student 
//    {
//        public int id { set; get; }
//        public int age { set; get; }
//        public string name { set; get; }
//    }
//    class groupbyprgm
//    {
//        static void Main(string[] args)
//        {
//            IList<student> studentlist = new List<student>()
//            {
//                new student () { id =1 , age = 22 , name = "Harshit1"},
//                new student () { id =2 , age = 22 , name = "Harshit2"},
//                new student () { id =3 , age = 22 , name = "Harshit3"},
//                new student () { id =4 , age = 28 , name = "Harshit4"},
//                new student () { id =5 , age = 19 , name = "Harshit5"}
//            };

//            var groupresult = from s in studentlist
//                              group s by s.age;

//            foreach (var i in groupresult) 
//            {
//                Console.WriteLine("Age group : {0}" , i.Key);

//                foreach (student s in i) 
//                {
//                    Console.WriteLine( "Student name : {0}",s.name );
//                }
//            }

//            var groupresult2 = studentlist.GroupBy(s => s.age);

//            foreach (var i in groupresult2)
//            {
//                Console.WriteLine("Age group : {0}", i.Key);

//                foreach (student s in i)
//                {
//                    Console.WriteLine("Student name : {0}", s.name);
//                }
//            }


//            Console.ReadKey();
//        }

//    }
//}
