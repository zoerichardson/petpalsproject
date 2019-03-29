using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PetPals.Data;
using PetPals.Models;


namespace PetPals.Pages.Pets
{
    [Authorize]
    public class CreateModel : PageModel
    {
       
        private readonly PetPals.Data.ApplicationDbContext _context;

        public const string SessionKeyPetID = "_PetID";
        public string SessionInfoPetID { get; private set; }

        public CreateModel(PetPals.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["CustomerID"] = new SelectList(_context.Customer, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Pet Pet { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {

            //saves the pet to the database and returns to the index page
            if (!ModelState.IsValid)
            {
              
                return Page();
            }

            _context.Pet.Add(Pet);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}