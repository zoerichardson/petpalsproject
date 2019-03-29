using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using PetPals.Data;
using PetPals.Models;

namespace PetPals.Pages
{
    public class SearchModel : PageModel
    {
        private readonly PetPals.Data.ApplicationDbContext _context;

        public const string SessionKeyServiceChoice = "_ServiceChoice";
        public string SessionInfoServiceChoice { get; private set; }

        public const string SessionKeyLocationChoice = "_Location";
        public string SessionInfoLocationChoice { get; private set; }

        
        
        public SearchModel(PetPals.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            //list all data from databases to they can be looped through in the cshtml
            Services = await _context.Service.ToListAsync();
            Sitters = await _context.Sitter.ToListAsync();
        }

        [BindProperty]
        public Sitter Sitter { get; set; }
        public IList<Sitter> Sitters { get; set; }
        public Service Service { get; set; }

        public IList<Service> Services { get; set; }
    }
}