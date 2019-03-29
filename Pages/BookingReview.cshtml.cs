using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PetPals.Models;

namespace PetPals.Pages
{
    [Authorize]
    public class BookingReviewModel : PageModel
    {
        private readonly PetPals.Data.ApplicationDbContext _context;

        public const string SessionKeyServiceChoice = "_ServiceChoice";
        public string SessionInfo_ServiceChoice { get; private set; }

        public const string SessionKeyPrice = "_Price";
        public string SessionInfo_Price { get; private set; }

        public const string SessionKeyDate = "_Date";
        public string SessionInfoDate { get; private set; }

        public const string SessionKeyTime = "_Time";
        public string SessionInfoTime { get; private set; }

        public Customer Customer { get; set; }
        public IList<Customer> Customers { get; set; }
        public IList<Pet> Pets { get; set; }
        public Service Service { get; set; }
        public IList<Service>  Services { get; set; }
        public Sitter Sitter { get; set; }


        [BindProperty]
        public Input UserInput { get; set; }

        public class Input
        {
            public int SelectedPrice { get; set; }
        }

        public BookingReviewModel(PetPals.Data.ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task OnGetAsync()
        {
            //lists all the customers, pets and services so that they can be looped through in the cshtml page

            Customers = await _context.Customer.ToListAsync();
            Pets = await _context.Pet.ToListAsync();
            Services = await _context.Service.ToListAsync();

        }

        public IActionResult OnPost()
        {
            //saves the price of the service into a session variable and redirects to the payment page
           
            HttpContext.Session.SetInt32(SessionKeyPrice, UserInput.SelectedPrice);

            return RedirectToPage("Payment");




        }
    }
}