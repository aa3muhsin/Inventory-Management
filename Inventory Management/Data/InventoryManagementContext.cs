using Inventory_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory_Management.Data
{
    public class InventoryManagementContext : DbContext
    {
        public InventoryManagementContext(DbContextOptions options) : base(options) { }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssignmentHistory> AssetsHistory { get; set; }
        public DbSet<AssetType> AssetTypes { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AssetConfiguration());
            modelBuilder.ApplyConfiguration(new AssignmentHistoryConfiguration());
            modelBuilder.ApplyConfiguration(new AssetTypeConfiguration());
            modelBuilder.ApplyConfiguration(new StaffConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
        }
    }
}
