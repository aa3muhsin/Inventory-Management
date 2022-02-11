using Inventory_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory_Management.Data
{
    public class ITAssetManagementContext : DbContext
    {
        public ITAssetManagementContext(DbContextOptions options) : base(options) { }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssignmentHistory> AssetsHistory { get; set; }
        public DbSet<AssetType> AssetTypes { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Department> Departments { get; set; }

        public 
    }
}
