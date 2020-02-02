using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Repository.Interface
{
  public  interface IVacancyRepository
    {
        Vacancy GetVacancy(int id);
        IEnumerable<Vacancy> GetAllVacancy();
        Vacancy Add(Vacancy vacancy);
        Vacancy DeleteData(int id);
        Vacancy Edit(Vacancy vacancy);
    }
}
