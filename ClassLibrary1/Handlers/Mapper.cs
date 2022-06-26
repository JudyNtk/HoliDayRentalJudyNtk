using HoliDayRental.DAL.Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace HoliDayRental.DAL.Handlers
{
    public static class Mapper 
    {
        public static MembreD ToMembre(IDataRecord record)
        {
            if (record is null) return null;
            return new MembreD
            {
                IdMembre = (int)record[nameof(MembreD.IdMembre)],
                Nom = (string)record[nameof(MembreD.Nom)],
                Prenom = (string)record[nameof(MembreD.Prenom)],
                Email = (string)record[nameof(MembreD.Email)],
                Pays = (int)record[nameof(MembreD.Pays)],
                Telephone = (string)record[nameof(MembreD.Telephone)],
                Login = (string)record[nameof(MembreD.Login)],
                Password = (string)record[nameof(MembreD.Password)]
            };
        }

        public static BienEchangeD ToBienEchange(IDataRecord record)
        {
            if (record is null) return null;
            return new BienEchangeD
            {
                IdBien = (int)record[nameof(BienEchangeD.IdBien)],
                Titre = (string)record[nameof(BienEchangeD.Titre)],
                DescCourte = (string)record[nameof(BienEchangeD.DescCourte)],
                DescLong = (string)record[nameof(BienEchangeD.DescLong)],
                NombrePerson = (int)record[nameof(BienEchangeD.NombrePerson)],
                Pays = (int)record[nameof(BienEchangeD.Pays)],
                Ville = (string)record[nameof(BienEchangeD.Ville)],
                Rue = (string)record[nameof(BienEchangeD.Rue)],
                Numero = (string)record[nameof(BienEchangeD.Numero)],
                CodePostal = (string)record[nameof(BienEchangeD.CodePostal)],
                Photo = (string)record[nameof(BienEchangeD.Photo)],
                AssuranceObligatoire = (bool)record[nameof(BienEchangeD.AssuranceObligatoire)],
                IsEnabled = (bool)record[nameof(BienEchangeD.IsEnabled)],
                DisabledDate = (DateTime)record[nameof(BienEchangeD.DisabledDate)],
                Latitude = (string)record[nameof(BienEchangeD.Latitude)],
                Longitude = (string)record[nameof(BienEchangeD.Longitude)],
                IdMembre = (int)record[nameof(BienEchangeD.IdMembre)],
                DateCreation = (DateTime)record[nameof(BienEchangeD.DateCreation)]

            };
        }

        //internal static MembreD ToMembre(SqlDataReader reader)
        //{
        //    throw new NotImplementedException();
        //}

        public static AvisMembreBienD ToAvisMembreBien(IDataRecord record)
        {
            if (record is null) return null;
            return new AvisMembreBienD
            {
                IdAvis = (int)record[nameof(AvisMembreBienD.IdAvis)],
                Note = (int)record[nameof(AvisMembreBienD.Note)],
                Message = (string)record[nameof(AvisMembreBienD.Message)],
                IdMembre = (int)record[nameof(AvisMembreBienD.IdMembre)],
                IdBien = (int)record[nameof(AvisMembreBienD.IdBien)],
                DateAvis = (DateTime)record[nameof(AvisMembreBienD.DateAvis)],
                Approuve = (bool)record[nameof(AvisMembreBienD.Approuve)]

            };
        }

        public static MembreBienEchangeD ToMembreBienEchange(IDataRecord record)
        {
            if (record is null) return null;
            return new MembreBienEchangeD
            {
                IdMembre = (int)record[nameof(MembreBienEchangeD.IdMembre)],
                IdBien = (int)record[nameof(MembreBienEchangeD.IdBien)],
                DateDebEchange = (DateTime)record[nameof(MembreBienEchangeD.DateDebEchange)],
                DateFinEchange = (DateTime)record[nameof(MembreBienEchangeD.DateFinEchange)],
                Assurance = (bool)record[nameof(MembreBienEchangeD.Assurance)],
                Valide = (bool)record[nameof(MembreBienEchangeD.Valide)]
            };
        }

        public static OptionsBienD ToOptionsBien(IDataRecord record)
        {
            if (record is null) return null;
            return new OptionsBienD
            { 
                IdOption = (int)record[nameof(OptionsBienD.IdOption)],
                IdBien = (int)record[nameof(OptionsBienD.IdBien)],
                Valeur = (string)record[nameof(OptionsBienD.Valeur)]
            };
        }

        public static OptionsD ToOptions(IDataRecord record)
        {
            if (record is null) return null;
            return new OptionsD
            {
                IdOption = (int)record[nameof(OptionsD.IdOption)],
                Libelle = (string)record[nameof(OptionsD.Libelle)]
            };
        }

        public static PaysD ToPays(IDataRecord record)
        {
            if (record is null) return null;
            return new PaysD
            { 
                IdPays = (int)record[nameof(PaysD.IdPays)],
                Libelle = (string)record[nameof(PaysD.Libelle)]
            };
        }
    }
}
