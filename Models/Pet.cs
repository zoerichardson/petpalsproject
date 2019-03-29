using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PetPals.Models
{
    public class Pet
    {
        [Key]
        public int PetID { get; set; }
        [Required]
        [Display(Name = "Pet Name")]
        public string PetName { get; set; }
        [Required]
        [Display(Name = "Pet")]
        public string PetType { get; set; }
        
        public int CustomerID { get; set; }
        public Customer Owner { get; set; }
    }
}




