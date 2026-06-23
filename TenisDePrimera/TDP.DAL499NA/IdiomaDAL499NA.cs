using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDP.Servicios499NA;

namespace TDP.DAL499NA
{
    public class IdiomaDAL499NA
    {
        private string cadenaConexion = "Server=.;Database=TenisDePrimera;Trusted_Connection=True;";

        public List<Idioma499NA> ObtenerIdiomas()
        {
            List<Idioma499NA> lista = new List<Idioma499NA>();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand("SP_ObtenerIdiomas", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Idioma499NA
                            {
                                Id_Idioma = Convert.ToInt32(reader["id_idioma"]),
                                Nombre = reader["Nombre"].ToString(),
                                NombreArchivo = reader["NombreArchivo"].ToString()
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}
