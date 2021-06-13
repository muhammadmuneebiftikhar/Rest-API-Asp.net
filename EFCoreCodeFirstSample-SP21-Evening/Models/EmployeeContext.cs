using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCodeFirstSample_SP21_Evening.Models
{
    public class EmployeeContext: DbContext
    {
        public EmployeeContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    FirstName = "Ali",
                    LastName = "Raza",
                    Email = "aliraza@gmail.com",
                    DateOfBirth = new DateTime(1992,04,16),
                    PhoneNumber = "090078601"
                },
                new Employee
                {
                    EmployeeId = 2,
                    FirstName = "Asad",
                    LastName = "Ullah",
                    Email = "asadullah@gmail.com",
                    DateOfBirth = new DateTime(1992,04,16),
                    PhoneNumber = "090078601"
                }
            ) ;
        }
    }
}
