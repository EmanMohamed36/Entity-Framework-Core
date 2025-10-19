using Microsoft.EntityFrameworkCore;
using RelationShipsBetweenEmployeeAndDepartment.Models;
using System.Data.Common;
using System.Reflection;

namespace RelationShipsBetweenEmployeeAndDepartment.Data
{
    public class CompanyDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-V690Q3O; Database = CompanyRelationShips; Trusted_Connection=True;TrustServerCertificate = True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<Employee>()
                        .OwnsOne(e => e.Address, address => address.WithOwner());
        }

        public DbSet<Employee> Employees{ get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
