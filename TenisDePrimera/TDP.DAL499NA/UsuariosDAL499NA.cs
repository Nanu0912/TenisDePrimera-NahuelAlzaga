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
    public class UsuariosDAL499NA
    {
        private static UsuariosDAL499NA instancia499NA = null;

        private string cadenaConexion499NA = "Server=.;Database=TenisDePrimera;Trusted_Connection=True;";
        private UsuariosDAL499NA() { }
        public static UsuariosDAL499NA Instancia499NA
        {
            get
            {
                if (instancia499NA == null)
                {
                    instancia499NA = new UsuariosDAL499NA();
                }
                return instancia499NA;
            }
        }

        public UsuarioBE499NA BuscarPorNombre499NA(string nombreUsuario499NA)
        {
            UsuarioBE499NA usuarioEncontrado499NA = null;

            using (SqlConnection conexion499NA = new SqlConnection(cadenaConexion499NA))
            {
                using (SqlCommand comando499NA = new SqlCommand("SP_Usuario_BuscarPorNombre", conexion499NA))
                {
                    comando499NA.CommandType = CommandType.StoredProcedure;
                    comando499NA.Parameters.AddWithValue("@NombreUsuario", nombreUsuario499NA);

                    conexion499NA.Open();
                    using (SqlDataReader lector499NA = comando499NA.ExecuteReader())
                    {
                        if (lector499NA.Read())
                        {
                            usuarioEncontrado499NA = new UsuarioBE499NA
                            {
                                Dni499NA = lector499NA["DNI"].ToString(),
                                Apellidos499NA = lector499NA["Apellidos"].ToString(),
                                Nombre499NA = lector499NA["Nombre"].ToString(),
                                NombreUsuario499NA = lector499NA["NombreUsuario"].ToString(),
                                Contraseña499NA = lector499NA["Contraseña"].ToString(),
                                Rol499NA = lector499NA["NombreRol"].ToString(),
                                Email499NA = lector499NA["Email"].ToString(),
                                Bloqueo499NA = Convert.ToBoolean(lector499NA["Bloqueo"]),
                                Activo499NA = Convert.ToBoolean(lector499NA["Activo"]),
                                Intentos499NA = Convert.ToInt32(lector499NA["Intentos"])
                            };
                        }
                    }
                }
            }
            return usuarioEncontrado499NA;
        }

        public void InsertarUsuario499NA(UsuarioBE499NA nuevoUsuario499NA)
        {
            using (SqlConnection conexion499NA = new SqlConnection(cadenaConexion499NA))
            {
                using (SqlCommand comando499NA = new SqlCommand("SP_Usuario_Insertar", conexion499NA))
                {
                    comando499NA.CommandType = CommandType.StoredProcedure;
                    comando499NA.Parameters.AddWithValue("@DNI", nuevoUsuario499NA.Dni499NA);
                    comando499NA.Parameters.AddWithValue("@Apellidos", nuevoUsuario499NA.Apellidos499NA);
                    comando499NA.Parameters.AddWithValue("@Nombre", nuevoUsuario499NA.Nombre499NA);
                    comando499NA.Parameters.AddWithValue("@NombreUsuario", nuevoUsuario499NA.NombreUsuario499NA);
                    comando499NA.Parameters.AddWithValue("@Contraseña", nuevoUsuario499NA.Contraseña499NA);
                    comando499NA.Parameters.AddWithValue("@NombreRol", nuevoUsuario499NA.Rol499NA);
                    comando499NA.Parameters.AddWithValue("@Email", nuevoUsuario499NA.Email499NA);

                    conexion499NA.Open();
                    comando499NA.ExecuteNonQuery();
                }
            }
        }

        public void IncrementarIntentos499NA(string loginUsuario499NA)
        {
            using (SqlConnection conexion499NA = new SqlConnection(cadenaConexion499NA))
            {
                using (SqlCommand comando499NA = new SqlCommand("SP_Usuario_IncrementarIntentos", conexion499NA))
                {
                    comando499NA.CommandType = CommandType.StoredProcedure;
                    comando499NA.Parameters.AddWithValue("@NombreUsuario", loginUsuario499NA);
                    conexion499NA.Open();
                    comando499NA.ExecuteNonQuery();
                }
            }
        }
    }
}
