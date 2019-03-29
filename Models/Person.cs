using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetPals.Models
{
    public class Person
    {
        
        public int ID { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string Surname { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string Town { get; set; }
        [Required]
        public string Postcode { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public string Phonenumber { get; set; }
    }
}
