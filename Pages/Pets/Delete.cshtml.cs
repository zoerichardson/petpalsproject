using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PetPals.Data;
using PetPals.Models;

namespace PetPals.Pages.Pets
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly PetPals.Data.ApplicationDbContext _context;

        public DeleteModel(PetPals.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Pet Pet { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //returns the pet to be deleted by looping through the database to match it will the ID passed through the parameter
            Pet = await _context.Pet
                .Include(r => r.Owner).FirstOrDefaultAsync(m => m.PetID == id);

            if (Pet == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //finds the pet in the database by looking for the ID passed through the parameter and removes in and saves the database
            Pet = await _context.Pet.FindAsync(id);

            if (Pet != null)
            {
                _context.Pet.Remove(Pet);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
