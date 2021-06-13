using EFCoreCodeFirstSample_SP21_Evening.Models;
using EFCoreCodeFirstSample_SP21_Evening.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EFCoreCodeFirstSample_SP21_Evening.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IDataRepository<Employee> dataRespository;
        public EmployeeController(IDataRepository<Employee> dataRespository)
        {
            this.dataRespository = dataRespository;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Employee> employees = dataRespository.GetAll();
            return Ok(employees);
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            Employee employee = dataRespository.Get(id);
            if(employee == null)
            {
                return NotFound("Employee record not found");
            }
            return Ok(employee);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            if(employee == null)
            {
                return BadRequest("Employee is null");
            }
            dataRespository.Add(employee);
            return CreatedAtAction("Get", new { id = employee.EmployeeId }, employee);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("Employee is null");
            }
            Employee employeeToUpdate = dataRespository.Get(id);
            if (employee == null)
            {
                return NotFound("Employee record not found");
            }
            dataRespository.Update(employeeToUpdate, employee);
            return Ok(employee);
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Employee employee = dataRespository.Get(id);
            if (employee == null)
            {
                return NotFound("Employee record not found");
            }
            dataRespository.Delete(employee);
            return NoContent();
        }
    }
}
