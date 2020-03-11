using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore22.Model
{
    public class SqlEmployeeRepo : IEmployee
    {
        public Appdbcontext Context { get; set; }
        public SqlEmployeeRepo(Appdbcontext context)
        {
            Context = context;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return Context.employees;
        }

        public Employee GetEmployeeById(int id)
        {
            return Context.employees.Find(id);
        }

        public Employee Create(Employee employee)
        {
            Context.employees.Add(employee);
            Context.SaveChanges();
            return employee;
        }

        public Employee Update(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee Delete(int id)
        {
            Employee emp = Context.employees.Find(id);
            if (emp!=null)
            {
                Context.employees.Remove(emp);
                Context.SaveChanges();
            }
            return emp;
        }
    }
}
