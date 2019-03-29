using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetPals.Models
{
    public class Customer : Person
    {
        [Display(Name = "Card Details")]
        public string CardNumber { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + Surname;
            }
        }

        public ICollection<Pet> Pets { get; set; }
        public ICollection<Booking> Bookings { get; set; }

        public ICollection<Review> Reviews { get; set; }
       
    }
}
