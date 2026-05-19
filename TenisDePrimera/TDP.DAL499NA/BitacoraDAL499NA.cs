using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDP.BE499NA;

namespace TDP.DAL499NA
{
    public class BitacoraDAL499NA
    {
        public void InsertarBitacora499NA(BitacoraBE499NA be)
        {
            string cadenaConexion = "Server=.\\SQLEXPRESS;Database=TenisDePrimera;Trusted_Connection=True;";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand("SP_InsertarBitacora", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    
                    cmd.Parameters.AddWithValue("@NombreUsuario", be.NombreUsuario499NA);
                    cmd.Parameters.AddWithValue("@Modulo", be.Modulo499NA);
                    cmd.Parameters.AddWithValue("@Evento", be.Evento499NA);
                    cmd.Parameters.AddWithValue("@Criticidad", be.Criticidad499NA);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<BitacoraBE499NA> ListarBitacoraFiltrada499NA(string nombre, string apellido, string usuario, string modulo, string evento, int? criticidad, DateTime inicio, DateTime fin)
        {
            List<BitacoraBE499NA> lista = new List<BitacoraBE499NA>();
            
            string query = @"SELECT B.*, U.Nombre, U.Apellido 
                     FROM Bitacora B 
                     INNER JOIN Usuarios U ON B.NombreUsuario = U.NombreUsuario
                     WHERE B.Fecha BETWEEN @inicio AND @fin
                     AND (@nom IS NULL OR U.Nombre LIKE '%' + @nom + '%')
                     AND (@ape IS NULL OR U.Apellido LIKE '%' + @ape + '%')
                     AND (@usr IS NULL OR B.NombreUsuario LIKE '%' + @usr + '%')
                     AND (@mod IS NULL OR B.Modulo LIKE '%' + @mod + '%')
                     AND (@crit IS NULL OR B.Criticidad = @crit)";
           
            return lista;
        }

        public List<BitacoraBE499NA> ListarBitacoraFiltrada499NA(string nombre, string apellido, string usuario, string modulo, int? criticidad, DateTime inicio, DateTime fin)
        {
            throw new NotImplementedException();
        }
    }
}
