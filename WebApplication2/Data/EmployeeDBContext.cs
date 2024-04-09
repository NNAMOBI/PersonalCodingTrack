using Microsoft.EntityFrameworkCore;
using WebApplication2.CompanyModel.Employee;

namespace WebApplication2.Data
{
    public class EmployeeDBContext: DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options): base(options)
        {
            
        }

        public DbSet<Employee>? Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 1,
                Name = "Rebecca Osuagwu",
                Email = "Reb@gmail.com",
                Phone = "+234-989-5389"

            },
            new Employee
            {
                Id = 2,
                Name = "TT Osuagwu",
                Email = "tt@gmail.com",
                Phone = "+234-989-5389"
            },
            new Employee
            {
                Id = 3,
                Name = "Kelvin Osuagwu",
                Email = "kelvo@gmail.com",
                Phone = "+432-989-537"
            });
        }
    }
}
