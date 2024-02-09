using EmployeesManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeesManagement.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>contextOptions) : base(contextOptions) 
        {
        }

        //Code-first Approach
        public DbSet<Employee>Employees { get; set; }
    }
}
