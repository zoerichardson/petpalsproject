using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetPals.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Range(1, 5)]
        public int Rating { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public int SitterID { get; set; }
        public Sitter Sitter { get; set; }
    }
}
