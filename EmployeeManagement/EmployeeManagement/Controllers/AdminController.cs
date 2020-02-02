using EmployeeManagement.Models;
using EmployeeManagement.Repository.Interface;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AdminController(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Register()
        {


            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(AdminViewModel model)
        {
            
            
                // Copy data from RegisterViewModel to IdentityUser
                var user = new IdentityUser
                {
                    UserName=model.FullName,
                    Email = model.Email,
                    PasswordHash=model.Password

                };
            
            
                var result = await userManager.CreateAsync(user, model.Password);



            // Store user data in AspNetUsers database table
            //var result = await userManager.CreateAsync(user, model.Password);

            // If user is successfully created, sign-in the user using
            // SignInManager and redirect to index action of HomeController
            if (result.Succeeded)
            {
                await signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction("Index", "Employee");
            }

            // If there are any errors, add them to the ModelState object
            // which will be displayed by the validation summary tag helper
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }


            return View(model);
        }
       
    }
}

