using System;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Http;

using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EmployeeManagement.ViewModels
{
    public class EmployeeViewModel
    {


        public int Id { get; set; }

        [Required(ErrorMessage = "the field is required")]
        // [StringLength(8, ErrorMessage = "Name length cannot be more than 8")]
        public string Name { get; set; }



        [Required(ErrorMessage = "the field is required")]
        // [Display(Name = "Office email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "the field is required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "the field is required")]
        public Int64 Age { get; set; }

        [Required(ErrorMessage = "the field is required")]
        public Int64 MobileNo { get; set; }

        [Required(ErrorMessage = "the field is required")]
        public string PhotoPath { get; set; }

       


        

        public IFormFile Photo { get; set; }

    }
}
