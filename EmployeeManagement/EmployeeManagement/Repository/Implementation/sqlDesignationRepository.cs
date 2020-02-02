using EmployeeManagement.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Models;

namespace EmployeeManagement.Repository.Implementation
{
    public class sqlDesignationRepository:IDesignationRepository
    {

        private readonly EmployeeDbContext _context;

        // public List<Employee> _employeeList;

        // private readonly EmployeeDbContext context;


        public sqlDesignationRepository(EmployeeDbContext context)
        {
            this._context = context;
        }

        // public EmployeeDbContext context { get; }

        public Designation Add(Designation designation)
        {
            _context.Designation.Add(designation);
            _context.SaveChanges();
            return designation;
        }
        public Designation Edit(Designation designation)
        {
            _context.Designation.Add(designation);
            //  _context.Employee.Attach(employee);
            _context.Entry(designation).State = EntityState.Modified;//this is for modiying/update existing entry
            _context.SaveChanges();

            //  _context.Entry(employee).State = EntityState.Modified;
            //  _context.SaveChanges();

            return designation;
        }
        public Designation GetDesignation(int DesignationId)
        {
            return _context.Designation.Find(DesignationId);
        }
        public Designation DeleteData(int DesignationId)
        {
            Designation emp = _context.Designation.Find(DesignationId);
            if (emp != null)
            {
                _context.Designation.Remove(emp);
                _context.SaveChanges();
            }
            return emp;
        }
        public IEnumerable<Designation> GetAllDesignation()
        {
            return _context.Designation;
        }
    }
}
