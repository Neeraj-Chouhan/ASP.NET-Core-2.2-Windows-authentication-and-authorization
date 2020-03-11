using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore22
{
    public class MyController : Controller
    {
        public string MyMethod()
        {
            return "this is my controller and my method";
        }
    }
}