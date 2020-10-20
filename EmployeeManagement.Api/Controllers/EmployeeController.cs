using EmployeeManagement.Api.Models;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;


namespace EmployeeManagement.Api.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;
       public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        [HttpGet]
        public async Task<ActionResult> GetEmployees()
        {
     
             return  Ok(await employeeRepository.GetEmployes());
  
         
           
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Employe>> GetEmployee(int id)
        {
            try
            {
               var result = await employeeRepository.GetEmploye(id);
                if(result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        public async Task<ActionResult<Employe>> CreateEmployee(Employe employe)
        {
            try
            {
                if (employe == null)
                {
                    return BadRequest();
                }
                var createdEmployee = await employeeRepository.AddEmploye(employe);
                return CreatedAtAction(nameof(GetEmployee),new { id = createdEmployee.EmpolyeeId },
                    createdEmployee);
              
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        public async Task<ActionResult<Employe>> UpdateEmployee(int id, Employe employe)
        {
            try
            {
                if(id != employe.EmpolyeeId)
                {
                    return BadRequest();
                }
                var employeToUpdate = await employeeRepository.GetEmploye(id);
                if(employeToUpdate == null)
                {
                    return NotFound();
                }
                return await employeeRepository.UpdateEmploye(employe);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<ActionResult<Employe>> DeleteEmployee(int id)
        {
            try
            {
                var employeeToDelete = await employeeRepository.GetEmploye(id);
                if(employeeToDelete == null)
                {
                    return NotFound();
                }
                return await employeeRepository.DeleteEmployee(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
