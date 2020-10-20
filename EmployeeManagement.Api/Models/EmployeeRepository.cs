using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{

    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext appDbContext;
        public EmployeeRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<Employe> AddEmploye(Employe employe)
        {
            var result = await appDbContext.Employes.AddAsync(employe);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Employe> DeleteEmployee(int employeeId)
        {
            var result = await appDbContext.Employes
                .FirstOrDefaultAsync(e => e.EmpolyeeId == employeeId);
            if(result!=null)
            {
                appDbContext.Employes.Remove(result);
                await appDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<Employe> GetEmploye(int employeeId)
        {
            return await appDbContext.Employes
                .FirstOrDefaultAsync(e => e.EmpolyeeId == employeeId);
        }

        public async Task<IEnumerable<Employe>> GetEmployes()
            {
             return await appDbContext.Employes.ToListAsync();
            }

        public async Task<Employe> UpdateEmploye(Employe employe)
        {
            var result = await appDbContext.Employes
                .FirstOrDefaultAsync(e => e.EmpolyeeId == employe.EmpolyeeId);
            if(result != null)
            {
                result.FirstName = employe.FirstName;
                result.LastName = employe.LastName;
                result.Email = employe.Email;
                result.DateOfBirth = employe.DateOfBirth;
                result.Gender = employe.Gender;
                result.DepartmentId = employe.DepartmentId;
                result.PhotoPath = employe.PhotoPath;

                await appDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

    }
}
