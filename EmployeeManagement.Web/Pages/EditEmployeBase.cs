using EmployeeManagement.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EditEmployeBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public Employe Employe { get; set; } = new Employe();
        [Parameter]
        public string Id { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Employe = await EmployeeService.GetEmploye(int.Parse(Id));
        }
    }
}
