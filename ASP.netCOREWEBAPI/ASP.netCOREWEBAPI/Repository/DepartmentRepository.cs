﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.netCOREWEBAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.netCOREWEBAPI.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly APIDbContext _appDBContext;

        public DepartmentRepository(APIDbContext context)
        {
            _appDBContext = context ?? throw new ArgumentNullException(nameof(context));
        }


        public async Task<IEnumerable<Department>> GetDepartment()
        {
            return await _appDBContext.Departments.ToListAsync();
        }

        public async Task<Department> GetDepartmentByID(int ID)
        {
            return await _appDBContext.Departments.FindAsync(ID);
        }

        public async Task<Department> InsertDepartment(Department objDepartment)
        {
            _appDBContext.Departments.Add(objDepartment);
            await _appDBContext.SaveChangesAsync();
            return objDepartment;
        }

        public async Task<Department> UpdateDepartment(Department objDepartment)
        {

            _appDBContext.Entry(objDepartment).State = EntityState.Modified;
            await _appDBContext.SaveChangesAsync();
            return objDepartment;
        }

        public bool DeleteDepartment(int ID)
        {
            bool result = false;
            var dep = _appDBContext.Departments.Find(ID);
            if (dep != null)
            {
                _appDBContext.Entry(dep).State = EntityState.Deleted;
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
