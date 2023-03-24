using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleconsoleapplinq
{
    class employee1 
    {
        public int id { get; set; }
        public string name { get; set; }
        public string dept { get; set; }
    }

    class employee2
    {
        public int id { get; set; }
        public int salary { get; set; }
        public string city { get; set; }
    }
    class joinprgm
    {
        static void Main(string[] args)
        {
            IList<employee1> emp1 = new List<employee1>() 
            {
                new employee1 () { id = 1 , dept = "Developer" , name = "Harshit1"},
                new employee1 () { id = 2 , dept = "Testing" , name = "Harshit2"},
                new employee1 () { id = 3 , dept = "Designing" , name = "Harshit3"},
                new employee1 () { id = 4 , dept = "Sales" , name = "Harshit4"},
                new employee1 () { id = 5 , dept = "Management" , name = "Harshit5"},
                new employee1 () { id = 6 , dept = "HR" , name = "Harshit6"},
                new employee1 () { id = 7 , dept = "Payroll" , name = "Harshit7"},
                new employee1 () { id = 8 , dept = "HR" , name = "Harshit8"},
                new employee1 () { id = 9 , dept = "HR" , name = "Harshit9"},
                new employee1 () { id = 10 , dept = "Payroll" , name = "Harshit10"}
            };

            IList<employee2> emp2 = new List<employee2>()
            {
                new employee2 () { id = 1 , salary = 120000 , city = "Delhi1"},
                new employee2 () { id = 2 , salary = 230000 , city = "Delhi2"},
                new employee2 () { id = 3 , salary = 340000 , city = "Delhi3"},
                new employee2 () { id = 4 , salary = 450000 , city = "Delhi4"},
                new employee2 () { id = 5 , salary = 650000 , city = "Delhi5"},
                new employee2 () { id = 6 , salary = 760000 , city = "Delhi6"},
                new employee2 () { id = 7 , salary = 870000 , city = "Delhi7"}
            };

            Console.WriteLine("inner join/join");
            //join using query
            var res = from e1 in emp1
                      join e2 in emp2
                      on e1.id equals e2.id
                      select new
                      {
                          Emp_name = e1.name,
                          Emp_Salary = e2.salary
                      };


            //display
            foreach (var i in res) 
            {
                Console.WriteLine(" Name : " + i.Emp_name + " Salary : " + i.Emp_Salary);
            }

            var res2 = emp1.Join(emp2,
                                e1 => e1.id,
                                e2 => e2.id,
                                (e1, e2) => new 
                                {
                                    EmployeeName = e1.name,
                                    EmployeeSalary = e2.salary
                                }
                                );
            //diplay

            Console.WriteLine("Using lamda expression");
            foreach (var i in res2)
            {
                Console.WriteLine(" Name : " + i.EmployeeName + " Salary : " + i.EmployeeSalary);
            }

            Console.WriteLine();
            Console.WriteLine("Left join");
            Console.WriteLine();

            var res3 = from e1 in emp1
                       join e2 in emp2
                       on e1.id equals e2.id into empdept
                       from i in empdept.DefaultIfEmpty()
                       select new
                       {
                           EmployeeName = e1.name,
                           DepartmentName = i == null ? "No City" : i.city
                       };

            foreach (var i in res3) 
            {
                Console.WriteLine("Name : " + i.EmployeeName + " city: " + i.DepartmentName);
            }

            //cross join
            Console.WriteLine();
            Console.WriteLine("Cross Join");
            Console.WriteLine();
            var res4 = from e1 in emp1
                       from e2 in emp2
                       select new
                       {
                           EmployeName = e1.name,
                           City = e2.city
                       };

            foreach (var i in res4) 
            {
                Console.WriteLine("Name : {0} City: {1}" , i.EmployeName, i.City);
            }

            Console.WriteLine( );
            Console.WriteLine();

            string[] num1 = { "india" , "China" , "UK" , "USA" };
            string[] num2 = { "uk" , "USA" , "Australia" };

            var result1 = num1.Union(num2);
            Console.WriteLine("union");
            foreach (var i in result1) 
            {
                Console.WriteLine(i);
            }


            Console.WriteLine();
            Console.WriteLine();

            var result2 = num1.Intersect(num2);
            Console.WriteLine("Intersect");
            foreach (var i in result2)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine();
            Console.WriteLine();


            var result3 = num1.Distinct();
            Console.WriteLine("Distinct");
            foreach (var i in result3)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine();
            Console.WriteLine();


            var result4 = num1.Except(num2);
            Console.WriteLine("Except");
            foreach (var i in result4)
            {
                Console.WriteLine(i);
            }



        }
    }
}
