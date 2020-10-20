using EmployeeManagement.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public IEnumerable<Employe> Employes { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Employes = (await EmployeeService.GetEmployees()).ToList();


        }
        //private void LoadEmployees()
        //{
        //    System.Threading.Thread.Sleep(3000);
        //    Employe e1 = new Employe 
        //    {
        //        EmpolyeeId = 1,
        //        FirstName = "John",
        //        LastName = "HASH",
        //        Email = "joHNN@gmail.com",
        //        DateOfBirth = new DateTime(1998, 10, 2),
        //        Gender = Gender.Male,
        //        DepartmentId =  1,
        //        PhotoPath = "images/imp1.jpg",
        //    };
        //    Employe e2 = new Employe 
        //    {
        //        EmpolyeeId = 2,
        //        FirstName = "Sam",
        //        LastName = "Sharma",
        //        Email = "sammjguhj@gmail.com",
        //        DateOfBirth = new DateTime(1998, 5, 22),
        //        Gender = Gender.Male,
        //        DepartmentId = 2,
        //        PhotoPath = "images/imp2.jpg",
        //    };
        //    Employe e3 = new Employe
        //    {
        //        EmpolyeeId = 3,
        //        FirstName = "Neha",
        //        LastName = "Sharma",
        //        Email = "neha@gmail.com",
        //        DateOfBirth = new DateTime(1998, 10, 2),
        //        Gender = Gender.Female,
        //        DepartmentId =  3,
        //        PhotoPath = "images/imp3.jpg",
        //    };
        //    Employe e4 = new Employe
        //    {
        //        EmpolyeeId = 4,
        //        FirstName = "Neha",
        //        LastName = "Sharma",
        //        Email = "neha@gmail.com",
        //        DateOfBirth = new DateTime(1998, 10, 2),
        //        Gender = Gender.Female,
        //        DepartmentId = 4,
        //        PhotoPath = "images/imp4.jpg",
        //    };
        //    Employes = new List<Employe> { e1, e2, e3, e4 };
        //}
    }
}
