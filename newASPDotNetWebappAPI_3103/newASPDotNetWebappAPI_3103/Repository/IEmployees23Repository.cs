using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using newASPDotNetWebappAPI_3103.Models;

namespace newASPDotNetWebappAPI_3103.Repository
{
    public interface IEmployees23Repository
    {
        Task Add(Employees23 employees23);
        Task Update(Employees23 employees23);
        Task Delete(string id);
        Task<Employees23> GetEmployees23(string id);
        Task<IEnumerable<Employees23>> GetEmployees23();
    }
}
