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

namespace PetPals.Pages.AnimalExperiences
{
    [Authorize(Policy = "SitterProfile")]
    public class DeleteModel : PageModel
    {
        private readonly PetPals.Data.ApplicationDbContext _context;

        public DeleteModel(PetPals.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AnimalExperience AnimalExperience { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
          

            if (id == null)
            {
                return NotFound();
            }
            //returns the animal to be delete by looping through the database to match it will the ID passed through the parameter
            AnimalExperience = await _context.AnimalExperience
                .Include(a => a.Sitter).FirstOrDefaultAsync(m => m.ExperienceID == id);

            if (AnimalExperience == null)
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
            //finds the animal in the database by looking for the ID passed through the parameter and removes in and saves the database
            AnimalExperience = await _context.AnimalExperience.FindAsync(id);

            if (AnimalExperience != null)
            {
                _context.AnimalExperience.Remove(AnimalExperience);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
