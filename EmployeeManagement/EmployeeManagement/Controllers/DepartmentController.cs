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
    public class DepartmentController : Controller
    {

        private readonly IDepartmentRepository _empRepo;

        private readonly IHostingEnvironment hostingEnvironment;



        // Inject IEmployeeRepository using Constructor Injection
        public DepartmentController(IDepartmentRepository departmentRepository, IHostingEnvironment hostingEnvironment)
        {
            _empRepo = departmentRepository;
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
            IEnumerable<Department> emp = _empRepo.GetAllDepartment();

            return View(emp);


        }
        [HttpGet]
        public IActionResult Create()
        {


            return View();
        }
        [HttpPost]
        public RedirectToActionResult Create(Department department)
        {

           


            Department newEmployee = new Department
            {
                DepName = department.DepName,
                DepHod = department.DepHod,
                DepLocation = department.DepLocation,
                

            };

            _empRepo.Add(newEmployee);
            return RedirectToAction("AllDetails");
        }

        // return RedirectToAction("Details", new { id = emp.Id });
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Department department = _empRepo.GetDepartment(id);
            DepartmentEditViewModel employeeModel = new DepartmentEditViewModel
            {
                DepartmentId = department.DepartmentId,
                DepName = department.DepName,
                DepHod = department.DepHod,
                DepLocation= department.DepLocation
               

            };
            return View(employeeModel);
        }

        [HttpPost]
        public RedirectToActionResult Edit(DepartmentEditViewModel department)
        {
            
            
                Department newEmployee = _empRepo.GetDepartment(department.DepartmentId);
            
                newEmployee.DepName = department.DepName;
                newEmployee.DepHod = department.DepHod;
                newEmployee.DepLocation = department.DepLocation;

             Department em =   _empRepo.Edit(newEmployee);
                return RedirectToAction("AllDetails");
            

           
        }

        public ViewResult Details(int id)
        {
            Department em = _empRepo.GetDepartment(id);
            return View(em);
        }
        public IActionResult Delete(int id)
        {
            Department em = _empRepo.DeleteData(id);
            return RedirectToAction("AllDetails");
        }

    }



}

