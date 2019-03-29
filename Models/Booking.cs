using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetPals.Models
{
    public class Booking 
    {
        public int BookingID { get; set; }
        public int TotalCost { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Service { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public int SitterID { get; set; }
        public Sitter Sitter { get; set; }



    }
}
