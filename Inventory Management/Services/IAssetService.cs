using Inventory_Management.Models;

namespace Inventory_Management.Services
{
    public interface IAssetService
    {
        public Task<Asset> CreateAssetAsync(Asset asset, AssetType type, Staff assignedToStaff, string assignedDate);
        public Task<Asset> DiscardAssetAsync(Asset asset);
        public Task<AssignmentHistory> AssignAssetAsync(Asset asset, Staff staff);
        public Task<String> GenerateAssetNumberAsync();
        public Task<IEnumerable<AssetType>> GetAssetTypesAsync();
        public Task<ICollection<Asset>> GetAssetsAsync();
    }
}
