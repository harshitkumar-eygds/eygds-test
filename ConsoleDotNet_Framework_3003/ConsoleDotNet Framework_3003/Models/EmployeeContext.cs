using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDotNet_Framework_3003.Models
{
    public class EmployeeContext :DbContext
    {
        public EmployeeContext() : base("MyDbConn") { }
        public DbSet<Employee> Employees { get; set; }
    }

    public class Employee 
    {
        [Key]
        public int EmployeeID { get; set; }
        public string EmpName { get; set; }
        public int DeptID { get; set; }

        public string roles { get; set; }
    }
}
