using HoliDayRental.DAL.Entities;
using HoliDayRental.DAL.Handlers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.DAL.Repositories
{
    class MembreBienEchangeService : ServiceBase, IGetByMembreBienEchangeRepository<MembreBienEchange>
    {
        public void Delete(int idBien, int idMembre)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM [MembreBienEchange] WHERE [IdBien] = @idBien,[IdMembre] = @idMembre";
                    SqlParameter p_idBien = new SqlParameter("idBien", idBien);
                    command.Parameters.Add(p_idBien);
                    SqlParameter p_idMembre = new SqlParameter("idMembre", idMembre);
                    command.Parameters.Add(p_idMembre);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public MembreBienEchange Get(int idBien, int idMembre)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [Id], [Cinema_Id], [Film_Id], [DateDiffusion] FROM [Diffusion] WHERE [Id] = @id";
                    SqlParameter p_idBien = new SqlParameter("idBien", idBien);
                    command.Parameters.Add(p_idBien);
                    SqlParameter p_idMembre = new SqlParameter("idMembre", idMembre);
                    command.Parameters.Add(p_idMembre);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()) return Mapper.ToMembreBienEchange(reader);
                    return null;
                }
            }
        }

        public IEnumerable<MembreBienEchange> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdMembre],[IdBien],[DateDebEchange],[DateFinEchange],[Assurance],[Valide] FROM [MembreBienEchange]";
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToMembreBienEchange(reader);
                }
            }
        }

        public IEnumerable<MembreBienEchange> Get(DateTime date)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdMembre],[IdBien],[DateDebEchange],[DateFinEchange],[Assurance],[Valide] FROM [MembreBienEchange] WHERE [DateDebEchange]=@date,[DateFinEchange]=@date";
                    SqlParameter p_date = new SqlParameter("date", date);
                    command.Parameters.Add(p_date);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToMembreBienEchange(reader);
                }
            }
        }

        public IEnumerable<MembreBienEchange> GetByIdMembre(int idMembre)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdMembre],[IdBien],[DateDebEchange],[DateFinEchange],[Assurance],[Valide] FROM [MembreBienEchange] WHERE [IdMembre]=@membre";
                    SqlParameter p_membre = new SqlParameter("membre", idMembre);
                    command.Parameters.Add(p_membre);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToMembreBienEchange(reader);
                }
            }
        }

        public IEnumerable<MembreBienEchange> GetByIdBien(int idMembre)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdMembre],[IdBien],[DateDebEchange],[DateFinEchange],[Assurance],[Valide] FROM [MembreBienEchange] WHERE [idBien]=@bien";
                    //Parameters...
                    SqlParameter p_bien = new SqlParameter("bien", idBien);
                    command.Parameters.Add(p_bien);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToMembreBienEchange(reader);
                }
            }
        }

        public int Insert(MembreBienEchange entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO [MembreBienEchange]([IdMembre], [IdBien], [DateDebEchange], [DateFinEchange], [Assurance], [Valide]) OUTPUT [inserted].([IdBien],[IdMembre]) VALUES (@membre, @bien, @date)";
                    SqlParameter p_membre = new SqlParameter("membre", entity.IdMembre);
                    command.Parameters.Add(p_membre);
                    SqlParameter p_bien = new SqlParameter("bien", entity.IdBien);
                    command.Parameters.Add(p_bien);
                    SqlParameter p_date = new SqlParameter("date", entity.DateDebEchange);
                    command.Parameters.Add(p_date);
                    SqlParameter p_date = new SqlParameter("date", entity.DateFinEchange);
                    command.Parameters.Add(p_date);
                    SqlParameter p_assurance = new SqlParameter("anssurance", entity.Assurance);
                    command.Parameters.Add(p_assurance);
                    SqlParameter p_valide = new SqlParameter("valide", entity.Valide);
                    command.Parameters.Add(p_valide);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(int id, MembreBienEchange entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE [MembreBienEchange] SET [IdMembre] = @membre, [DateDebEchange] = @date, [DateFinEchange] = @date, [idBien] = @bien WHERE [IdBien] = @idbien,[idMembre] = @idMembre";
                    SqlParameter p_membre = new SqlParameter("membre", entity.IdMembre);
                    command.Parameters.Add(p_membre);
                    SqlParameter p_bien = new SqlParameter("bien", entity.IdBien);
                    command.Parameters.Add(p_bien);
                    SqlParameter p_date = new SqlParameter("date", entity.DateDebEchange);
                    command.Parameters.Add(p_date);
                    SqlParameter p_date = new SqlParameter("date", entity.DateFinEchange);
                    command.Parameters.Add(p_date);
                    SqlParameter p_assurance = new SqlParameter("anssurance", entity.Assurance);
                    command.Parameters.Add(p_assurance);
                    SqlParameter p_valide = new SqlParameter("valide", entity.Valide);
                    command.Parameters.Add(p_valide);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
