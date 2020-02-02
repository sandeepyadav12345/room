using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ims.SandeepYadav.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ims.SandeepYadav.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Employee> e = new List<Employee>()
            {
                new Employee()
                {
                    EmployeeId = 1,
                    EmployeeName = "Ram",
                    EmployeeEmail = "Ram@gmail.com"
                },
                new Employee()
                {
                    EmployeeId = 2,
                    EmployeeName = "Shyam",
                    EmployeeEmail = "Shyam@gmail.com"
                }
            };
            
            return View(e);
        }
        public ViewResult create()
        {
            return View();
        }
    }
}
