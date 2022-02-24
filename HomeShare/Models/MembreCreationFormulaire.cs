﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoliDayRental.ASP.Models
{
    public class MembreCreationFormulaire
    { 
        [Required]
        [DisplayName("Prénom")]
        public string Prenom { get; set; }
        [Required]
        [DisplayName("Nom")]
        public string Nom { get; set; }
        [Required]
        //[DataType(DataType.Date)]
        [DisplayName("Email")]
        public string Email { get; set; }
        [Required]
        [DisplayName("Pays")]
        public int Pays { get; set; }
        [Required]
        [DisplayName("Téléphone")]
        public string Telephone { get; set; }
        [Required]
        [DisplayName("Login")]
        public string Login { get; set; }
        [Required]
        [DisplayName("Mot de passe")]
        public string Password { get; set; }
    }   
}
