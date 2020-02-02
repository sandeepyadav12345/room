using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Repository.Interface
{
  public  interface IDepartmentRepository
    {

        Department GetDepartment(int id);
        IEnumerable<Department> GetAllDepartment();
        Department Add(Department department);
        Department DeleteData(int id);
        Department Edit(Department department);
    }
}
