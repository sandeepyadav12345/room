using EmployeeManagement.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Models;

namespace EmployeeManagement.Repository.Implementation
{
    public class sqlVacancyRepository:IVacancyRepository
    {

        private readonly EmployeeDbContext _context;

        // public List<Employee> _employeeList;

        // private readonly EmployeeDbContext context;


        public sqlVacancyRepository(EmployeeDbContext context)
        {
            this._context = context;
        }

        // public EmployeeDbContext context { get; }

        public Vacancy Add(Vacancy vacancy)
        {
            _context.Vacancy.Add(vacancy);
            _context.SaveChanges();
            return vacancy;
        }
        public Vacancy Edit(Vacancy vacancy)
        {
            _context.Vacancy.Add(vacancy);
            //  _context.Employee.Attach(employee);
            _context.Entry(vacancy).State = EntityState.Modified;//this is for modiying/update existing entry
            _context.SaveChanges();

            //  _context.Entry(employee).State = EntityState.Modified;
            //  _context.SaveChanges();

            return vacancy;
        }
        public Vacancy GetVacancy(int VacancyId)
        {
            return _context.Vacancy.Find(VacancyId);
        }
        public Vacancy DeleteData(int VacancyId)
        {
            Vacancy emp = _context.Vacancy.Find(VacancyId);
            if (emp != null)
            {
                _context.Vacancy.Remove(emp);
                _context.SaveChanges();
            }
            return emp;
        }
        public IEnumerable<Vacancy> GetAllVacancy()
        {
            return _context.Vacancy;
        }
    }
}
