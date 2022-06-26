using HoliDayRental.DAL.Entities;
using HoliDayRental.DAL.Handlers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HoliDayRental.Common.Repositories;

namespace HoliDayRental.DAL.Repositories
{
    public class MembreService : ServiceBase, IMembreRepository<MembreD>
    {
        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM [Membre] WHERE [IdMembre] = @idMembre";
                    SqlParameter p_IdMembre = new SqlParameter() { ParameterName = "idMembre", Value = id };
                    command.Parameters.Add(p_IdMembre);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<MembreD> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdMembre],[Nom],[Prenom],[Email],[Pays],[Telephone],[Login],[Password] FROM [Membre]";
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToMembre(reader);
                }
            }
        }

        public MembreD Get(int idMembre)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdMembre],[Nom],[Prenom],[Email],[Pays],[Telephone],[Login],[Password] FROM [Membre] WHERE [IdMembre] = @idMembre";
                    SqlParameter p_idMembre = new SqlParameter() { ParameterName = "idMembre", Value = idMembre };
                    command.Parameters.Add(p_idMembre);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    return null;
                }
            }
        }

        public IEnumerable<MembreD> GetByMembreBienEchange(int idBien, DateTime DateDebEchange)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [Membre].[IdMembre],[Nom],[Prenom],[Email],[Pays],[Telephone],[Login],[Password] FROM [Membre] JOIN [MembreBienEchange] ON [Membre].[IdMembre] = [MembreBienEchange].[IdMembre] WHERE [MembreBienEchange].[IdBien] = @idBien AND [MembreBienEchange].[DateDebEchange] = @date";
                    SqlParameter p_idBien = new SqlParameter() { ParameterName = "idBien", Value = idBien };
                    command.Parameters.Add(p_idBien);
                    SqlParameter p_date = new SqlParameter() { ParameterName = "date", Value = DateDebEchange };
                    command.Parameters.Add(p_date);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToMembre(reader);
                }
            }
        }

        public MembreD GetByMembreEchangeBienId(int membrebienechangeId)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [Membre].[IdMembre],[Nom],[Prenom],[Email],[Pays],[Telephone],[Login],[Password] FROM [Membre] JOIN [MembreBienEchange] ON [Membre].[IdMembre] = [IdMembre] WHERE [MembreBienEchange].[IdMembre] = @idMembre";
                    SqlParameter p_idMembre = new SqlParameter() { ParameterName = "idMembre", Value = membrebienechangeId };
                    command.Parameters.Add(p_idMembre);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()) return Mapper.ToMembre(reader);
                    return null;

                }
            }
        }

        public IEnumerable<MembreD> GetByBienEchange(int idBien)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [Membre].[IdMembre],[Nom],[Prenom],[Email],[Pays],[Telephone],[Login],[Password] FROM [Membre] JOIN [MembreBienEchange] ON [Membre].[IdMembre] = [MembreBienEchange].[IdMembre] WHERE [MembreBienEchange].[IdBien] = @idBien";
                    SqlParameter p_idBien = new SqlParameter() { ParameterName = "idBien", Value = idBien };
                    command.Parameters.Add(p_idBien);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToMembre(reader);


                }
            }
        }

        public int Insert(MembreD entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO [Membre]([Nom],[Prenom],[Email],[Pays],[Telephone],[Login],[Password]) OUTPUT [inserted].[IdMembre] VALUES (@nom, @prenom, @email, @pays, @telephone, @login, @password)";
                    SqlParameter p_nom = new SqlParameter { ParameterName = "nom", Value = entity.Nom };
                    SqlParameter p_prenom = new SqlParameter { ParameterName = "prenom", Value = entity.Prenom };
                    SqlParameter p_email = new SqlParameter { ParameterName = "email", Value = entity.Email };
                    SqlParameter p_pays = new SqlParameter { ParameterName = "pays", Value = entity.Pays };
                    SqlParameter p_telephone = new SqlParameter { ParameterName = "telephone", Value = entity.Telephone };
                    SqlParameter p_login = new SqlParameter { ParameterName = "login", Value = entity.Login };
                    SqlParameter p_password = new SqlParameter { ParameterName = "password", Value = entity.Password };
                    command.Parameters.Add(p_nom);
                    command.Parameters.Add(p_prenom);
                    command.Parameters.Add(p_email);
                    command.Parameters.Add(p_pays);
                    command.Parameters.Add(p_telephone);
                    command.Parameters.Add(p_login);
                    command.Parameters.Add(p_password);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(int idMembre, MembreD entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE [Membre] SET [Nom] = @nom, [Prenom] = @prenom, [Email] = @email, [Pays] = @pays, [Telephone] = @telephone, [Login] = @login, [Password] = @password WHERE [IdMembre] = @idMembre";
                    SqlParameter p_nom = new SqlParameter { ParameterName = "nom", Value = entity.Nom };
                    SqlParameter p_prenom = new SqlParameter { ParameterName = "prenom", Value = entity.Prenom };
                    SqlParameter p_email = new SqlParameter { ParameterName = "email", Value = entity.Email };
                    SqlParameter p_pays = new SqlParameter { ParameterName = "pays", Value = entity.Pays };
                    SqlParameter p_telephone = new SqlParameter { ParameterName = "telephone", Value = entity.Telephone };
                    SqlParameter p_login = new SqlParameter { ParameterName = "login", Value = entity.Login };
                    SqlParameter p_password = new SqlParameter { ParameterName = "password", Value = entity.Password };
                    SqlParameter p_idMembre = new SqlParameter { ParameterName = "id", Value = idMembre };
                    command.Parameters.Add(p_nom);
                    command.Parameters.Add(p_prenom);
                    command.Parameters.Add(p_email);
                    command.Parameters.Add(p_pays);
                    command.Parameters.Add(p_telephone);
                    command.Parameters.Add(p_login);
                    command.Parameters.Add(p_password);
                    command.Parameters.Add(p_idMembre);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<MembreD> GetByMembreBienEchange(int idBien, int idMembre)
        {
            throw new NotImplementedException();
        }

        public MembreD GetByMembreBienEchangeId(int membrebienechangeId)
        {
            throw new NotImplementedException();
        }
    }
}

