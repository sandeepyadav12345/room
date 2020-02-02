using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Vacancy
    {
        public int VacancyId { get; set; }


        public string Description { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }
}
