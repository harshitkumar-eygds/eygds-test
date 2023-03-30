using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using ASP.netCOREWEBAPI.Models;
using ASP.netCOREWEBAPI.Repository;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace ASP.netCOREWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : Controller
    {
        
        private readonly IDepartmentRepository _department;

        public DepartmentController( IDepartmentRepository department)
        {
            
            _department = department ?? throw new ArgumentException(nameof(department));
        }

        [HttpGet]
        [Route("GetDepartment")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _department.GetDepartment());
        }

        [HttpGet]
        [Route("GetDepartmentByID/{Id}")]
        public async Task<IActionResult> GetDepByID(int Id)
        {
            return Ok(await _department.GetDepartmentByID(Id));
        }

        [HttpPost]
        [Route("AddDepartment")]
        public async Task<IActionResult> Post(Department dep)
        {
            var result = await _department.InsertDepartment(dep);
            if (result.DepartmentId == 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something went wrong");
            }
            return Ok("Added Successfullt");
        }

        [HttpPut]
        [Route("UpdateDepartment")]
        public async Task<IActionResult> Put(Department dep)
        {
            await _department.UpdateDepartment(dep);
            return Ok("Updated Successfully");
        }

        [HttpDelete]
        [Route("DeleteDepartment")]
        public JsonResult Delete(int id)
        {
            var result = _department.DeleteDepartment(id);
            return new JsonResult("Deleted Successfully");
        }

        
    }
}
