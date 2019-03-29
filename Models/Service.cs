using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetPals.Models
{

    public class Service
    {
        [Key]
        public int  ServiceID { get; set; }
        public string ServiceType { get; set; }
        public float Price{ get; set; }

        public int SitterID { get; set; }
        public Sitter Sitter { get; set; }


    }
}
