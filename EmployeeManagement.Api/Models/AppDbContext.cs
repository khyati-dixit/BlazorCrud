using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Employe> Employes { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //See d Departments Table
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 2, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 3, DepartmentName = "Payroll" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 4, DepartmentName = "Admin" });

            //Seed Employee Table
            modelBuilder.Entity<Employe>().HasData(new Employe
            {
                EmpolyeeId = 1,
                FirstName = "John",
                LastName = "HASH",
                Email = "joHNN@gmail.com",
                DateOfBirth = new DateTime(1998, 10, 2),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/imp1.jpg",
            });
            modelBuilder.Entity<Employe>().HasData(new Employe
            {
                EmpolyeeId = 2,
                FirstName = "Sam",
                LastName = "Sharma",
                Email = "sammjguhj@gmail.com",
                DateOfBirth = new DateTime(1998, 5, 22),
                Gender = Gender.Male,
                DepartmentId = 2,
                PhotoPath = "images/imp2.jpg",
            });
            modelBuilder.Entity<Employe>().HasData(new Employe
            {
                EmpolyeeId = 3,
                FirstName = "Neha",
                LastName = "Sharma",
                Email = "neha@gmail.com",
                DateOfBirth = new DateTime(1998, 10, 2),
                Gender = Gender.Female,
                DepartmentId = 1,
                PhotoPath = "images/imp3.jpg",
            });
            modelBuilder.Entity<Employe>().HasData(new Employe
            {
                EmpolyeeId = 4,
                FirstName = "Neha",
                LastName = "Sharma",
                Email = "neha@gmail.com",
                DateOfBirth = new DateTime(1998, 10, 2),
                Gender = Gender.Female,
                DepartmentId = 4,
                PhotoPath = "images/imp4.jpg",
            });
        }
    }
}
