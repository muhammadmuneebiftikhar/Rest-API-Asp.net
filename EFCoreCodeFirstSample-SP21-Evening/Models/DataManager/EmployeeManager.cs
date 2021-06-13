using EFCoreCodeFirstSample_SP21_Evening.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCodeFirstSample_SP21_Evening.Models.DataManager
{
    public class EmployeeManager : IDataRepository<Employee>
    {
        readonly EmployeeContext employeeContext;
        public EmployeeManager(EmployeeContext context)
        {
            employeeContext = context;
        }
        public void Add(Employee entity)
        {
            employeeContext.Employees.Add(entity);
            employeeContext.SaveChanges();
        }

        public void Delete(Employee entity)
        {
            employeeContext.Employees.Remove(entity);
            employeeContext.SaveChanges();
        }

        public Employee Get(long id)
        {
            return employeeContext.Employees.FirstOrDefault(e => e.EmployeeId == id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return employeeContext.Employees.ToList();
        }

        public void Update(Employee dbEntity, Employee entity)
        {
           dbEntity.FirstName = entity.FirstName;
           dbEntity.LastName = entity.LastName;
           dbEntity.Email = entity.Email;
           dbEntity.DateOfBirth = entity.DateOfBirth;
           dbEntity.PhoneNumber = entity.PhoneNumber;
            employeeContext.SaveChanges();
        }
    }
}
