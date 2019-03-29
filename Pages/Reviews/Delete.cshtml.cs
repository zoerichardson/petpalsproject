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

namespace PetPals.Pages.Reviews
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
        public Review Review { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //returns the review to be deleted by looping through the database to match it will the ID passed through the parameter
            Review = await _context.Review
                .Include(r => r.Customer)
                .Include(r => r.Sitter).FirstOrDefaultAsync(m => m.ReviewID == id);

            if (Review == null)
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
            //finds the review in the database by looking for the ID passed through the parameter and removes in and saves the database
            Review = await _context.Review.FindAsync(id);

            if (Review != null)
            {
                _context.Review.Remove(Review);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./CustomerReview");
        }
    }
}
