using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "the field is required")]
       
        public string Name { get; set; }


        
        [Required(ErrorMessage = "the field is required")]
       
        public string Email { get; set; }
        
        [Required(ErrorMessage = "the field is required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "the field is required")]
        public string PhotoPath { get; set; }

        [Required(ErrorMessage = "the field is required")]
        public Int64 Age { get; set; }

        [Required(ErrorMessage = "the field is required")]
        public Int64 MobileNo { get; set; }

        
        
        
        
        


    }
}
