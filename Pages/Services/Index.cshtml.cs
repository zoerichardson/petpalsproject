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

namespace PetPals.Pages.Services
{
    [Authorize(Policy = "SitterProfile")]
    public class IndexModel : PageModel
    {
        private readonly PetPals.Data.ApplicationDbContext _context;

        public const string SessionKeyServiceID = "_ServiceID";
        public string SessionInfoServiceID { get; private set; }

        public IndexModel(PetPals.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Service Service { get; set; }
        public IList<Service> Services { get;set; }
        public Sitter Sitter { get; set; }

        public async Task OnGetAsync()
        {
            //returns all the all the services to the cshtml page can loop through them

            Services = await _context.Service.ToListAsync();
        }
    }
}
