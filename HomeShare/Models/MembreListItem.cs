using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        [DisplayName("Nom")]
        public string Nom { get; set; }
        
        [DisplayName("Prénom")]
        public string Prenom { get; set; }

        [ScaffoldColumn(false)]
        [DisplayName("Email")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        [DisplayName("Pays")]
        public int Pays { get; set; }               


        [DisplayName("Telephone")]
        public string Telephone { get; set; }

        [DisplayName("Login")]
        public string Login { get; set; }

        [ScaffoldColumn(false)]
        public string Password { get; set; }

    }
}

