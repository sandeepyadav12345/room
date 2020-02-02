using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace EmployeeManagement.Models
{
    public class EmployeeDbContext: IdentityDbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {

        }
       
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Leave> Leave { get; set; }
        public DbSet<Vacancy> Vacancy { get; set; }
        public DbSet<Salary> Salary { get; set; }
        public DbSet<Designation> Designation { get; set; }
        // public DbSet<Admin> Admin { get; set; }

        

    }
}
