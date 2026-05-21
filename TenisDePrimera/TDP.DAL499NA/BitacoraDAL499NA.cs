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
        public void InsertarBitacora499NA(BitacoraServicios499NA be)
        {
            string cadenaConexion = "Server=.;Database=TenisDePrimera;Trusted_Connection=True;";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand("SP_InsertarBitacora", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // CORRECCIÓN: Agregamos todos los parámetros necesarios que el SP exige para no dejar la tabla vacía
                    cmd.Parameters.AddWithValue("@NombreUsuario", be.NombreUsuario499NA);
                    cmd.Parameters.AddWithValue("@Fecha", be.Fecha499NA.Date);
                    cmd.Parameters.AddWithValue("@Hora", be.Hora499NA);
                    cmd.Parameters.AddWithValue("@Modulo", be.Modulo499NA);
                    cmd.Parameters.AddWithValue("@Evento", be.Evento499NA);
                    cmd.Parameters.AddWithValue("@Criticidad", be.Criticidad499NA);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // CORRECCIÓN: Unificamos el método definitivo con la cañería de datos correspondiente
        public List<BitacoraServicios499NA> ListarBitacoraFiltrada499NA(string nombre, string apellido, string usuario, string modulo, int? criticidad, DateTime inicio, DateTime fin)
        {
            List<BitacoraServicios499NA> lista = new List<BitacoraServicios499NA>();
            string cadenaConexion = "Server=.;Database=TenisDePrimera;Trusted_Connection=True;";

            string query = @"SELECT B.NombreUsuario, B.Fecha, B.Hora, B.Modulo, B.Evento, B.Criticidad, 
                            ISNULL(U.Nombre, '') AS NombreReal, 
                            ISNULL(U.Apellido, '') AS ApellidoReal
                     FROM Bitacora B 
                     LEFT JOIN Usuarios U ON B.NombreUsuario = U.NombreUsuario
                     WHERE B.Fecha BETWEEN @inicio AND @fin
                     AND (@nom IS NULL OR U.Nombre LIKE '%' + @nom + '%')
                     AND (@ape IS NULL OR U.Apellido LIKE '%' + @ape + '%')
                     AND (@usr IS NULL OR B.NombreUsuario LIKE '%' + @usr + '%')
                     AND (@mod IS NULL OR B.Modulo LIKE '%' + @mod + '%')
                     AND (@crit IS NULL OR B.Criticidad = @crit)";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@inicio", inicio);
                    cmd.Parameters.AddWithValue("@fin", fin);
                    cmd.Parameters.AddWithValue("@nom", (object)nombre ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@ape", (object)apellido ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@usr", (object)usuario ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@mod", (object)modulo ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@crit", (object)criticidad ?? DBNull.Value);

                    conexion.Open();
                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            BitacoraServicios499NA registro = new BitacoraServicios499NA();
                            registro.NombreUsuario499NA = lector["NombreUsuario"].ToString();
                            registro.Fecha499NA = Convert.ToDateTime(lector["Fecha"]);
                            registro.Hora499NA = lector["Hora"].ToString();
                            registro.Modulo499NA = lector["Modulo"].ToString();
                            registro.Evento499NA = lector["Evento"].ToString();
                            registro.Criticidad499NA = Convert.ToInt32(lector["Criticidad"]);
                            registro.Nombre499NA = lector["NombreReal"].ToString();
                            registro.Apellido499NA = lector["ApellidoReal"].ToString();

                            lista.Add(registro);
                        }
                    }
                }
            }
            return lista;
        }
    }
}
