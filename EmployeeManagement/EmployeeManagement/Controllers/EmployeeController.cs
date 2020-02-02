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
    public class EmployeeController : Controller
    {
       
        private readonly IEmployeeRepository _empRepo;
        
        private readonly IHostingEnvironment hostingEnvironment;
        


        // Inject IEmployeeRepository using Constructor Injection
        public EmployeeController(IEmployeeRepository employeeRepository, IHostingEnvironment hostingEnvironment)
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
          IEnumerable<Employee> emp = _empRepo.GetAllEmployee();
         
            return View(emp);


        }
        [HttpGet]
        public IActionResult Create()
        {
           
            
            return View();
        }
        [HttpPost]
        public RedirectToActionResult Create(EmployeeViewModel employee)
        {

            string uniqueFileName = null;


            string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "img/image");
            uniqueFileName = Guid.NewGuid().ToString() + "_" + employee.Photo.FileName;
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);
            employee.Photo.CopyTo(new FileStream(filePath, FileMode.Create));


            Employee newEmployee = new Employee
            {
                Name = employee.Name,
                Email = employee.Email,
                MobileNo = employee.MobileNo,
                Age = employee.Age,
                Gender = employee.Gender,
                PhotoPath = uniqueFileName

            };

            _empRepo.Add(newEmployee);
            return RedirectToAction("AllDetails");
        }

        // return RedirectToAction("Details", new { id = emp.Id });
        [HttpGet]
        public ViewResult Edit(int id)
        {
            Employee employee = _empRepo.GetEmployee(id);
            EmployeeEditViewModel employeeEditViewModel = new EmployeeEditViewModel
            {
                Name = employee.Name,
                Email = employee.Email,
                MobileNo = employee.MobileNo,
                Age = employee.Age,
                Gender = employee.Gender,
                ExistingPhotoPath = employee.PhotoPath

            };
            return View(employeeEditViewModel);
        }

        [HttpPost]
        public RedirectToActionResult Edit(EmployeeEditViewModel employee)
        {

            string uniqueFileName = null;


            string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "img/image");
            uniqueFileName = Guid.NewGuid().ToString() + "_" + employee.Photo.FileName;
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);
            employee.Photo.CopyTo(new FileStream(filePath, FileMode.Create));


            Employee newEmployee = _empRepo.GetEmployee(employee.Id);

            newEmployee.Name = employee.Name;
            newEmployee.Email = employee.Email;
            newEmployee.MobileNo = employee.MobileNo;
            newEmployee.Age = employee.Age;
            newEmployee.Gender = employee.Gender;
            newEmployee.PhotoPath = uniqueFileName;
  
            _empRepo.Edit(newEmployee);
            return RedirectToAction("AllDetails");
        }

        public ViewResult Details(int id)
        {
            Employee em = _empRepo.GetEmployee(id);
            return View(em);
        }
        public IActionResult Delete(int id)
        {
            Employee em = _empRepo.DeleteData(id);
            return RedirectToAction("AllDetails");
        }

    }
    

   
}

