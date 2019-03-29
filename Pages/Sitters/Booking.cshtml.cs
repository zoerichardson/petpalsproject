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

namespace PetPals.Pages.Sitters
{
    [Authorize(Policy = "SitterProfile")]
    public class BookingModel : PageModel
    {
        private readonly PetPals.Data.ApplicationDbContext _context;

        public BookingModel(PetPals.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Pet Pet { get; set; }
        public IList<Pet> Pets { get; set; }
        public Customer Customer { get; set; }
        public Booking Booking { get; set; }
        public IList<Booking> Bookings { get; set; }

        public async Task OnGetAsync(int? id)
        {

            //returns all the bookings information, including customer and pet
            Customer = await _context.Customer.FirstOrDefaultAsync(m => m.ID == id);
            Booking = await _context.Booking.FirstOrDefaultAsync(m => m.CustomerID == id);
            Pet = await _context.Pet.FirstOrDefaultAsync(m => m.CustomerID == id);
            Pets = await _context.Pet.ToListAsync();
          
        }
    }
}
