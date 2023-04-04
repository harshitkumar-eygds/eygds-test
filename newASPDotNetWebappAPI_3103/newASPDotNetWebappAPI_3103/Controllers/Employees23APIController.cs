using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using newASPDotNetWebappAPI_3103.Repository;
using newASPDotNetWebappAPI_3103.Models;

namespace newASPDotNetWebappAPI_3103.Controllers
{
    public class Employees23APIController : ApiController
    {
        private readonly IEmployees23Repository _iEmployees23Repository = new Employees23Repository();
        [HttpGet]
        [Route("api/Employees23/Get")]
        public async Task<IEnumerable<Employees23>> Get()  
        {
            return await _iEmployees23Repository.GetEmployees23();
        }

        [HttpPost]
        [Route("api/Employees23/Create")]
        public async Task CreateAsync([FromBody] Employees23 employees23)
        {
            if (ModelState.IsValid) 
            {
                await _iEmployees23Repository.Add(employees23);
            }
        }

        [HttpPut]
        [Route("api/Employees23/Details/{id}")]
        public async Task<Employees23> Details(string id) 
        {
            var result = await _iEmployees23Repository.GetEmployees23(id);
            return result;
        }

        [HttpPut]
        [Route("api/Employees23/Edit")]
        public async Task EditAsync([FromBody] Employees23 employees23)
        {
            if (ModelState.IsValid) 
            {
                await _iEmployees23Repository.Update(employees23);
            }
        }

        [HttpDelete]
        [Route("api/Employees/Delete/{id}")]
        public async Task DeleteConfirmedAsync(string id) 
        {
            await _iEmployees23Repository.Delete(id);
        }
    }
}
