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
    public class DesignationController : Controller
    {

        private readonly IDesignationRepository _empRepo;

        private readonly IHostingEnvironment hostingEnvironment;



        // Inject IEmployeeRepository using Constructor Injection
        public DesignationController(IDesignationRepository employeeRepository, IHostingEnvironment hostingEnvironment)
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
            IEnumerable<Designation> emp = _empRepo.GetAllDesignation();

            return View(emp);


        }
        [HttpGet]
        public IActionResult Create()
        {


            return View();
        }
        [HttpPost]
        public RedirectToActionResult Create(Designation employee)
        {

           


            Designation newEmployee = new Designation
            {
                Date = employee.Date,
                Time = employee.Time,
                Day = employee.Day,
                ClientName = employee.ClientName
                

            };

            _empRepo.Add(newEmployee);
            return RedirectToAction("AllDetails");
        }

        // return RedirectToAction("Details", new { id = emp.Id });
        [HttpGet]
        public ViewResult Edit(int id)
        {
            Designation employee = _empRepo.GetDesignation(id);
            Designation employeeModel = new Designation
            {
                DesignationId=employee.DesignationId,
                Date = employee.Date,
                Time = employee.Time,
                Day= employee.Day,
                ClientName=employee.ClientName
               

            };
            return View(employeeModel);
        }

        [HttpPost]
        public RedirectToActionResult Edit(Designation employee)
        {

            


            Designation newEmployee = _empRepo.GetDesignation(employee.DesignationId);

            newEmployee.Date = employee.Date;
            newEmployee.Time = employee.Time;
            newEmployee.Day = employee.Day;
            newEmployee.ClientName = employee.ClientName;


            _empRepo.Edit(newEmployee);
            return RedirectToAction("AllDetails");
        }

        public ViewResult Details(int id)
        {
            Designation em = _empRepo.GetDesignation(id);
            return View(em);
        }
        public IActionResult Delete(int id)
        {
            Designation em = _empRepo.DeleteData(id);
            return RedirectToAction("AllDetails");
        }

    }



}

