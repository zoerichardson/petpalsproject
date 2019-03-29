using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetPals.Models;

namespace PetPals.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PetPals.Models.Customer> Customer { get; set; }
        public DbSet<PetPals.Models.Sitter> Sitter { get; set; }
        public DbSet<PetPals.Models.Pet> Pet { get; set; }
        public DbSet<PetPals.Models.Service> Service { get; set; }
        public DbSet<PetPals.Models.Review> Review { get; set; }
        public DbSet<PetPals.Models.Booking> Booking { get; set; }
        public DbSet<PetPals.Models.SocialMedia> SocialMedia { get; set; }
        public DbSet<PetPals.Models.AnimalExperience> AnimalExperience { get; set; }

        
        
    }
}
