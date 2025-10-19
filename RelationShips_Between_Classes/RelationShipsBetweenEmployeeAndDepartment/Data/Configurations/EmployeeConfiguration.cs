using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RelationShipsBetweenEmployeeAndDepartment.Models;

namespace RelationShipsBetweenEmployeeAndDepartment.Data.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(e => e.Name)
                   .IsRequired()
                   .HasColumnType("varchar(40)");
            builder.Property(e => e.Salary)
                   .HasColumnType("INT");
            //builder.ToTable(t => {
            //    t.HasCheckConstraint("ck_Employee_Salary_Positive", "Salary > 0");
            //    });
                   
        }
    }
}
