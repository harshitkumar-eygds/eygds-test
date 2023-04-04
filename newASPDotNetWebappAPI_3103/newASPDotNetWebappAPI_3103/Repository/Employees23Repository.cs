using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.SqlServer.Server;
using newASPDotNetWebappAPI_3103.Models;


namespace newASPDotNetWebappAPI_3103.Repository
{
    public class Employees23Repository : IEmployees23Repository
    {
        private readonly SQLDbContext db = new SQLDbContext();
        public async Task Add(Employees23 employees23)
        {
            //employees23.Id = int.Parse(Guid.NewGuid().ToString());
            db.Employees23s.Add(employees23);
            try
            {
                await db.SaveChangesAsync();
            }
            catch 
            {
                throw;
            }
        }

        public async Task Delete(string id)
        {
            try
            {
                Employees23 employees23 = await db.Employees23s.FindAsync(id);
                db.Employees23s.Remove(employees23);
                await db.SaveChangesAsync();
            }
            catch 
            {
                throw;
            }
        }

        public async Task<Employees23> GetEmployees23(string id)
        {
            try
            {
                Employees23 employees23 = await db.Employees23s.FindAsync(id);
                if (employees23 == null)
                    return null;
                return employees23;
            }
            catch 
            {
                throw;
            }
        }

        public async Task<IEnumerable<Employees23>> GetEmployees23()
        {
            try
            {
                var employees = await db.Employees23s.ToListAsync();
                return employees.AsQueryable();
            }
            catch 
            {
                throw; 
            }
        }

        public async Task Update(Employees23 employees23)
        {
            try
            {
                db.Entry(employees23).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
            catch 
            {
                throw;
            }
        }

        private bool EmployeeExists(string id) 
        {
            return db.Employees23s.Count(e => e.Id == id) > 0;
        }
    }
}