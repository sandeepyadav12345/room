using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Salary
    {
        public int SalaryId { get; set; }


        public int Amount { get; set; }
        public string Department { get; set; }
        public string Type { get; set; }
    }
}
