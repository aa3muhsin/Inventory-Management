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
        }
    }
}