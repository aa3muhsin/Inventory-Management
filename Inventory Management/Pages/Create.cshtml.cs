#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Inventory_Management.Data;
using Inventory_Management.Models;

namespace Inventory_Management.Pages
{
    public class CreateModel : PageModel
    {
        private readonly Inventory_Management.Data.InventoryManagementContext _context;

        public CreateModel(Inventory_Management.Data.InventoryManagementContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["TypeId"] = new SelectList(_context.AssetTypes, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Asset Asset { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Assets.Add(Asset);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
