using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Services
{
   public interface IEmployeeService
    {
        Task<IEnumerable<Employe>> GetEmployees();
        Task<Employe> GetEmploye(int id);
    }
}
