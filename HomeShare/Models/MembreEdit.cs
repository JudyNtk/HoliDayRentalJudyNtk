using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoliDayRental.ASP.Models
{
    public class MembreEdit
    {
        [Required]
        [DisplayName("Nom")]
        public string Nom { get; set; }

        [Required]
        [DisplayName("Prénom")]
        public string Prenom { get; set; }

        [Required]
        [DisplayName("Email")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        [Required]
        [DisplayName("Pays")]
        public int Pays { get; set; }

        [Required]
        [DisplayName("Telephone")]
        public string Telephone { get; set; }

        [Required]
        [DisplayName("Login")]
        public string Login { get; set; }

        [DisplayName("Changer de mot de passe")]
        public string Password { get; set; }

    }
}
