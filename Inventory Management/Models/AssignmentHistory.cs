namespace Inventory_Management.Models
{
    public class AssignmentHistory
    {
        public int Id { get; set; }
        public DateTime AssignedDate { get; set; }
        public DateTime? UnAssignedDate { get; set; }
        
        public int AssetId { get; set; }
        public Asset Asset { get; set; }
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
    }
}
