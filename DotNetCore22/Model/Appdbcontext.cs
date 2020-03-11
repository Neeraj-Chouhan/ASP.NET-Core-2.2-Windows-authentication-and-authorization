using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore22.Model
{
    public class Appdbcontext: IdentityDbContext 
    {
        public Appdbcontext(DbContextOptions<Appdbcontext> options) :base(options)
        {

        }

        public DbSet<Employee> employees { get; set; }
        //public DbSet<User> users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().HasData(
            
            
            new Employee{ id = 101, Name = "Neeraj Chouhan", Salary = 30000 },
            new Employee { id =201 , Name = "Ratnesh kushwaha" , Salary = 5000}
            
            );

        }
        
    }
}
