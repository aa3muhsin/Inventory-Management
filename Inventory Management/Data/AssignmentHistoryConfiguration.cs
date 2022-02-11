using System;
using Inventory_Management.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventory_Management.Data
{
    public class AssignmentHistoryConfiguration : IEntityTypeConfiguration<AssignmentHistory>
    {
        public void Configure(EntityTypeBuilder<AssignmentHistory> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(ah => ah.AssignedDate).IsRequired();

            builder.HasOne(ah => ah.Staff).WithMany(s => s.AssignmentHistory).HasForeignKey(ah => ah.StaffId);
            builder.HasOne(ah => ah.Asset).WithMany(a => a.AssignmentHistory).HasForeignKey(ah => ah.AssetId);

            builder.HasData(
                new AssignmentHistory { Id = 1, AssignedDate = DateTime.Parse("2021-01-15 14:00"), AssetId = 6, StaffId = 2 },
                new AssignmentHistory { Id = 2, AssignedDate = DateTime.Parse("2021-01-15 14:00"), AssetId = 7, StaffId = 2 },
                new AssignmentHistory { Id = 3, AssignedDate = DateTime.Parse("2021-01-15 14:00"), AssetId = 8, StaffId = 2 },
                new AssignmentHistory { Id = 4, AssignedDate = DateTime.Parse("2021-01-15 14:00"), AssetId = 9, StaffId = 2 }
            );
        }
    }
}