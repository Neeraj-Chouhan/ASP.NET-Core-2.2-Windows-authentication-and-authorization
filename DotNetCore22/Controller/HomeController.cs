using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore22.Model;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;

namespace DotNetCore22
{
    //[Route("Home")]
    public class HomeController : Controller
    {
        Employee _emp;
        IEnumerable<Employee> emplist;
        IEmployee iemployee;
        
        public HomeController(IEmployee iemp)
        {
            //_emp = iemp.GetEmployeeById(2);
            emplist = iemp.GetAllEmployees();
            iemployee = iemp;

        }

        [Route("")]
        [Route("/Home")]
        [Route("/Home/Index")]
        public ViewResult Index()
        {
           

            //return View();


            return View("~/Views/Test/MyView.cshtml", emplist);

            //return _emp.Name;

            //ViewData["Name"] = _emp.Name;
            //ViewBag.salary = _emp.Salary;
            //return View("~/Views/Test/MyView.cshtml");
        }
        [Route("/Home/AllEmployees")]
        public ViewResult AllEmployees()
        {
            //WindowsIdentity windowsIdentity = WindowsIdentity.GetCurrent();
            //string authenticationType = windowsIdentity.AuthenticationType;
            //string userName = windowsIdentity.Name;
            //GenericIdentity genericIdentity = new GenericIdentity(userName, authenticationType);


            //HttpContext.User = new GenericPrincipal(genericIdentity, new string[] { "MYAdmin" });


            //ViewData["Name"] = _emp.Name;
            //ViewBag.salary = _emp.Salary;
            return View("~/Views/Test/MyView.cshtml" , emplist);
        }


        [HttpPost]
        [Route("/Home/CreateEmployee")]
        public void CreateEmployee(Employee employee)
        {

          Employee emp =  iemployee.Create(employee);

        }

     
        [Route("/Home/DeleteEmployee/{id?}")]
        public IActionResult DeleteEmployee(int? id)
        {

            Employee emp = iemployee.Delete(id??1);

            return  RedirectToAction("AllEmployees");

        }


    }
}