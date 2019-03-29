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

namespace PetPals.Pages
{
 
    public class ProfileModel : PageModel
    {
        private readonly PetPals.Data.ApplicationDbContext _context;

        public const string SessionKeySelectedSitterID = "_SelectedSitterID";
        public const string SessionKeySelectedSitterFullname = "_Fullname";
        public const string SessionKeySelectedSitterTown = "_Town";
        public const string SessionKeySelectedSitterDescription = "_Description";
        public const string SessionKeySelectedSitterPhonenumber = "_Phonenumber";


        public string SessionInfoSelectedSitterID { get; private set; }
        public string SessionInfoSelectedSitterFullname { get; private set; }
        public string SessionInfoSelectedSitterTown { get; private set; }
        public string SessionInfoSelectedSitterDescription { get; private set; }
        public string SessionInfoSelectedSitterPhonenumber { get; private set; }


        public const string SessionKeyLoggedIn = "_LoggedIn";
        public string SessionInfo_LoggedIn { get; private set; }

        public const string SessionKeyLogIn = "_LogIn";
        public string SessionInfo_LogIn { get; private set; }

        public const string SessionKeyPrice = "_Price";
        public string SessionInfo_Price { get; private set; }

        public const string SessionKeyServiceChoice = "_ServiceChoice";
        public string SessionInfo_ServiceChoice { get; private set; }

        public ProfileModel(PetPals.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Sitter Sitter { get; set; }
        public IList<Sitter> Sitters { get; set; }
        public Service Service { get; set; }
        public IList<Service> Services { get; set; }
        public Review Review { get; set; }
        public IList<Review> Reviews { get; set; }
        public Customer Customer { get; set; }
        public IList<Customer> Customers { get; set; }
        public IList<SocialMedia> SocialLinks { get; set; }
        public AnimalExperience AnimalExperience { get; set; }
        public IList<AnimalExperience> Experiences { get; set; }

        public async Task OnGetAsync(int? id)
        {
            //this method is called to display the selected sitter profile

            //searching through the database to find the sitter with the ID of that that was passed through the parameter
            Sitter = await _context.Sitter.FirstOrDefaultAsync(m => m.ID == id);
            
            //storing the selected sitters information into session variables
            HttpContext.Session.SetString(SessionKeySelectedSitterID, Sitter.ID.ToString());
            HttpContext.Session.SetString(SessionKeySelectedSitterFullname, Sitter.FullName);
            HttpContext.Session.SetString(SessionKeySelectedSitterDescription, Sitter.Description);
            HttpContext.Session.SetString(SessionKeySelectedSitterTown, Sitter.Town);       
            HttpContext.Session.SetString(SessionKeySelectedSitterPhonenumber, Sitter.Phonenumber);
           
            //listing all the data from the database so that they can be looped through in the cshtml page
            Services = await _context.Service.ToListAsync();
            Reviews = await _context.Review.ToListAsync();
            Customers = await _context.Customer.ToListAsync();
            SocialLinks = await _context.SocialMedia.ToListAsync();
            Experiences = await _context.AnimalExperience.ToListAsync();


        }


        public IActionResult OnPost()
        {
            //storing the customers service chose in a session variable
            var serviceChoice = HttpContext.Session.GetString(SessionKeyServiceChoice);


            //if the customer logged in variable is not null then redirect to booking review
            //else set log in session variable and redirect to login page 
            if (HttpContext.Session.GetString(SessionKeyLoggedIn) != null)
            {
                return RedirectToPage("BookingReview");
            }
            else
            {
                HttpContext.Session.SetString(SessionKeyLogIn, "LogIn");
                return LocalRedirect("/Identity/Account/Login");

            }
          
        }

    }

}
