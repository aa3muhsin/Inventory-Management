using Inventory_Management.Models;

namespace Inventory_Management.Services
{
    public class AssetService : IAssetService
    {
        public Task<AssignmentHistory> AssignAssetAsync(Asset asset, Staff staff)
        {
            throw new NotImplementedException();
        }

        public Task<Asset> CreateAssetAsync(Asset asset, AssetType type, Staff assignedToStaff, string assignedDate)
        {
            throw new NotImplementedException();
        }

        public Task<Asset> DiscardAssetAsync(Asset asset)
        {
            throw new NotImplementedException();
        }

        public Task<string> GenerateAssetNumberAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Asset>> GetAssetsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AssetType>> GetAssetTypesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
