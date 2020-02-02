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
    public class sqlEmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _context;

        // public List<Employee> _employeeList;

        // private readonly EmployeeDbContext context;


        public sqlEmployeeRepository(EmployeeDbContext context)
        {
            this._context = context;
        }

       // public EmployeeDbContext context { get; }

        public Employee Add(Employee employee)
        {
            _context.Employee.Add(employee);
            _context.SaveChanges();
            return employee;
        }
        public Employee Edit(Employee employee)
        {
            _context.Employee.Add(employee);
          //  _context.Employee.Attach(employee);
            _context.Entry(employee).State = EntityState.Modified;//this is for modiying/update existing entry
            _context.SaveChanges();

          //  _context.Entry(employee).State = EntityState.Modified;
          //  _context.SaveChanges();
           
            return employee;
        }
        public Employee GetEmployee(int Id)
        {
            return _context.Employee.Find(Id);
        }
        public Employee DeleteData(int Id)
        {
            Employee emp = _context.Employee.Find(Id);
            if (emp != null)
            {
                _context.Employee.Remove(emp);
                _context.SaveChanges();
            }
            return emp;
        }
        public IEnumerable<Employee> GetAllEmployee()
        {
            return _context.Employee;
        }


    }
}

