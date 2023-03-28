using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace newconsoleappentityframework
{
    class Employee
    {
        public Employee() { }

        [Key]
        public int id { set; get; }
        public string name { get; set; }
        public string deptid { get; set; }

        public char gender { get; set; }

    }
}
