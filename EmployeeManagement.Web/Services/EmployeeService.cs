using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Services
{
    public class EmployeeService : IEmployeeService
    {
        public readonly HttpClient httpClient;
        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<Employe>> GetEmployees()
        {
            return await httpClient.GetJsonAsync<Employe[]>("api/employee");
        }
    }
}
