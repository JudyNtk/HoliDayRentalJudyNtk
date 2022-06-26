using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoliDayRental.DAL.Entities;
using HoliDayRental.BLL.Entities;

namespace HoliDayRental.BLL.Handlers
{
    public static class Mapper
    {
        
        public static MembreB ToBLL(this MembreD entity)
        {
            if (entity == null) return null;
            return new MembreB(
                entity.IdMembre,
                entity.Nom,
                entity.Prenom,
                entity.Email,
                entity.Pays,
                entity.Telephone,
                entity.Login,
                entity.Password);
        }

        public static MembreD ToDAL(this MembreB entity)
        {
            if (entity == null) return null;
            return new MembreD
            {
                IdMembre = entity.IdMembre,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                Email = entity.Email,
                Pays = entity.Pays,
                Telephone = entity.Telephone,
                Login = entity.Login,
                Password = entity.Password
            };
        }

        public static BienEchangeB ToBLL(this BienEchangeD entity)
        {
            if (entity == null) return null;
            return new BienEchangeB(
                entity.IdBien,
                entity.Titre,
                entity.DescCourte,
                entity.DescLong,
                entity.NombrePerson,
                entity.Pays,
                entity.Ville,
                entity.Rue,
                entity.Numero,
                entity.CodePostal,
                entity.Photo,
                entity.AssuranceObligatoire,
                entity.IsEnabled,
                entity.DisabledDate,
                entity.Latitude,
                entity.Longitude,
                entity.IdMembre,
                entity.DateCreation
                );          
        }

        public static BienEchangeD ToDAL(this BienEchangeB entity)
        {
            if (entity == null) return null;
            return new BienEchangeD
            {
                IdBien = entity.IdBien,
                Titre = entity.Titre,
                DescCourte = entity.DescCourte,
                DescLong = entity.DescLong,
                NombrePerson = entity.NombrePerson,
                Pays = entity.Pays,
                Ville = entity.Ville,
                Rue = entity.Rue,
                Numero = entity.Numero,
                CodePostal = entity.CodePostal,
                Photo = entity.Photo,
                AssuranceObligatoire = entity.AssuranceObligatoire,
                IsEnabled = entity.IsEnabled,
                DisabledDate = entity.DisabledDate,
                Latitude = entity.Latitude,
                Longitude = entity.Longitude,
                IdMembre = entity.IdMembre,
                DateCreation = entity.DateCreation
            };
        }

        public static MembreBienEchangeB ToBLL(this MembreBienEchangeD entity)
        {
            if (entity == null) return null;
            return new MembreBienEchangeB(
                entity.DateDebEchange,
                entity.DateFinEchange,
                entity.Assurance,
                entity.Valide,
                entity.IdMembre,
                entity.IdBien
            );
        } // pourquoi proposer un constructeur ??? Et pourquoi l'ordre est si important ??

        public static MembreBienEchangeD ToDAL(this MembreBienEchangeB entity)
        {
            if (entity == null) return null;
            return new MembreBienEchangeD
            {
                IdMembre = entity.IdMembre,
                IdBien = entity.IdBien,
                DateDebEchange = entity.DateDebEchange,
                DateFinEchange = entity.DateFinEchange,
                Assurance = entity.Assurance,
                Valide = entity.Valide
            };
        }
    }
}
