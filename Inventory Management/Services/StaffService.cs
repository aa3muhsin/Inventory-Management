using Inventory_Management.Models;

namespace Inventory_Management.Services
{
    public class StaffService : IStaffService
    {
        public Task<Staff> AddStaffAsync(Staff staff, Department department)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<AssignmentHistory>> GetAssignmentHistoryAsync(Staff staff)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetCurrentAssignedStaff(Asset asset)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Department>> GetDepartmentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Staff>> GetStaffAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Staff> GetStaffDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AssignmentHistory> Unassign(AssignmentHistory history)
        {
            throw new NotImplementedException();
        }
    }
}
