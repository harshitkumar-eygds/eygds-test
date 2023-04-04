using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace newASPDotNetWebappAPI_3103.Models
{
    public class SQLDbContext : DbContext
    {
        public SQLDbContext() : base("name=SqlConn") { }

        public DbSet<Employees23> Employees23s { get; set; }
    }
}