using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace crudwithangular.Controllers
{
    [RoutePrefix("Api/Employee")]
    public class EmployeeAPIController : ApiController
    {
        EYdatabaseEntities objEntity = new EYdatabaseEntities();
        [HttpGet]
        [Route("AllEmployeeDetails")]
        public IQueryable<EmployeeDetail> GetEmployees()
        {
            try
            {
                return objEntity.EmployeeDetails;
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        [Route("GetEmployeeDetailsById/{employeeID}")]
        public IHttpActionResult GetEmployeeById(string employeeId)
        {
            EmployeeDetail objEmp = new EmployeeDetail();
            int ID = Convert.ToInt32(employeeId);
            try
            {
                objEmp = objEntity.EmployeeDetails.Find(ID);
                if (objEmp == null)
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(objEmp);
        }

        [HttpPost]
        [Route("InsertEmployeeDetails")]
        public IHttpActionResult PostEmployee(EmployeeDetail data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                objEntity.EmployeeDetails.Add(data);
                objEntity.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(data);
        }

        [HttpPost]
        [Route("UpdateEmployeeDetails")]
        public IHttpActionResult PutEmployeeMaster(EmployeeDetail employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                EmployeeDetail objEmp = new EmployeeDetail();
                objEmp = objEntity.EmployeeDetails.Find(employee.empid);
                if (objEmp != null)
                {
                    objEmp.empname = employee.empname;
                    objEmp.address = employee.address;
                    objEmp.emailid = employee.emailid;
                    objEmp.dateofbirth = employee.dateofbirth;
                    objEmp.gender = employee.gender;
                    objEmp.pincode = employee.pincode;
                }
                int i = this.objEntity.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(employee);
        }

        [HttpDelete]
        [Route("DeleteEmployeeDetails")]

        public IHttpActionResult DeleteEmployeeDelete(int id) 
        {
            EmployeeDetail employee = objEntity.EmployeeDetails.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            objEntity.EmployeeDetails.Remove(employee);
            objEntity.SaveChanges();

            return Ok(employee);
        }
    }
}
