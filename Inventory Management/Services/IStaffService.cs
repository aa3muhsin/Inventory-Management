using Inventory_Management.Models;

namespace Inventory_Management.Services
{
    public interface IStaffService
    {
        public Task<ICollection<Staff>> GetStaffAsync();
        public Task<IEnumerable<Department>> GetDepartmentsAsync();
        public Task<Staff> AddStaffAsync(Staff staff, Department department);
        public Task<Staff> GetStaffDetails(int id);
        public Task<ICollection<AssignmentHistory>> GetAssignmentHistoryAsync(Staff staff);
        public Task<AssignmentHistory> Unassign(AssignmentHistory history);
        public Task<string> GetCurrentAssignedStaff(Asset asset);
    }
}
