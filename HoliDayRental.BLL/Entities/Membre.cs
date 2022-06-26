using System;

namespace HoliDayRental.BLL
{
    public class Membre
    {
        public int IdMembre { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string Email { get; set; }

        public int Pays { get; set; }

        public string Telephone { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public Membre(int idMembre, string nom, string prenom, string email, int pays, string telephone, string login, string password)
        {
            IdMembre = idMembre;
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Pays = pays;
            Telephone = login;
            Password = password;
        }

        //Ajout pour MembreBienEchange
        //public void AddMembreBienEchange(DateTime dateDebEchange, DateTime dateFinEchange)

                
    }

    


}
