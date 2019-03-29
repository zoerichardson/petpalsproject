using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PetPals.Data;
using PetPals.Models;

namespace PetPals.Pages.Bookings
{
    public class CreateModel : PageModel
    {
        private readonly PetPals.Data.ApplicationDbContext _context;

        public const string SessionKeyFullname = "_Fullname";
        public const string SessionKeyTown = "_Town";
        public const string SessionKeyServices = "_Services";
        public const string SessionKeyTest = "_test";

        public string SessionInfoFullname { get; private set; }
        public string SessionInfoTown { get; private set; }
        public string SessionInfoServices { get; private set; }
        public string SessionInfoTest { get; private set; }

        public const string SessionKeyServiceChoice = "_ServiceChoice";
        public string SessionInfoServiceChoice { get; private set; }

        public const string SessionKeyLocationChoice = "_Location";
        public string SessionInfoLocationChoice { get; private set; }

        public const string SessionKeyDate = "_Date";
        public string SessionInfoDate { get; private set; }

        public const string SessionKeyTime = "_Time";
        public string SessionInfoTime { get; private set; }


        public CreateModel(PetPals.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public Service Service { get; set; }
        public IList<Service> Services { get; set; }
        public Sitter Sitter { get; set; }
        public IList<Sitter> Sitters { get; set; }


        [BindProperty]
        public UserInput Input { get; set; }

        public class UserInput
        {
            public string SelectedService { get; set; }
            public string SelectedLocation { get; set; }
            public string SelectedDate { get; set; }
            public string SelectedTime { get; set; }
        }

        public void OnGet()
        {


        }

        public IActionResult OnPost()
        {
            //sets the users inputs into session variables and redirects to the search page


            HttpContext.Session.SetString(SessionKeyDate, Input.SelectedDate);
            HttpContext.Session.SetString(SessionKeyTime, Input.SelectedTime);

            Input.SelectedLocation = Input.SelectedLocation.First().ToString().ToUpper() + Input.SelectedLocation.Substring(1);
            HttpContext.Session.SetString(SessionKeyLocationChoice, Input.SelectedLocation);
            HttpContext.Session.SetString(SessionKeyServiceChoice, Input.SelectedService);

            return RedirectToPage("Search");
        }
    }
}