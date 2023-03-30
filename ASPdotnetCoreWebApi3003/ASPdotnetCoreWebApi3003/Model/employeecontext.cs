using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ASPdotnetCoreWebApi3003.Model
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

    }

    public class Employee 
    {
        public int EmployeeID { get; set; }
        public string EmpName { get; set; }
    }
}
