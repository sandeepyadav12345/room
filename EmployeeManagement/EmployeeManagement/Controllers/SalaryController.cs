using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using EmployeeManagement.Repository.Interface;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagement.Controllers
{
    public class SalaryController : Controller
    {

        private readonly ISalaryRepository _empRepo;

        private readonly IHostingEnvironment hostingEnvironment;



        // Inject IEmployeeRepository using Constructor Injection
        public SalaryController(ISalaryRepository employeeRepository, IHostingEnvironment hostingEnvironment)
        {
            _empRepo = employeeRepository;
            this.hostingEnvironment = hostingEnvironment;

        }

        public ViewResult Index()
        {
            //IList<Employee> employees = context.Employee.Include(c => c.Department).ToList();

            // IEnumerable<Department> dep = _dempRepo.GetAllDepartment();

            return View();

        }

        public ViewResult Tables()
        {
            return View();
        }


        public IActionResult AllDetails()
        {
            IEnumerable<Salary> emp = _empRepo.GetAllSalary();

            return View(emp);


        }
        [HttpGet]
        public IActionResult Create()
        {


            return View();
        }
        [HttpPost]
        public RedirectToActionResult Create(Salary employee)
        {

           


            Salary newEmployee = new Salary
            {
                Amount = employee.Amount,
                Department = employee.Department,
                Type = employee.Type,
                

            };

            _empRepo.Add(newEmployee);
            return RedirectToAction("AllDetails");
        }

        // return RedirectToAction("Details", new { id = emp.Id });
        [HttpGet]
        public ViewResult Edit(int id)
        {
            Salary employee = _empRepo.GetSalary(id);
            Salary employeeModel = new Salary
            {
                SalaryId=employee.SalaryId,
                Amount = employee.Amount,
                Department = employee.Department,
                Type= employee.Type
               

            };
            return View(employeeModel);
        }

        [HttpPost]
        public RedirectToActionResult Edit(Salary employee)
        {

            


            Salary newEmployee = _empRepo.GetSalary(employee.SalaryId);

            newEmployee.Amount = employee.Amount;
            newEmployee.Department = employee.Department;
            newEmployee.Type = employee.Type;
            

            _empRepo.Edit(newEmployee);
            return RedirectToAction("AllDetails");
        }

        public ViewResult Details(int id)
        {
            Salary em = _empRepo.GetSalary(id);
            return View(em);
        }
        public IActionResult Delete(int id)
        {
            Salary em = _empRepo.DeleteData(id);
            return RedirectToAction("AllDetails");
        }

    }



}

