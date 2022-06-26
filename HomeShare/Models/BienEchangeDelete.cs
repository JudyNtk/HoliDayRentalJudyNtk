using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoliDayRental.ASP.Models
{
    public class BienEchangeDelete
    {
        [ScaffoldColumn(false)]
        [Key]
        public int IdBien { get; set; }

        [DisplayName("Titre")]
        public string Titre { get; set; }

        [DisplayName("En résumé")]
        public string DescCourte { get; set; }

        [DisplayName("Description complète")]
        public string DescLong { get; set; }

        [DisplayName("Nombre d'hôtes")]
        public int NombrePerson { get; set; }

        [DisplayName("Pays")]
        public int Pays { get; set; }

        [DisplayName("Ville")]
        public string Ville { get; set; }

        [DisplayName("Rue")]
        public string Rue { get; set; }

        [DisplayName("Numero")]
        public string Numero { get; set; }

        [DisplayName("Code postal")]
        public string CodePostal { get; set; }

        [DisplayName("Photo")]
        public string Photo { get; set; }

        [ScaffoldColumn(false)]
        [DisplayName("Assurance")]
        public bool AssuranceObligatoire { get; set; }

        [ScaffoldColumn(false)]
        public bool IsEnabled { get; set; }

        [ScaffoldColumn(false)]
        [DataType("datetime-local")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy hh:mm}")]
        public DateTime DisabledDate { get; set; }

        [ScaffoldColumn(false)]
        [DisplayName("Latitude")]
        public string Latitude { get; set; }

        [ScaffoldColumn(false)]
        [DisplayName("Longitude")]
        public string Longitude { get; set; }

        [ScaffoldColumn(false)]
        public int IdMembre { get; set; }
    }
}
