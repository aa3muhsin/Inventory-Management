namespace Inventory_Management.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public IEnumerable<Staff> Staffs { get; set; }
    }
}
