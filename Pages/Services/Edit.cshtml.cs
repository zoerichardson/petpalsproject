using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetPals.Data;
using PetPals.Models;

namespace PetPals.Pages.Services
{
    [Authorize(Policy = "SitterProfile")]
    public class EditModel : PageModel
    {
        private readonly PetPals.Data.ApplicationDbContext _context;

        public EditModel(PetPals.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Service Service { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //returns the service with the ID that was passed in the parameter
            Service = await _context.Service
                .Include(s => s.Sitter).FirstOrDefaultAsync(m => m.ServiceID == id);

            if (Service == null)
            {
                return NotFound();
            }
           ViewData["SitterID"] = new SelectList(_context.Sitter, "ID", "ID");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //modifies the selected field in that database that has been changed and saves the database
            _context.Attach(Service).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                //if service does not exist then return not found else throw an exception 

                if (!ServiceExists(Service.ServiceID))
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

        //checks to see if the ID passed in the parameter exists in the service database
        private bool ServiceExists(int id)
        {
            return _context.Service.Any(e => e.ServiceID == id);
        }
    }
}
