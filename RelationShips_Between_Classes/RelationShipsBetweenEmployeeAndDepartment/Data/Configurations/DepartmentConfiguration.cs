using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RelationShipsBetweenEmployeeAndDepartment.Models;

namespace RelationShipsBetweenEmployeeAndDepartment.Data.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(d => d.Name)
                   .IsRequired()
                   .HasColumnType("varchar(40)");



        }
    }
}
