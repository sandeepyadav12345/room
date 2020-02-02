using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Repository.Interface
{
  public  interface IDesignationRepository
    {
        Designation GetDesignation(int id);
        IEnumerable<Designation> GetAllDesignation();
        Designation Add(Designation designation);
        Designation DeleteData(int id);
        Designation Edit(Designation designation);
    }
}
