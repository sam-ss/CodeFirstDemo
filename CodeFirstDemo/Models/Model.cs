using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstDemo.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }

    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required]
        [StringLength(8, ErrorMessage = "Name length can't be more than 8.")]
        public string EmployeeName { get; set; }
        public int EmployeeAge { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}