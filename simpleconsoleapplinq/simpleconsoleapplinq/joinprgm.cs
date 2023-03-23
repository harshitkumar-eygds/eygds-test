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
                new employee1 () { id = 2 , dept = "Testing" , name = "Harshit1"},
                new employee1 () { id = 3 , dept = "Designing" , name = "Harshit1"},
                new employee1 () { id = 4 , dept = "Sales" , name = "Harshit1"},
                new employee1 () { id = 5 , dept = "Management" , name = "Harshit1"},
                new employee1 () { id = 6 , dept = "HR" , name = "Harshit1"},
                new employee1 () { id = 7 , dept = "Payroll" , name = "Harshit1"}
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

        }
    }
}
