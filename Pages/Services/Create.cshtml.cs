using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PetPals.Data;
using PetPals.Models;


namespace PetPals.Pages.Services
{
    [Authorize(Policy = "SitterProfile")]
    public class CreateModel : PageModel
    {
        private readonly PetPals.Data.ApplicationDbContext _context;

        public const string SessionKeyServiceID = "_ServiceID";
        public string SessionInfoServiceID { get; private set; }

        public CreateModel(PetPals.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IActionResult OnGet()//initialise the state of the page
        {
            ViewData["SitterID"] = new SelectList(_context.Sitter, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Service Service { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {

            //saves the service to the database and returns to the index page
            if (!ModelState.IsValid)
            {
                return Page();
            }

                _context.Service.Add(Service);
                await _context.SaveChangesAsync();

            return RedirectToPage("./Index");            
          
        }
    }
}