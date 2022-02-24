using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoliDayRental.ASP.Models
{
    public class MembreListItem
    {
        [ScaffoldColumn(false)]
        [Key]              
        public int IdMembre { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string Email { get; set; }

        public int Pays { get; set; }

        public string Telephone { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }
    }
}
}
