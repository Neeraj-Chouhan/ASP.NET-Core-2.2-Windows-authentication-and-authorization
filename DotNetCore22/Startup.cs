using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using Microsoft.Extensions.Configuration;
using DotNetCore22.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace DotNetCore22
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
            services.AddDbContextPool<Appdbcontext>(option => option.UseSqlServer(_config.GetConnectionString("EmployeedbConnectionstring")));
            services.AddMvc();
            //services.AddScoped<IEmployee, SqlEmployeeRepo>();
            services.AddSingleton<IEmployee, EmpolyeeRepo>();
            //services.AddSingleton<IUser, UserRepo>();
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<Appdbcontext>();

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

            //app.UseMvc(route =>
            //{
            //    route.MapRoute(name: "default", template: "{Controller=MyController}/{action=MyMethod}/{id?}");

            //});

            //app.UseMvcWithDefaultRoute();

            app.UseMvc(route =>
            {
                route.MapRoute(name: "default", template: "{Controller=Home}/{action=AllEmployees}/{id?}");

            });

            //app.UseMvc();


            //app.Run(async (context) =>
            //{
            //    //await context.Response.WriteAsync(Process.GetCurrentProcess().ProcessName);
            //    //await context.Response.WriteAsync(_config["MyAppKey"].ToString());
            //    await context.Response.WriteAsync(_config["MyAppKey"].ToString());
            //});
        }
    }
}
