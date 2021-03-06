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
    public class IndexModel : PageModel
    {
        private readonly Inventory_Management.Data.InventoryManagementContext _context;

        public IndexModel(Inventory_Management.Data.InventoryManagementContext context)
        {
            _context = context;
        }

        public IList<Asset> Asset { get;set; }

        public async Task OnGetAsync()
        {
            Asset = await _context.Assets
                .Include(a => a.AssetType).ToListAsync();
        }
    }
}
