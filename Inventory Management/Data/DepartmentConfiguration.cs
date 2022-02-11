using Inventory_Management.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventory_Management.Data
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(d => d.Name).IsRequired().HasMaxLength(60);

            builder.HasIndex(i => i.Name).IsUnique();

            builder.HasData(
                new Department { Id = 1, Name = "Administration" },
                new Department { Id = 2, Name = "Accounts" },
                new Department { Id = 3, Name = "Human Resources" }
            );
        }
    }
}