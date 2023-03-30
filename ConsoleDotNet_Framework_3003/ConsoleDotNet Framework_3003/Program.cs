using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleDotNet_Framework_3003.Models;

namespace ConsoleDotNet_Framework_3003
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EmployeeContext()) 
            {
                context.Employees.Add(new Employee { EmployeeID = 1, EmpName = "Rahul" });
                context.Employees.Add(new Employee { EmployeeID = 2, EmpName = "Mohan" });
                context.Employees.Add(new Employee { EmployeeID = 3, EmpName = "Sohan" });
                context.Employees.Add(new Employee { EmployeeID = 4, EmpName = "Rohan" });

                context.SaveChanges();

                foreach (var emp in context.Employees) 
                {
                    Console.WriteLine("Employee ID : " + emp.EmployeeID);
                    Console.WriteLine("Employee Name : " + emp.EmpName);
                }
            }

            Console.ReadKey();
        }
    }
}
