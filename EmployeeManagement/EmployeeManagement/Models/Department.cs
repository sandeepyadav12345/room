using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace EmployeeManagement.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

       
        public string DepName { get; set; }
        public string DepHod { get; set; }
        public string DepLocation { get; set; }

        
       
    }

}
