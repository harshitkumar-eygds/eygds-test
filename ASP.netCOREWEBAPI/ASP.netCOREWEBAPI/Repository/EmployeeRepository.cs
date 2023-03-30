using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.netCOREWEBAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.netCOREWEBAPI.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly APIDbContext _appDBContext;

        public EmployeeRepository(APIDbContext context) 
        {
            _appDBContext = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Employee>> GetEmployees() 
        {
            return await _appDBContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployeeByID(int id) 
        {
            return await _appDBContext.Employees.FindAsync(id);
        }

        public async Task<Employee> InsertEmployee(Employee objEmployee) 
        {
            _appDBContext.Employees.Add(objEmployee);
            await _appDBContext.SaveChangesAsync();
            return objEmployee;
        }

        public async Task<Employee> UpdateEmployee(Employee objEmployee) 
        {
            _appDBContext.Entry(objEmployee).State = EntityState.Modified;
            await _appDBContext.SaveChangesAsync();
            return objEmployee;
        }

        public bool DeleteEmployee(int id) 
        {
            bool result = false;
            var emp = _appDBContext.Employees.Find(id);
            if (emp != null)
            {
                _appDBContext.Entry(emp).State = EntityState.Deleted;
                _appDBContext.SaveChanges();
                result = true;
            }
            else 
            {
                result = false;
            }
            return result;
        }
    }
}
