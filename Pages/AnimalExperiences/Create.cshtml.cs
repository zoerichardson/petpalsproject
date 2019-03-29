using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PetPals.Data;
using PetPals.Models;

namespace PetPals.Pages.AnimalExperiences
{
    [Authorize(Policy = "SitterProfile")]
    public class CreateModel : PageModel
    {
        private readonly PetPals.Data.ApplicationDbContext _context;

        public CreateModel(PetPals.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["SitterID"] = new SelectList(_context.Sitter, "ID", "FirstName");
            return Page();
        }

        [BindProperty]
        public AnimalExperience AnimalExperience { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            //saves the animal experience to the database and returns to the index page

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AnimalExperience.Add(AnimalExperience);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}