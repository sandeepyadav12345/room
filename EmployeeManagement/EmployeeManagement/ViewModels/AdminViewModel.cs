using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace EmployeeManagement.ViewModels
{
    public class AdminViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Full Name required")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Email required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password required")]
        public string Password { get; set; }
    }
}
