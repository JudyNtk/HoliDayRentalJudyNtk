using HoliDayRental.Common.Repositories;
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
    public class BienEchangeService : ServiceBase, IBienEchangeRepository<BienEchangeD>
    {
        public IEnumerable<BienEchangeD> CinqDernierBiens()
        {
            throw new NotImplementedException();
        }

        public void Delete(int idBien)
        {
            using SqlConnection connection = new SqlConnection(_connString);
            using SqlCommand command = connection.CreateCommand();
            command.CommandText = "DELETE FROM [BienEchange] WHERE [IdBien] = @idBien";
            SqlParameter p_idBien = new SqlParameter("idMembre", idBien);
            command.Parameters.Add(p_idBien);
            connection.Open();
            command.ExecuteNonQuery();
        }

        public IEnumerable<BienEchangeD> Get()
        {
            using SqlConnection connection = new SqlConnection(_connString);
            using SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT [IdBien] [Titre],[DescCourte],[DescLong],[NombrePerson],[Pays],[Ville],[Rue],[Numero],[CodePostal],[Photo],[AssuranceObligatoire],[IsEnabled],[DisabledDate],[Latitude],[Longitude],[IdMembre],[DateCreation] FROM [BienEchange]";
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) yield return Mapper.ToBienEchange(reader);
        }

        public BienEchangeD Get(int idBien)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdBien],[Titre],[DateSortie],[DescCourte],[DescLong],[NombrePerson],[Pays],[Ville],[Rue],[Numero],[CodePostal],[Photo],[AssuranceObligatoire],[IsEnabled],[DisabledDate],[Latitude],[Longitude],[IdMembre],[DateCreation] FROM [BienEchange] WHERE [IdBien = @idBien";
                    SqlParameter p_idBien = new SqlParameter("idBien", idBien);
                    command.Parameters.Add(p_idBien);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return Mapper.ToBienEchange(reader);
                    }
                    return null;
                }
            }
        }

        public BienEchangeD GetByBienEchangeId(int membrebienechangeId)
        {
            using SqlConnection connection = new SqlConnection(_connString);
            using SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT [BienEchange].[IdBien],[Titre],[DescCourte],[DescLong],[NombrePerson],[Pays],[Ville],[Rue],[Numero],[CodePostal],[Photo],[AssuranceObligatoire],[IsEnabled],[DisabledDate],[Latitude],[Longitude],[IdMembre],[DateCreation] FROM [BienEchange] JOIN [MembreBienEchange] ON [BienEchange].[IdBien] = [idBien] WHERE [MembreEchangeBien].[IdBien] = @idBien";
            SqlParameter p_idBien = new SqlParameter("idBien", membrebienechangeId);
            command.Parameters.Add(p_idBien);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read()) return Mapper.ToBienEchange(reader);
            return null;
        }

        public IEnumerable<BienEchangeD> GetByPays(int pays)
        {
            using SqlConnection connection = new SqlConnection(_connString);
            using SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT [IdBien],[Titre],[DescCourte],[DescLong],[NombrePerson],[Pays],[Ville],[Rue],[Numero],[CodePostal],[Photo],[AssuranceObligatoire],[IsEnabled],[DisabledDate],[Latitude],[Longitude],[IdMembre],[DateCreation] FROM [BienEchange] WHERE PAYS([Pays]) = @pays";
            //Parameters...
            SqlParameter p_year = new SqlParameter("pays", pays);
            command.Parameters.Add(p_year);
            connection.Open();
            //Choose Execution method
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) yield return Mapper.ToBienEchange(reader);
        }

        public int Insert(BienEchangeD entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "SP_BienEchange_Insert";
                    SqlParameter p_titre = new SqlParameter("titre", entity.Titre);
                    command.Parameters.Add(p_titre);
                    SqlParameter p_desccourte = new SqlParameter("desccourte", entity.DescCourte);
                    command.Parameters.Add(p_desccourte);
                    SqlParameter p_desclong = new SqlParameter("desclong", entity.DescLong);
                    command.Parameters.Add(p_desclong);
                    SqlParameter p_nombreperson = new SqlParameter("nombreperson", entity.NombrePerson);
                    command.Parameters.Add(p_nombreperson);
                    SqlParameter p_pays = new SqlParameter("pays", entity.Pays);
                    command.Parameters.Add(p_pays);
                    SqlParameter p_ville = new SqlParameter("ville", entity.Ville);
                    command.Parameters.Add(p_ville);
                    SqlParameter p_rue = new SqlParameter("rue", entity.Rue);
                    command.Parameters.Add(p_rue);
                    SqlParameter p_numero = new SqlParameter("numero", entity.Numero);
                    command.Parameters.Add(p_numero);
                    SqlParameter p_codepostal = new SqlParameter("codepostal", entity.CodePostal);
                    command.Parameters.Add(p_codepostal);
                    SqlParameter p_photo = new SqlParameter("photo", entity.Photo);
                    command.Parameters.Add(p_photo);
                    SqlParameter p_assuranceobligatoire = new SqlParameter("assuranceobligatoire", entity.AssuranceObligatoire);
                    command.Parameters.Add(p_assuranceobligatoire);
                    SqlParameter p_isenabled = new SqlParameter("isenabled", entity.IsEnabled);
                    command.Parameters.Add(p_isenabled);
                    SqlParameter p_disableddate = new SqlParameter("disableddate", entity.DisabledDate);
                    command.Parameters.Add(p_disableddate);
                    SqlParameter p_latitude = new SqlParameter("latitude", entity.Latitude);
                    command.Parameters.Add(p_latitude);
                    SqlParameter p_longitude = new SqlParameter("longitude", entity.Longitude);
                    command.Parameters.Add(p_longitude);
                    SqlParameter p_idmembre = new SqlParameter("idmembre", entity.IdMembre);
                    command.Parameters.Add(p_idmembre);
                    SqlParameter p_datecreation = new SqlParameter("datecreation", entity.DateCreation);
                    command.Parameters.Add(p_datecreation);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(int idBien, BienEchangeD entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE [BienEchange] SET [Titre] = @titre,[DescCourte] = @desccourte,[DescLong] = @desclong,[NombrePerson] = @nombreperson,[Pays] = @pays,[Ville] = @ville,[Rue] = @rue,[Numero] = @numero,[CodePostal] = @codepostal,[Photo] = @photo,[AssuranceObligatoire] = @assuranceobligatoire,[IsEnabled] = @isenabled,[DisabledDate] = @disableddate,[Latitude] = @latitude,[Longitude] = @longitude,[IdMembre] = @idmembre,[DateCreation] = @datecreation WHERE [IdBien] = @idBien";
                    //Parameters...
                    SqlParameter p_titre = new SqlParameter("titre", entity.Titre);
                    command.Parameters.Add(p_titre);
                    SqlParameter p_desccourte = new SqlParameter("desccourte", entity.DescCourte);
                    command.Parameters.Add(p_desccourte);
                    SqlParameter p_desclong = new SqlParameter("desclong", entity.DescLong);
                    command.Parameters.Add(p_desclong);
                    SqlParameter p_nombreperson = new SqlParameter("nombreperson", entity.NombrePerson);
                    command.Parameters.Add(p_nombreperson);
                    SqlParameter p_pays = new SqlParameter("pays", entity.Pays);
                    command.Parameters.Add(p_pays);
                    SqlParameter p_ville = new SqlParameter("ville", entity.Ville);
                    command.Parameters.Add(p_ville);
                    SqlParameter p_rue = new SqlParameter("rue", entity.Rue);
                    command.Parameters.Add(p_rue);
                    SqlParameter p_numero = new SqlParameter("numero", entity.Numero);
                    command.Parameters.Add(p_numero);
                    SqlParameter p_codepostal = new SqlParameter("codepostal", entity.CodePostal);
                    command.Parameters.Add(p_codepostal);
                    SqlParameter p_photo = new SqlParameter("photo", entity.Photo);
                    command.Parameters.Add(p_photo);
                    SqlParameter p_assuranceobligatoire = new SqlParameter("assuranceobligatoire", entity.AssuranceObligatoire);
                    command.Parameters.Add(p_assuranceobligatoire);
                    SqlParameter p_isenabled = new SqlParameter("isenabled", entity.IsEnabled);
                    command.Parameters.Add(p_isenabled);
                    SqlParameter p_disableddate = new SqlParameter("disableddate", entity.DisabledDate);
                    command.Parameters.Add(p_disableddate);
                    SqlParameter p_latitude = new SqlParameter("latitude", entity.Latitude);
                    command.Parameters.Add(p_latitude);
                    SqlParameter p_longitude = new SqlParameter("longitude", entity.Longitude);
                    command.Parameters.Add(p_longitude);
                    SqlParameter p_idmembre = new SqlParameter("idmembre", entity.IdMembre);
                    command.Parameters.Add(p_idmembre);
                    SqlParameter p_datecreation = new SqlParameter("datecreation", entity.DateCreation);
                    command.Parameters.Add(p_datecreation);
                    SqlParameter p_idBien = new SqlParameter("idBien", idBien);
                    command.Parameters.Add(p_idBien);
                    connection.Open();
                    //Choose Execution method
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
