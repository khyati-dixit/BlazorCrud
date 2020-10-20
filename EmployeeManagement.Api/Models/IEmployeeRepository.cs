using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employe>> GetEmployes();
        Task<Employe> GetEmploye(int employeeId);
        Task<Employe> AddEmploye(Employe employe);
        Task<Employe> UpdateEmploye(Employe employe);
        Task<Employe> DeleteEmployee(int employeeId);
    }
}
