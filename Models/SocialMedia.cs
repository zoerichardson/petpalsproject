using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetPals.Models
{
    public class SocialMedia
    {
        public int ID { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }

        public Sitter Sitter { get; set; }
        public int SitterID { get; set; }
    }
}
