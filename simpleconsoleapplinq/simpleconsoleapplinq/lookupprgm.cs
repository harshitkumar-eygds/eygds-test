//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace simpleconsoleapplinq
//{
//    class Employee 
//    {
//        public int id { get; set; }
//        public string Name { get; set; }
//        public string Department { get; set; }
//        public string City { get; set; }
//    }
//    class lookupprg
//    {
//        static void Main(string[] args)
//        {
//            List<Employee> objEmployee = new List<Employee>() 
//            {
//                new Employee() {id=1, Name = "Rahul" , Department="Sales" , City ="Ranchi"},
//                new Employee() { id=2,Name = "Sahil" , Department="Customer" , City ="Indore"},
//                new Employee() { id=3,Name = "Shilpa" , Department="Testing" , City ="Bhopal"},
//                new Employee() { id=4,Name = "Mohit" , Department="Sales" , City ="Chennai"},
//                new Employee() { id=5,Name = "Rohan" , Department="Operations" , City ="Kochi"},
//                new Employee() { id=6,Name = "Preeti" , Department="IT" , City ="Mumbai"},
//                new Employee() { id=7, Name = "Anjali" , Department="IT" , City ="Patna"},
//                new Employee() { id=8, Name = "Rohit" , Department="Development" , City ="Delhi"}
//            };

//            var Emp = objEmployee.ToLookup(x => x.Department);
            

//            Console.WriteLine("Grouping Employees by Department");
//            Console.WriteLine("--------------------------------");
//            foreach (var x in Emp) 
//            {
//                Console.WriteLine(x.Key);

//                //lookup emplooyee by department
//                foreach (var item in Emp[x.Key]) 
//                {
//                    Console.WriteLine( item.Name + " : " + item.Department + " : " + item.City);
//                }
//                Console.WriteLine();
//            }



//            List<Employee> objEmployee2 = new List<Employee>()
//            {
//                new Employee() {id=1, Name = "Rahul" , Department="Sales" , City ="Ranchi"},
//                new Employee() { id=2,Name = "Sahil" , Department="Customer" , City ="Indore"},
//                new Employee() { id=3,Name = "Shilpa" , Department="Testing" , City ="Bhopal"},
//                new Employee() { id=4,Name = "Mohit" , Department="Sales" , City ="Chennai"},
//                new Employee() { id=5,Name = "Rohan" , Department="Operations" , City ="Kochi"},
//                new Employee() { id=6,Name = "Preeti" , Department="IT" , City ="Mumbai"},
//                new Employee() { id=7, Name = "Anjali" , Department="IT" , City ="Patna"},
//                new Employee() { id=8, Name = "Rohit" , Department="Development" , City ="Delhi"}
//            };

//            var dict = objEmployee2.ToDictionary(x=>x.id , x=> x.Name);

//            foreach (var i in dict) 
//            {
//                Console.WriteLine(i.Key + " " + i.Value);
//            }



//            Console.ReadKey();
//        }
//    }
//}
