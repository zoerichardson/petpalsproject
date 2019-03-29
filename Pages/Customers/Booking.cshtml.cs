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

namespace PetPals.Pages.Customers
{
    [Authorize]
    public class BookingModel : PageModel
    {
        private readonly PetPals.Data.ApplicationDbContext _context;

        public BookingModel(PetPals.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Booking> Bookings { get;set; }
        public Booking Booking { get; set; }

        public async Task OnGetAsync()
        {
            //returns all the bookings including the customer and sitter
            Bookings = await _context.Booking
                .Include(b => b.Customer)
                .Include(b => b.Sitter).ToListAsync();

           // Bookings = await _context.Customer.ToListAsync();//this one instead
        }
    }
}
