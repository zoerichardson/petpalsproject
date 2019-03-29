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
    public class IndexModel : PageModel
    {
        private readonly PetPals.Data.ApplicationDbContext _context;

        public IndexModel(PetPals.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<AnimalExperience> AnimalExperience { get;set; }

        public async Task OnGetAsync()
        {
            //returns all the animals from the database to be looped through in the cshtml page

            AnimalExperience = await _context.AnimalExperience.ToListAsync();
        }
    }
}
