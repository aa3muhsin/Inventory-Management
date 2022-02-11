using System;
using Inventory_Management.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventory_Management.Data
{
    public class AssetConfiguration : IEntityTypeConfiguration<Asset>
    {
        public void Configure(EntityTypeBuilder<Asset> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(a => a.AssetNumber).IsRequired().HasMaxLength(7);
            builder.Property(a => a.PurchasedDate).IsRequired();

            builder.HasIndex(a => a.AssetNumber).IsUnique();

            builder.HasOne(a => a.AssetType).WithMany(t => t.Assets).HasForeignKey(a => a.TypeId);
        }
    }
}