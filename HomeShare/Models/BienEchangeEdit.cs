using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoliDayRental.ASP.Models
{
    public class BienEchangeEdit
    {
        [ScaffoldColumn(false)]
        [Key]
        public int IdBien { get; set; }
        
        [Required]
        [DisplayName("Titre")]
        [DataType(DataType.Text)]
        public string Titre { get; set; }

        [Required]
        [DisplayName("En résumé")]
        [DataType(DataType.Text)]
        public string DescCourte { get; set; }

        [Required]
        [DisplayName("Description complète")]
        [DataType(DataType.Text)]
        public string DescLong { get; set; }

        [Required]
        [DisplayName("Nombre d'hôtes")]
        [DataType(DataType.Text)]
        public int NombrePerson { get; set; }

        [Required]
        [DisplayName("Pays")]
        [DataType(DataType.Text)]
        public int Pays { get; set; }

        [Required]
        [DisplayName("Ville")]
        [DataType(DataType.Text)]
        public string Ville { get; set; }

        [Required]
        [DisplayName("Rue")]
        [DataType(DataType.Text)]
        public string Rue { get; set; }

        [Required]
        [DisplayName("Numero")]
        [DataType(DataType.Text)]
        public string Numero { get; set; }

        [Required]
        [DisplayName("Code postal")]
        [DataType(DataType.Text)]
        public string CodePostal { get; set; }

        [Required]
        [DisplayName("Photo")]
        [DataType(DataType.Text)]
        public string Photo { get; set; }

        [Required]
        [DisplayName("Assurance")]
        public bool AssuranceObligatoire { get; set; }

        [Required]
        [DisplayName("Actif")]
        public bool IsEnabled { get; set; }

        [DisplayName("Date de fin")]
        [DataType(DataType.Date)]
        public DateTime DisabledDate { get; set; }
        
        [Required]
        [DisplayName("Latitude")]
        public string Latitude { get; set; }

        [Required]
        [DisplayName("Longitude")]
        public string Longitude { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DateCreation { get; set; }

        [ScaffoldColumn(false)]
        public int IdMembre { get; set; }
    }
}
