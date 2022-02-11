using Inventory_Management.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventory_Management.Data
{
    public class AssetTypeConfiguration : IEntityTypeConfiguration<AssetType>
    {
        public void Configure(EntityTypeBuilder<AssetType> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(t => t.Name).IsRequired().HasMaxLength(60);

            builder.HasIndex(i => i.Name).IsUnique();
        }
    }
}