using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.netCOREWEBAPI.Models;

namespace ASP.netCOREWEBAPI.Repository
{
    public class IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployeeByID(int ID);

        Task<Employee> InsertEmployee(Employee objEmployee);

        Task<Employee> UpdateEmployee(Employee objEmployee);
        bool DeleteEmployee(int ID);
    }
}
