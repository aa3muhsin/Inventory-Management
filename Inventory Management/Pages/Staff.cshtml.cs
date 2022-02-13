using Inventory_Management.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Inventory_Management.Pages
{
    public class StaffModel : PageModel
    {
        private readonly Inventory_Management.Data.InventoryManagementContext _context;

        public StaffModel(Inventory_Management.Data.InventoryManagementContext context)
        {
            _context = context;
        }

        public IList<Staff> Staff { get; set; }

        public async Task OnGetAsync()
        {
            Staff = await _context.Staffs
                .Include(s => s.Department).ToListAsync();
        }
    }
}