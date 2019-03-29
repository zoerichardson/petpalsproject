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
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace PetPals.Pages.Sitters
{
 
    [Authorize(Policy = "SitterProfile")]
    public class IndexModel : PageModel
    {
        private readonly PetPals.Data.ApplicationDbContext _context;

        //session variables for holding logged user data
        public const string SessionKeySitterID = "_SitterID";
        public string SessionInfoSitterID { get; private set; }

        public const string SessionKeyFB = "_FB";
        public string SessionInfoFB { get; private set; }

        public const string SessionKeyTwitter = "_Twitter";
        public string SessionInfoTwitter { get; private set; }

        public const string SessionKeyInstagram = "_Instagram";
        public string SessionInfoInstagram { get; private set; }


        public IndexModel(PetPals.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SocialMedia SocialMedia { get; set; }
        [BindProperty]

        public IList<SocialMedia> Links { get; set; }
        public Sitter Sitter { get; set; }
        public IList<Sitter> Sitters { get;set; }
        public IList<Booking> Bookings { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Sitters = await _context.Sitter.ToListAsync();
            Bookings = await _context.Booking.ToListAsync();

            HttpContext.Session.GetString(SessionKeyFB);
            HttpContext.Session.GetString(SessionKeyTwitter);
            HttpContext.Session.GetString(SessionKeyInstagram);


            SocialMedia = await _context.SocialMedia
            .Include(r => r.Sitter).FirstOrDefaultAsync(m => m.SitterID == Convert.ToInt32(HttpContext.Session.GetString(SessionKeySitterID)));

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Sitters = await _context.Sitter.ToListAsync();
            Bookings = await _context.Booking.ToListAsync();


            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (!SocialMediaExists(SocialMedia.ID))
            {
               
                _context.Database.OpenConnection();
                try
                {
                    //add customer to the database and save changes
                    _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.SocialMedia ON");//set identity to on
                    _context.SocialMedia.Add(SocialMedia);
                    await _context.SaveChangesAsync();
                    _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.SocialMedia OFF");//set identity off
                }
                finally
                {
                    //close datbabase connection
                    _context.Database.CloseConnection();
                }
            }
            else
            {
               
                _context.Attach(SocialMedia).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }        
            return Page();         
        }

        private bool SocialMediaExists(int id)
        {
            return _context.SocialMedia.Any(e => e.ID == id);          
        }




    }
}
