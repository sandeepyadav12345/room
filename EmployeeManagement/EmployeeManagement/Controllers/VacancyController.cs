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
    public class VacancyController : Controller
    {

        private readonly IVacancyRepository _empRepo;

        private readonly IHostingEnvironment hostingEnvironment;



        // Inject IEmployeeRepository using Constructor Injection
        public VacancyController(IVacancyRepository employeeRepository, IHostingEnvironment hostingEnvironment)
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
            IEnumerable<Vacancy> emp = _empRepo.GetAllVacancy();

            return View(emp);


        }
        [HttpGet]
        public IActionResult Create()
        {


            return View();
        }
        [HttpPost]
        public RedirectToActionResult Create(Vacancy employee)
        {

           


            Vacancy newEmployee = new Vacancy
            {
                VacancyId=employee.VacancyId,
                Description = employee.Description,
                Date = employee.Date,
                Time = employee.Time,
                

            };

            _empRepo.Add(newEmployee);
            return RedirectToAction("AllDetails");
        }

        // return RedirectToAction("Details", new { id = emp.Id });
        [HttpGet]
        public ViewResult Edit(int id)
        {
            Vacancy employee = _empRepo.GetVacancy(id);
            Vacancy employeeModel = new Vacancy
            {
                Description = employee.Description,
                Date = employee.Date,
                Time= employee.Time
               

            };
            return View(employeeModel);
        }

        [HttpPost]
        public RedirectToActionResult Edit(Vacancy employee)
        {

            


            Vacancy newEmployee = _empRepo.GetVacancy(employee.VacancyId);

            newEmployee.Description = employee.Description;
            newEmployee.Date = employee.Date;
            newEmployee.Time = employee.Time;
            

            _empRepo.Edit(newEmployee);
            return RedirectToAction("AllDetails");
        }

        public ViewResult Details(int id)
        {
            Vacancy em = _empRepo.GetVacancy(id);
            return View(em);
        }
        public IActionResult Delete(int id)
        {
            Vacancy em = _empRepo.DeleteData(id);
            return RedirectToAction("AllDetails");
        }

    }



}

