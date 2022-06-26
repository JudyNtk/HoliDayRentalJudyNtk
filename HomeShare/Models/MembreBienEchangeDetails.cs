using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoliDayRental.ASP.Models
{
    public class MembreBienEchangeDetails
    {
        [ScaffoldColumn(false)]
        [Key]
        public int IdMembre { get; set; }

        [ScaffoldColumn(false)]
        [Key]
        public int IdBien { get; set; }

        [DisplayName("Date de début du séjour")]
        public DateTime DateDebEchange { get; set; }

        [DisplayName("Date de fin du séjour")]
        public DateTime DateFinEchange { get; set; }

        [DisplayName("Assurance")]
        public bool Assurance { get; set; }

        [DisplayName("Valide")]
        public bool Valide { get; set; }
    }
}
