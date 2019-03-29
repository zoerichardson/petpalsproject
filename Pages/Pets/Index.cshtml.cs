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

namespace PetPals.Pages.Pets
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly PetPals.Data.ApplicationDbContext _context;

        public IndexModel(PetPals.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Pet Pet { get; set; }
        public IList<Pet> Pets { get;set; }

        public async Task OnGetAsync()
        {
            //returns all the pets in the database to be looped through in the cshtml
            Pets = await _context.Pet.ToListAsync();

        }
    }
}
