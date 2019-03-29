using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetPals.Models
{
    public class AnimalExperience
    {
        [Key]
        public int ExperienceID { get; set; }
        [Display(Name = "Animal Experience")]
        public string AnimalType { get; set; }

        public int SitterID { get; set; }
        public Sitter Sitter { get; set; }
    }
}
