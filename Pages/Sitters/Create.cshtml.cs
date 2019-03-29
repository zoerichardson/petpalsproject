using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetPals.Data;
using PetPals.Models;

namespace PetPals.Pages.Sitters
{
    [Authorize(Policy = "SitterProfile")]
    public class CreateModel : PageModel
    {
        private readonly PetPals.Data.ApplicationDbContext _context;

        public const string SessionKeySitterID = "_SitterID";
        public string SessionInfoSitterID { get; private set; }

        public CreateModel(PetPals.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Sitter Sitter { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {  
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //set sitter ID to that in the session variable so that it matches the sitter ID 
            //for their email address rather than generating a new one
            int SitterID = Convert.ToInt32(HttpContext.Session.GetString(SessionKeySitterID));
            Sitter.ID = SitterID;

            //settting inital of town entered to uppercase
            Sitter.Town = Sitter.Town.First().ToString().ToUpper() + Sitter.Town.Substring(1);

            //open sitter database connection
            _context.Database.OpenConnection();
            try
            {
                //add sitter to the database and save changes
                _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Sitter ON");//set identity to on
                _context.Sitter.Add(Sitter);
            await _context.SaveChangesAsync();
                _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Sitter OFF");//set identity off
            }
            finally
            {
                //close database connection
                _context.Database.CloseConnection();
            }
            return RedirectToPage("./Index");
        }
    }
}