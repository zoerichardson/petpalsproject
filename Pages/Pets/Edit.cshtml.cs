using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetPals.Data;
using PetPals.Models;

namespace PetPals.Pages.Pets
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly PetPals.Data.ApplicationDbContext _context;

        public const string SessionKeyPetID = "_PetID";

        public string SessionInfoPetID { get; private set; }

        public EditModel(PetPals.Data.ApplicationDbContext context)
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

            //returns the pet with the ID that was passed in the parameter
            Pet = await _context.Pet
                .Include(r => r.Owner).FirstOrDefaultAsync(m => m.PetID == id);

            if (Pet == null)
            {
                return NotFound();
            }
            ViewData["CustomerID"] = new SelectList(_context.Customer, "ID", "ID");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            //modifies the selected field in that database that has been changed and saves the database
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Pet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                //if pet does not exist then return not found else throw an exception 
                if (!PetExists(Pet.PetID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        //checks to see if the ID passed in the parameter exists in the pet database
        private bool PetExists(int id)
        {
            return _context.Pet.Any(e => e.PetID == id);
        }
    }
}
