using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.BLL.Entities
{
    public class BienEchangeB
    {
        private int v;

        public int IdBien { get; set; }
        public string Titre { get; set; }
        public string DescCourte { get; set; }
        public string DescLong { get; set; }
        public int NombrePerson { get; set; }
        public int Pays { get; set; }
        public string Ville { get; set; }
        public string Rue { get; set; }
        public string Numero { get; set; }
        public string CodePostal { get; set; }
        public string Photo { get; set; }
        public bool AssuranceObligatoire { get; set; }
        public bool IsEnabled { get; set; }
        public DateTime DisabledDate { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int IdMembre { get; set; }
        public DateTime DateCreation { get; set; }
        public MembreB Membre { get; set; }

        public BienEchangeB(int idBien, string titre, string descCourte, string descLong, int nombrePerson,
        int pays, string ville, string rue, string numero, string codePostal, string photo, bool assuranceObligatoire,
        bool isEnabled, DateTime disabledDate, string latitude, string longitude, DateTime dateCreation, MembreB membre)
        {
            IdBien = idBien;
            Titre = titre;
            DescCourte = descCourte;
            DescLong = descLong;
            NombrePerson = nombrePerson;
            Pays = pays;
            Ville = ville;
            Rue = rue;
            Numero = numero;
            CodePostal = codePostal;
            Photo = photo;
            AssuranceObligatoire = assuranceObligatoire;
            IsEnabled = isEnabled;
            DisabledDate = disabledDate;
            Latitude = latitude;
            Longitude = longitude;
            DateCreation = dateCreation;
            Membre = membre;
            if (membre == null) throw new ArgumentNullException(nameof(IdMembre));
            IdMembre = membre.IdMembre;
            
        }
        public BienEchangeB(int idBien, string titre, string descCourte, string descLong, int nombrePerson,
        int pays, string ville, string rue, string numero, string codePostal, string photo, bool assuranceObligatoire,
        bool isEnabled, DateTime disabledDate, string latitude, string longitude, int idMembre, DateTime dateCreation)
        {
            IdBien = idBien;
            Titre = titre;
            DescCourte = descCourte;
            DescLong = descLong;
            NombrePerson = nombrePerson;
            Pays = pays;
            Ville = ville;
            Rue = rue;
            Numero = numero;
            CodePostal = codePostal;
            Photo = photo;
            AssuranceObligatoire = assuranceObligatoire;
            IsEnabled = isEnabled;
            DisabledDate = disabledDate;
            Latitude = latitude;
            Longitude = longitude;
            IdMembre = idMembre;
            DateCreation = dateCreation;
            Membre = null;
         
        }

        public BienEchangeB(int v, string titre, string descCourte, string descLong, int nombrePerson, int pays, string ville, string rue, string numero, string codePostal, string photo, bool assuranceObligatoire, string latitude, string longitude, int idMembre)
        {
            this.v = v;
            Titre = titre;
            DescCourte = descCourte;
            DescLong = descLong;
            NombrePerson = nombrePerson;
            Pays = pays;
            Ville = ville;
            Rue = rue;
            Numero = numero;
            CodePostal = codePostal;
            Photo = photo;
            AssuranceObligatoire = assuranceObligatoire;
            Latitude = latitude;
            Longitude = longitude;
            IdMembre = idMembre;
        }
    }
}





