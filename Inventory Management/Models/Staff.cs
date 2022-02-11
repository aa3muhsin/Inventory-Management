namespace Inventory_Management.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string NationalIdentificationNumber { get; set; }
        public string Name { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public IEnumerable<AssignmentHistory> AssignmentHistory { get; set; }
    }
}
