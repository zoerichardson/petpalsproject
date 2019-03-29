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

namespace PetPals.Pages.Reviews
{
   [Authorize]
    public class CreateModel : PageModel
    {
        private readonly PetPals.Data.ApplicationDbContext _context;

        public const string SessionKeyReviewID = "_ReviewID";
        public string SessionInfoReviewID { get; private set; }


        public CreateModel(PetPals.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            //the list of sitters from the database are put into a viewbag so they can be displayed in a dropdown list of the customer to choose
            //which sitter they are writing the review about
            //ID being what is stored in the database and Firstname being what is displayed in the dropdown list
            ViewData["SitterID"] = new SelectList(_context.Sitter, "ID", "FirstName");
            return Page();
        }

        [BindProperty]
        public Review Review { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            //saves the review to the database and returns to the index page

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Review.Add(Review);
            await _context.SaveChangesAsync();

            return RedirectToPage("./CustomerReview");
        }
    }
}