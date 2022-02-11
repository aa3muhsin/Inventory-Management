#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Inventory_Management.Data;
using Inventory_Management.Models;

namespace Inventory_Management.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly Inventory_Management.Data.InventoryManagementContext _context;

        public DetailsModel(Inventory_Management.Data.InventoryManagementContext context)
        {
            _context = context;
        }

        public Asset Asset { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Asset = await _context.Assets
                .Include(a => a.AssetType).FirstOrDefaultAsync(m => m.Id == id);

            if (Asset == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
