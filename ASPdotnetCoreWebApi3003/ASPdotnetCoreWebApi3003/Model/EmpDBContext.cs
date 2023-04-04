using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ASPdotnetCoreWebApi3003.Model
{
    public class EmpDBContext :DbContext
    {
        public EmpDBContext(DbContextOptions options) : base(options) { }

        public DbSet<Employee2> Employees2 { get; set; }
    }
}
