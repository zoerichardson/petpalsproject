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

namespace PetPals.Pages.Customers
{


    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly PetPals.Data.ApplicationDbContext _context;

        public const string SessionKeyCustomerID = "_CustomerID";
        public string SessionInfoCustomerID { get; private set; }


        public const string SessionKeyLogIn = "_LogIn";
        public string SessionInfo_LogIn { get; private set; }

        public CreateModel(PetPals.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }


        [BindProperty]
        public Customer Customer { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //set customer ID to that in the session variable so that it matches the customers ID 
            //for their email address rather than generating a new one
                int CustID = Convert.ToInt32(HttpContext.Session.GetString(SessionKeyCustomerID));
                Customer.ID = CustID;

            //settting inital of town entered to uppercase
            Customer.Town = Customer.Town.First().ToString().ToUpper() + Customer.Town.Substring(1);
            //open customer database connection
            _context.Database.OpenConnection();
            try
            {
                //add customer to the database and save changes
                _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Customer ON");//set identity to on
                _context.Customer.Add(Customer);
                await _context.SaveChangesAsync();
                _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Customer OFF");//set identity off
            }
            finally
            {
                //close datbabase connection
                _context.Database.CloseConnection();
            }


            //if customer log in variable is not null then redirect to booking review 
            // - - meaning customer has made a booking and needs to create an account to proceed
            //else return to index page - meaning customer is just logging into their account and have not made a booking
            if (HttpContext.Session.GetString(SessionKeyLogIn) != null)
            {
                return RedirectToPage("../BookingReview");
            }
            else
            {
                return RedirectToPage("./Index");
            }

                
        }
    }
}