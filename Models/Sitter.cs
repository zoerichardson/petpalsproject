using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetPals.Models
{
    public class Sitter : Person
    {
        public string Description { get; set; }
        [Range(0, 5)]
        [Display(Name = "Your Catchment Area (Miles)")]
        public int CatchmentArea { get; set; }
        

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + Surname;
            }
        }

        public ICollection<Service> Services { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Booking> Bookings { get; set; }
        public ICollection<AnimalExperience> AnimalExperiences { get; set; }
    }
}
