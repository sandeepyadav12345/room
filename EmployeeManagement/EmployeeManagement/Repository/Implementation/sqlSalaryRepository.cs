using EmployeeManagement.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Models;

namespace EmployeeManagement.Repository.Implementation
{
    public class sqlSalaryRepository:ISalaryRepository
    {

        private readonly EmployeeDbContext _context;

        // public List<Employee> _employeeList;

        // private readonly EmployeeDbContext context;


        public sqlSalaryRepository(EmployeeDbContext context)
        {
            this._context = context;
        }

        // public EmployeeDbContext context { get; }

        public Salary Add(Salary salary)
        {
            _context.Salary.Add(salary);
            _context.SaveChanges();
            return salary;
        }
        public Salary Edit(Salary salary)
        {
            _context.Salary.Add(salary);
            //  _context.Employee.Attach(employee);
            _context.Entry(salary).State = EntityState.Modified;//this is for modiying/update existing entry
            _context.SaveChanges();

            //  _context.Entry(employee).State = EntityState.Modified;
            //  _context.SaveChanges();

            return salary;
        }
        public Salary GetSalary(int SalaryId)
        {
            return _context.Salary.Find(SalaryId);
        }
        public Salary DeleteData(int SalaryId)
        {
            Salary emp = _context.Salary.Find(SalaryId);
            if (emp != null)
            {
                _context.Salary.Remove(emp);
                _context.SaveChanges();
            }
            return emp;
        }
        public IEnumerable<Salary> GetAllSalary()
        {
            return _context.Salary;
        }
    }
}
