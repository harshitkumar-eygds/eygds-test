using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newconsoleappentityframework
{
    class Program
    {
        static void Main(string[] args)
        {
            mydbContext dbobj = new mydbContext();

            Employee emp = new Employee()
            {
                id = 1, name="Harshit" , deptid = "A122" , gender = 'M'
            };
            dbobj.Employees.Add(emp);

            dbobj.SaveChanges();
        }
    }
}
