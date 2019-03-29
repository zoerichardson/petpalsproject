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

    public class IndexModel : PageModel
    {
        private readonly PetPals.Data.ApplicationDbContext _context;

        public IndexModel(PetPals.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Review Review { get; set; }
        public IList<Review> Reviews { get;set; }
        public Sitter Sitter { get; set; }
        public async Task OnGetAsync()
        {
            //returns all the reviews written about the by every customer

            Reviews = await _context.Review
                .Include(r => r.Customer)
                .Include(r => r.Sitter)
                .AsNoTracking()
                .ToListAsync();



        }
    }
}
