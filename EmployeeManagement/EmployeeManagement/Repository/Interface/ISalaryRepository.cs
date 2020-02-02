using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Repository.Interface
{
  public  interface ISalaryRepository
    {
        Salary GetSalary(int id);
        IEnumerable<Salary> GetAllSalary();
        Salary Add(Salary salary);
        Salary DeleteData(int id);
        Salary Edit(Salary salary);
    }
}
