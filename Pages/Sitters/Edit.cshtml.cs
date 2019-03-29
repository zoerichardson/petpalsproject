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

namespace PetPals.Pages.Sitters
{
    [Authorize(Policy = "SitterProfile")]
    public class EditModel : PageModel
    {
        private readonly PetPals.Data.ApplicationDbContext _context;

        public const string SessionKeySitterID = "_SitterID";
        public string SessionInfoSitterID { get; private set; }


        public EditModel(PetPals.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Sitter Sitter { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {


            if (id == null)
            {
                return NotFound();
            }
            //returns the sitter with the ID that was passed in the parameter
            Sitter = await _context.Sitter.FirstOrDefaultAsync(m => m.ID == id);

            if (Sitter == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            //modifies the selected field in that database that has been changed and saves the database

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Sitter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                HttpContext.Session.SetString(SessionKeySitterID, Sitter.ID.ToString());/////

            }
            catch (DbUpdateConcurrencyException)
            {

                //if sitter does not exist then return not found else throw an exception 

                if (!SitterExists(Sitter.ID))
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


        //checks to see if the ID passed in the parameter exists in the customer database
        private bool SitterExists(int id)
        {
            return _context.Sitter.Any(e => e.ID == id);
        }
    }
}
