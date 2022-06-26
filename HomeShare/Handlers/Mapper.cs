using HoliDayRental.ASP.Controllers;
using HoliDayRental.ASP.Models;
using HoliDayRental.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoliDayRental.ASP.Handlers
{
    public static class Mapper
    {
        public static MembreListItem ToListItem(this MembreB entity)
        {
            if (entity == null) return null;
            return new MembreListItem
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

        public static MembreDetails ToDetails(this MembreB entity)
        {
            if (entity == null) return null;
            return new MembreDetails
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

        public static MembreEdit ToEdit(this MembreB entity)
        {
            if (entity == null) return null;
            return new MembreEdit
            {
                //IdMembre = entity.IdMembre,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                Email = entity.Email,
                Pays = entity.Pays,
                Telephone = entity.Telephone,
                Login = entity.Login,
                Password = entity.Password
            };
        }

        public static MembreDelete ToDelete(this MembreB entity)
        {
            if (entity == null) return null;
            return new MembreDelete
            {
                //IdMembre = entity.IdMembre,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                //Email = entity.Email,
                //Pays = entity.Pays,
                //Telephone = entity.Telephone,
                Login = entity.Login,
                //Password = entity.Password
            };
        }

        public static BienEchangeListItem ToListItem(this BienEchangeB entity)
        {
            if (entity == null) return null;
            return new BienEchangeListItem
            { 
                IdBien = entity.IdBien,
                Titre = entity.Titre,
                DescCourte = entity.DescCourte,
                Pays = entity.Pays,
                NombrePerson = entity.NombrePerson,
                Photo = entity.Photo,
                Ville = entity.Ville
            };
        }

        public static BienEchangeDetails ToDetails(this BienEchangeB entity)
        {
            if (entity == null) return null;
            return new BienEchangeDetails
            {
                IdBien = entity.IdBien,
                Titre = entity.Titre,
                DescCourte = entity.DescCourte,
                DescLong = entity.DescLong,
                Pays = entity.Pays,
                NombrePerson = entity.NombrePerson,
                Ville = entity.Ville,
                Rue = entity.Rue,
                Numero = entity.Numero,
                CodePostal = entity.CodePostal,
                Photo = entity.Photo,
                AssuranceObligatoire = entity.AssuranceObligatoire,
                Latitude = entity.Latitude,
                Longitude = entity.Longitude,
                IdMembre = entity.IdMembre
                
            };
        }

        public static BienEchangeEdit ToEdit(this BienEchangeB entity)
        {
            if (entity == null) return null;
            return new BienEchangeEdit
            {
                IdBien = entity.IdBien,
                Titre = entity.Titre,
                DescCourte = entity.DescCourte,
                DescLong = entity.DescLong,
                Pays = entity.Pays,
                NombrePerson = entity.NombrePerson,
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
                DateCreation = entity.DateCreation,
                IdMembre = entity.IdMembre
            };
        }

        public static BienEchangeDelete ToDelete(this BienEchangeB entity)
        {
            if (entity == null) return null;
            return new BienEchangeDelete
            {
                IdBien = entity.IdBien,
                Titre = entity.Titre,
                DescCourte = entity.DescCourte,
                DescLong = entity.DescLong,
                Pays = entity.Pays,
                NombrePerson = entity.NombrePerson,
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
                //DateCreation = entity.DateCreation,
                IdMembre = entity.IdMembre
            };
        }

        public static MembreBienEchangeDetails ToDetails(this MembreBienEchangeB entity)
        {
            if (entity == null) return null;
            return new MembreBienEchangeDetails
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
