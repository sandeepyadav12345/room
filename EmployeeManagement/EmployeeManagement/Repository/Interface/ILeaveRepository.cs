using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Repository.Interface
{
  public  interface ILeaveRepository
    {
        Leave GetLeave(int id);
        IEnumerable<Leave> GetAllLeave();
        Leave Add(Leave leave);
        Leave DeleteData(int id);
        Leave Edit(Leave leave);
    }
}
