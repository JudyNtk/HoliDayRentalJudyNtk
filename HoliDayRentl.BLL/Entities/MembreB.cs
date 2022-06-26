using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.BLL.Entities
{
    public class MembreB
    {
        public int IdMembre { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public int Pays { get; set; }
        public string Telephone { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        //public IEnumerable<BienEchange> BienEchanges { get; set; } à ajouter quand j'aurai compris comment l'utiliser !!!


        public MembreB (int idMembre, string nom, string prenom, string email, int pays, 
        string telephone, string login, string password)
        {
            IdMembre = idMembre;
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Pays = pays;
            Telephone = telephone;
            Login = login;
            Password = password;
        }
        //public void AddBienEchange(string titre, string descCourte, string descLong, int nombrePerson,
        //int pays, string ville, string rue, string numero, string codePostal, string photo, bool assuranceObligatoire,
        //bool isEnabled, DateTime disabledDate, string latitude, string longitude, DateTime dateCreation)
        //{
        //    throw new NotImplementedException();
        //}

        //public void CancelBienEchange(string titre, string descCourte, string descLong, int nombrePerson,
        //int pays, string ville, string rue, string numero, string codePostal, string photo, bool assuranceObligatoire,
        //bool isEnabled, DateTime disabledDate, string latitude, string longitude, DateTime dateCreation)
        //{
        //    throw new NotImplementedException();
        //} à ajouter quand j'aurai compris comment l'utiliser correctement !!!

    }
}
