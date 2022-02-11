using Inventory_Management.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventory_Management.Data
{
    public class StaffConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasKey(k => k.Id);
            
            builder.Property(s => s.Name).IsRequired().HasMaxLength(120);
            builder.Property(s => s.NationalIdentificationNumber).HasColumnName("NID").HasMaxLength(7);
            builder.Property(s => s.StaffNumber).IsRequired().HasMaxLength(7);

            builder.HasIndex(s => s.NationalIdentificationNumber).IsUnique();
            builder.HasIndex(s => s.StaffNumber).IsUnique();

            builder.HasOne(s => s.Department).WithMany(d => d.Staffs).HasForeignKey(s => s.DepartmentId);
        }
    }
}