using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoliDayRental.ASP.Models
{
    public class FormulaireConnexion
    {
        [Required]
        [DisplayName("Login : ")]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Password : ")]
        public string Password { get; set; }
    }
}
