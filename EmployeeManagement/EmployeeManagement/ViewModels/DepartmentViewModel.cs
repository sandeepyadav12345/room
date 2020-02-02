using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Http;

using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.ViewModels
{
    public class DepartmentViewModel
    {
        public int DepartmentId { get; set; }

        
        public string DepName { get; set; }
        
        public string DepHod { get; set; }
        
        public string DepLocation { get; set; }
    }
}
