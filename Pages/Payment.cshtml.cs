using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PetPals.Models;
using Microsoft.AspNetCore.Http;
using PayPal.v1.Orders;
using PayPal.v1.CustomerDisputes;
using Microsoft.AspNetCore.Authorization;

namespace PetPals.Pages
{
    [Authorize]
    public class PaymentModel : PageModel
    {
        private readonly PetPals.Data.ApplicationDbContext _context;

        public const string SessionKeyCustomerID = "_CustomerID";
        public string SessionInfoCustomerID { get; private set; }

        public const string SessionKeySelectedSitterID = "_SelectedSitterID";
        public string SessionInfoSelectedSitterID { get; private set; }

        public const string SessionKeyServiceChoice = "_ServiceChoice";
        public string SessionInfo_ServiceChoice { get; private set; }

        public const string SessionKeyPrice = "_Price";
        public string SessionInfo_Price { get; private set; }

        public const string SessionKeyDate = "_Date";
        public string SessionInfoDate { get; private set; }

        public const string SessionKeyTime = "_Time";
        public string SessionInfoTime { get; private set; }

        public const string SessionKeyCardNo = "_CardNo";
        public string SessionInfoCardNo { get; private set; }


        public PaymentModel(PetPals.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }
        public IList<Customer> Customers { get; set; }

        [BindProperty]
        public Booking Booking { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            //loops through the database to find a customer that matches the customer ID stored in the session variable
            
            Customer = await _context.Customer.FirstOrDefaultAsync(m => m.ID == Convert.ToInt32(HttpContext.Session.GetString(SessionKeyCustomerID)));

            //stored the customers card number into a session variable
            HttpContext.Session.SetString(SessionKeyCardNo, Customer.CardNumber.ToString());
            return Page();

        }

        
        public async Task<IActionResult> OnPostCardPaymentAsync()
        { 
            //this method is called if the cusstomer is making a regular payment from their card
            //storing the booking information into the booking database.

            var service = HttpContext.Session.GetString(SessionKeyServiceChoice);
            var price = HttpContext.Session.GetInt32(SessionKeyPrice);
            var date = HttpContext.Session.GetString(SessionKeyDate);
            var time = HttpContext.Session.GetString(SessionKeyTime);

            Booking.CustomerID = Convert.ToInt32(HttpContext.Session.GetString(SessionKeyCustomerID));
            Booking.SitterID = Convert.ToInt32(HttpContext.Session.GetString(SessionKeySelectedSitterID));

            Booking.TotalCost = Convert.ToInt32(price);
            Booking.Date = date;
            Booking.Time = time;
            Booking.Service = service;
      
                if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Booking.Add(Booking);
            await _context.SaveChangesAsync();

            return RedirectToPage("OrderComplete");

        }

      


    }
}