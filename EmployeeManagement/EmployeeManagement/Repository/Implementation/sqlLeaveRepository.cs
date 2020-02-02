using EmployeeManagement.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Models;

namespace EmployeeManagement.Repository.Implementation
{
    public class sqlLeaveRepository:ILeaveRepository
    {

        private readonly EmployeeDbContext _context;

        // public List<Employee> _employeeList;

        // private readonly EmployeeDbContext context;


        public sqlLeaveRepository(EmployeeDbContext context)
        {
            this._context = context;
        }

        // public EmployeeDbContext context { get; }

        public Leave Add(Leave leave)
        {
            _context.Leave.Add(leave);
            _context.SaveChanges();
            return leave;
        }
        public Leave Edit(Leave leave)
        {
            _context.Leave.Add(leave);
            //  _context.Employee.Attach(employee);
            _context.Entry(leave).State = EntityState.Modified;//this is for modiying/update existing entry
            _context.SaveChanges();

            //  _context.Entry(employee).State = EntityState.Modified;
            //  _context.SaveChanges();

            return leave;
        }
        public Leave GetLeave(int LeaveId)
        {
            return _context.Leave.Find(LeaveId);
        }
        public Leave DeleteData(int LeaveId)
        {
            Leave emp = _context.Leave.Find(LeaveId);
            if (emp != null)
            {
                _context.Leave.Remove(emp);
                _context.SaveChanges();
            }
            return emp;
        }
        public IEnumerable<Leave> GetAllLeave()
        {
            return _context.Leave;
        }
    }
}
