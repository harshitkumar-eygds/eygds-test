using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newconsoleappentityframework
{
    class mydbContext : DbContext
    {
        public mydbContext() : base ("MyDbConn") 
        {
            Database.SetInitializer<mydbContext>(new CreateDatabaseIfNotExists<mydbContext>());


        }

        public DbSet<Employee> Employees { get; set; }
    }
}
