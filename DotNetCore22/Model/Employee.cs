using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore22.Model
{
    public class Employee
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        //public IFormFile MyProperty { get; set; }

    }
}
