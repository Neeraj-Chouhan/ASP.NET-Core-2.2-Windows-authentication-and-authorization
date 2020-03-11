using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore22.Model
{
   public interface IEmployee
    {
        Employee GetEmployeeById(int id);

        IEnumerable<Employee> GetAllEmployees();

        Employee Create(Employee employee);

        Employee Update(Employee employee);

        Employee Delete(int id);
    }
}
