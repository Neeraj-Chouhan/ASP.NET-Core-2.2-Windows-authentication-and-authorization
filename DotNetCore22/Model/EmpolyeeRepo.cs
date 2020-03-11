using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore22.Model
{
    
    public class EmpolyeeRepo : IEmployee
    {
        List<Employee> emplst;
        public EmpolyeeRepo()
        {
            emplst = new List<Employee>() { new Employee() { id = 1 , Name = "Neeraj" , Salary = 2000},
                                            new Employee () {id = 2 , Name = "rohit",Salary = 3000}};
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return emplst;
        }

        public Employee GetEmployeeById(int id)
        {
            return emplst.FirstOrDefault(item => item.id == id);
        }

        public Employee Create(Employee employee)
        {
            emplst.Add(employee);
            return employee;
        }

        public Employee Update(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee Delete(int id)
        {
            Employee employee = emplst.FirstOrDefault(item => item.id == id);
             emplst.Remove(employee);
            return employee;
        }
    }
}
