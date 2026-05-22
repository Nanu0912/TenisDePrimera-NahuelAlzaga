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
    public class BitacoraDAL499NA
    {
        private readonly string cnxStr = "Server=.;Database=TenisDePrimera;Trusted_Connection=True;";

        public void InsertarBitacora499NA(BitacoraServicios499NA be)
        {
            using (SqlConnection con = new SqlConnection(cnxStr))
            {
                using (SqlCommand cmd = new SqlCommand("SP_InsertarBitacora", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Mapeo de los 6 parámetros exactos de tu Stored Procedure
                    cmd.Parameters.AddWithValue("@NombreUsuario", be.NombreUsuario499NA);
                    cmd.Parameters.AddWithValue("@Fecha", be.Fecha499NA.Date);
                    cmd.Parameters.AddWithValue("@Hora", be.Hora499NA);
                    cmd.Parameters.AddWithValue("@Modulo", be.Modulo499NA);
                    cmd.Parameters.AddWithValue("@Evento", be.Evento499NA);
                    cmd.Parameters.AddWithValue("@Criticidad", be.Criticidad499NA);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<BitacoraServicios499NA> ListarBitacoraFiltrada499NA(string usr, string mod, int? crit, DateTime ini, DateTime fin)
        {
            List<BitacoraServicios499NA> lista = new List<BitacoraServicios499NA>();
            string cnxStr = "Server=.;Database=TenisDePrimera;Trusted_Connection=True;";

            // SQL LIMPIO: Buscamos únicamente en la tabla Bitacora basándonos en tus columnas reales
            string query = @"SELECT NombreUsuario, Fecha, Hora, Modulo, Evento, Criticidad
                     FROM Bitacora
                     WHERE Fecha BETWEEN @ini AND @fin
                     AND (@usr IS NULL OR NombreUsuario LIKE '%' + @usr + '%')
                     AND (@mod IS NULL OR Modulo LIKE '%' + @mod + '%')
                     AND (@crit IS NULL OR Criticidad = @crit)";

            using (SqlConnection con = new SqlConnection(cnxStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ini", ini);
                    cmd.Parameters.AddWithValue("@fin", fin);
                    cmd.Parameters.AddWithValue("@usr", (object)usr ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@mod", (object)mod ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@crit", (object)crit ?? DBNull.Value);

                    con.Open();
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            BitacoraServicios499NA reg = new BitacoraServicios499NA();

                            // Mapeo seguro contra las columnas reales que vimos en tu base de datos
                            reg.NombreUsuario499NA = r["NombreUsuario"].ToString();
                            reg.Fecha499NA = Convert.ToDateTime(r["Fecha"]);
                            reg.Hora499NA = r["Hora"].ToString();
                            reg.Modulo499NA = r["Modulo"].ToString();
                            reg.Evento499NA = r["Evento"].ToString();
                            reg.Criticidad499NA = Convert.ToInt32(r["Criticidad"]);

                            // Para que las propiedades de la clase no queden en null (y no tire warning), las seteamos vacías
                            reg.Nombre499NA = "";
                            reg.Apellido499NA = "";

                            lista.Add(reg);
                        }
                    }
                }
            }
            return lista;
        }
    }
}
