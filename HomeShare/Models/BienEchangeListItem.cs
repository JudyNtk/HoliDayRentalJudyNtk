using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoliDayRental.ASP.Models
{
    public class BienEchangeListItem
    {
        [ScaffoldColumn(false)]
        [Key]
        public int IdBien { get; set; } 

        [DisplayName("Titre")]
        public string Titre { get; set; }

        [DisplayName("En résumé")]
        public string DescCourte { get; set; }

        [DisplayName("Nombre d'hôtes")]
        public int NombrePerson { get; set; }

        [DisplayName("Photo")]
        public string Photo { get; set; }

        [DisplayName("Ville")]
        public string Ville { get; set; }

        [DisplayName("Pays")]
        public int Pays { get; set; }
    }
}
