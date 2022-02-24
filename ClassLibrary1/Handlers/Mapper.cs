using HoliDayRental.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.DAL.Handlers
{
    public static class Mapper 
    {
        public static Membre ToMembre(IDataRecord record)
        {
            if (record is null) return null;
            return new Membre
            {
                IdMembre = (int)record[nameof(Membre.IdMembre)],
                Nom = (string)record[nameof(Membre.Nom)],
                Prenom = (string)record[nameof(Membre.Prenom)],
                Email = (string)record[nameof(Membre.Email)],
                Pays = (int)record[nameof(Membre.Pays)],
                Telephone = (string)record[nameof(Membre.Telephone)],
                Login = (string)record[nameof(Membre.Login)],
                Password = (string)record[nameof(Membre.Password)]
            };
        }

        public static BienEchange ToBienEchange(IDataRecord record)
        {
            if (record is null) return null;
            return new BienEchange
            {
                IdBien = (int)record[nameof(BienEchange.IdBien)],
                Titre = (string)record[nameof(BienEchange.Titre)],
                DescCourte = (string)record[nameof(BienEchange.DescCourte)],
                DescLong = (string)record[nameof(BienEchange.DescLong)],
                NombrePerson = (int)record[nameof(BienEchange.NombrePerson)],
                Pays = (int)record[nameof(BienEchange.Pays)],
                Ville = (string)record[nameof(BienEchange.Ville)],
                Rue = (string)record[nameof(BienEchange.Rue)],
                Numero = (string)record[nameof(BienEchange.Numero)],
                CodePostal = (string)record[nameof(BienEchange.CodePostal)],
                Photo = (string)record[nameof(BienEchange.Photo)],
                AssuranceObligatoire = (bool)record[nameof(BienEchange.AssuranceObligatoire)],
                IsEnabled = (bool)record[nameof(BienEchange.IsEnabled)],
                DisabledDate = (DateTime)record[nameof(BienEchange.DisabledDate)],
                Latitude = (string)record[nameof(BienEchange.Latitude)],
                Longitude = (string)record[nameof(BienEchange.Longitude)],
                IdMembre = (int)record[nameof(BienEchange.IdMembre)],
                DateCreation = (DateTime)record[nameof(BienEchange.DateCreation)]

            };
        }

        internal static Membre ToCinema(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public static AvisMembreBien ToAvisMembreBien(IDataRecord record)
        {
            if (record is null) return null;
            return new AvisMembreBien
            {
                IdAvis = (int)record[nameof(AvisMembreBien.IdAvis)],
                Note = (int)record[nameof(AvisMembreBien.Note)],
                Message = (string)record[nameof(AvisMembreBien.Message)],
                IdMembre = (int)record[nameof(AvisMembreBien.IdMembre)],
                IdBien = (int)record[nameof(AvisMembreBien.IdBien)],
                DateAvis = (DateTime)record[nameof(AvisMembreBien.DateAvis)],
                Approuve = (bool)record[nameof(AvisMembreBien.Approuve)]

            };
        }

        public static MembreBienEchange ToMembreBienEchange(IDataRecord record)
        {
            if (record is null) return null;
            return new MembreBienEchange
            {
                IdMembre = (int)record[nameof(MembreBienEchange.IdMembre)],
                IdBien = (int)record[nameof(MembreBienEchange.IdBien)],
                DateDebEchange = (DateTime)record[nameof(MembreBienEchange.DateDebEchange)],
                DateFinEchange = (DateTime)record[nameof(MembreBienEchange.DateFinEchange)],
                Assurance = (bool)record[nameof(MembreBienEchange.Assurance)],
                Valide = (bool)record[nameof(MembreBienEchange.Valide)]
            };
        }

        public static OptionsBien ToOptionsBien(IDataRecord record)
        {
            if (record is null) return null;
            return new OptionsBien
            { 
                IdOption = (int)record[nameof(OptionsBien.IdOption)],
                IdBien = (int)record[nameof(OptionsBien.IdBien)],
                Valeur = (string)record[nameof(OptionsBien.)]
            };
        }

        public static Options ToOptions(IDataRecord record)
        {
            if (record is null) return null;
            return new Options
            {
                IdOption = (int)record[nameof(OptionsBien.IdOption)],
                Libelle = (string)record[nameof(OptionsBien.Libelle)]
            };
        }

        public static Pays ToPays(IDataRecord record)
        {
            if (record is null) return null;
            return new Pays
            { 
                IdPays = (int)record[nameof(Pays.IdPays)],
                Libelle = (string)record[nameof(OptionsBien.Libelle)]
            };
        }
    }
}
