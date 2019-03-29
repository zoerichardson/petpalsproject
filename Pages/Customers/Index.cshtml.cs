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
    public class IndexModel : PageModel
    {
        private readonly PetPals.Data.ApplicationDbContext _context;

        //session variables for holding logged user data
        public const string SessionKeyCustomerID = "_CustomerID";

        public string SessionInfoCustomerID { get; private set; }

        public IndexModel(PetPals.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {

            //returns all the customers in the database to be looped through in the cshtml
            Customer = await _context.Customer.ToListAsync();

        }
    }
}
