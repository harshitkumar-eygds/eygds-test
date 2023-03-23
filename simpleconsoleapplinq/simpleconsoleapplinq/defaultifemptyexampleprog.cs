//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace simpleconsoleapplinq
//{
//    class employee 
//    {
//        public string empid { get; set; }
//        public string empname { get; set; }
//    }
//    class worker
//    {
//        public string workerid { get; set; }
//        public string city { get; set; }
//    }
//    class defaultifemptyexampleprog
//    {
//        static void Main(string[] args)
//        {
//            List<employee> es = new List<employee>
//            {
//                new employee () { empid ="IN001" , empname ="Harshit1"},
//                new employee () { empid ="IN002" , empname ="Harshit2"},
//                new employee () { empid ="IN003" , empname ="Harshit3"},
//                new employee () { empid ="IN004" , empname ="Harshit4"}
//            };

//            List<worker> ws = new List<worker>
//            {
//                new worker () { workerid ="IN001" , city ="Srinagar1"},
//                new worker () { workerid ="IN002" , city ="Srinagar2"},
//                new worker () { workerid ="IN006" , city ="Srinagar6"},
//                new worker () { workerid ="IN007" , city ="Srinagar7"}
//            };

//            var result =
//                from emp in es
//                join work in ws
//                on emp.empid equals work.workerid
//                into resultempworker

//                from output in resultempworker.DefaultIfEmpty()
//                select new
//                    {
//                        EmployeeName = emp.empname,
//                        city = output != null ? output.city : null
//                    };


//            Console.WriteLine(
//                String.Join("\n", 
//                result.Select(emp => " Employee name : " + emp.EmployeeName 
//                + " City : " + emp.city).ToArray<String>()));


//            Console.ReadKey();
//        }
//    }
//}
