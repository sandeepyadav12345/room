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
    public class LeaveController : Controller
    {

        private readonly ILeaveRepository _empRepo;

        private readonly IHostingEnvironment hostingEnvironment;



        // Inject IEmployeeRepository using Constructor Injection
        public LeaveController(ILeaveRepository employeeRepository, IHostingEnvironment hostingEnvironment)
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
            IEnumerable<Leave> emp = _empRepo.GetAllLeave();

            return View(emp);


        }
        [HttpGet]
        public IActionResult Create()
        {


            return View();
        }
        [HttpPost]
        public RedirectToActionResult Create(Leave employee)
        {

           


            Leave newEmployee = new Leave
            {
                LeaveId=employee.LeaveId,
                Type = employee.Type,
                FromDate = employee.FromDate,
                ToDate = employee.ToDate,
                EmployeeName = employee.EmployeeName


            };

            _empRepo.Add(newEmployee);
            return RedirectToAction("AllDetails");
        }

        // return RedirectToAction("Details", new { id = emp.Id });
        [HttpGet]
        public ViewResult Edit(int id)
        {
            Leave employee = _empRepo.GetLeave(id);
            Leave employeeModel = new Leave
            {
                Type = employee.Type,
                FromDate = employee.FromDate,
                ToDate= employee.ToDate,
               EmployeeName = employee.EmployeeName

            };
            return View(employeeModel);
        }

        [HttpPost]
        public RedirectToActionResult Edit(Leave employee)
        {

            


            Leave newEmployee = _empRepo.GetLeave(employee.LeaveId);

            newEmployee.Type = employee.Type;
            newEmployee.FromDate = employee.FromDate;
            newEmployee.ToDate = employee.ToDate;
            newEmployee.EmployeeName = employee.EmployeeName;


            _empRepo.Edit(newEmployee);
            return RedirectToAction("AllDetails");
        }

        public ViewResult Details(int id)
        {
            Leave em = _empRepo.GetLeave(id);
            return View(em);
        }
        public IActionResult Delete(int id)
        {
            Leave em = _empRepo.DeleteData(id);
            return RedirectToAction("AllDetails");
        }

    }



}

