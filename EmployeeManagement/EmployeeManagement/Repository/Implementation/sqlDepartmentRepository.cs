using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
using EmployeeManagement.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Repository.Implementation
{
    public class sqlDepartmentRepository : IDepartmentRepository
    {
        private readonly EmployeeDbContext _context;

        // public List<Employee> _employeeList;

        // private readonly EmployeeDbContext context;


        public sqlDepartmentRepository(EmployeeDbContext context)
        {
            this._context = context;
        }

        // public EmployeeDbContext context { get; }

        public Department Add(Department department)
        {
            _context.Department.Add(department);
            _context.SaveChanges();
            return department;
        }
        public Department Edit(Department department)
        {
            _context.Department.Add(department);
            //  _context.Department.Attach(employee);
            _context.Entry(department).State = EntityState.Modified;//this is for modiying/update existing entry
            _context.SaveChanges();

            //  _context.Entry(employee).State = EntityState.Modified;
            //  _context.SaveChanges();

            return department;
        }
        public Department GetDepartment(int DepartmentId)
        {
            return _context.Department.Find(DepartmentId);
        }
        public Department DeleteData(int DepartmentId)
        {
            Department emp = _context.Department.Find(DepartmentId);
            if (emp != null)
            {
                _context.Department.Remove(emp);
                _context.SaveChanges();
            }
            return emp;
        }
        public IEnumerable<Department> GetAllDepartment()
        {
            return _context.Department;
        }


    }
}

