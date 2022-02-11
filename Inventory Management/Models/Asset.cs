namespace Inventory_Management.Models
{
    public class Asset
    {
        public int Id { get; set; }
        public string AssetNumber { get; set; }
        public string Status { get; set; }
        public DateTime PurchasedDate { get; set; }
        public DateTime? DiscardedDate { get; set; }
        public DateTime? AssignedDate { get; set; }
        public DateTime? LastReturnedDate { get; set; }

        public int TypeId { get; set; }
        public AssetType AssetType { get; set; }
        public IEnumerable<AssignmentHistory> History { get; set; }
    }
}
