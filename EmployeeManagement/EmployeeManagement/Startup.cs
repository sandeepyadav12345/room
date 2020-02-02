using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using EmployeeManagement.Repository.Interface;
using EmployeeManagement.Repository.Implementation;
using Microsoft.Extensions.Configuration;
using ServiceStack.Text;
using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace EmployeeManagement
{
    public class Startup
    {
        private IConfiguration _config;
            public Startup(IConfiguration config)
        {
            _config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<EmployeeDbContext>(options => options.UseSqlServer(_config.GetConnectionString("myConnection")));
            services.AddMvc();
            services.AddScoped<IEmployeeRepository, sqlEmployeeRepository>();
            services.AddScoped<IDepartmentRepository, sqlDepartmentRepository>();
            services.AddScoped<ISalaryRepository, sqlSalaryRepository>();
            services.AddScoped<IVacancyRepository, sqlVacancyRepository>();
            services.AddScoped<ILeaveRepository, sqlLeaveRepository>();
            services.AddScoped<IDesignationRepository, sqlDesignationRepository>();

            services.AddIdentity<IdentityUser, IdentityRole>(options =>
                {
                    options.Password.RequiredLength = 10;
                    options.Password.RequiredUniqueChars = 3 ;
                    options.Password.RequireNonAlphanumeric = false;
                })

                .AddEntityFrameworkStores<EmployeeDbContext>();
            
           
        }
    

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseStaticFiles();
            app.UseAuthentication();
           // app.UseMvcWithDefaultRoute();
           /* app.UseMvc(routes =>

             routes.MapRoute("default", "{Controller=Admin}/{action=Register}/{id?}")

            ) ;*/
           app.UseMvc(routes =>

            routes.MapRoute("default", "{Controller=Employee}/{action=Index}/{id?}")

           );

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
