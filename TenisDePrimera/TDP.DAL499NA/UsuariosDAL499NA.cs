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

        public UsuarioServicios499NA BuscarPorNombre499NA(string nombreUsuario499NA)
        {
            UsuarioServicios499NA usuarioEncontrado499NA = null;

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
                            usuarioEncontrado499NA = new UsuarioServicios499NA
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

        public void InsertarUsuario499NA(UsuarioServicios499NA nuevoUsuario499NA)
        {
            using (SqlConnection conexion499NA = new SqlConnection(cadenaConexion499NA))
            {
                using (SqlCommand cmd = new SqlCommand("SP_Usuario_Insertar", conexion499NA))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DNI", nuevoUsuario499NA.Dni499NA);
                    cmd.Parameters.AddWithValue("@Apellidos", nuevoUsuario499NA.Apellidos499NA);
                    cmd.Parameters.AddWithValue("@Nombre", nuevoUsuario499NA.Nombre499NA);
                    cmd.Parameters.AddWithValue("@NombreUsuario", nuevoUsuario499NA.NombreUsuario499NA);
                    cmd.Parameters.AddWithValue("@Contraseña", nuevoUsuario499NA.Contraseña499NA);
                    cmd.Parameters.AddWithValue("@NombreRol", nuevoUsuario499NA.Rol499NA);
                    cmd.Parameters.AddWithValue("@Email", nuevoUsuario499NA.Email499NA);

                    conexion499NA.Open();
                    cmd.ExecuteNonQuery();
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

        public void ModificarContraseña499NA(string nombreUsuario499NA, string nuevaClaveHasheada499NA)
        {
            using (SqlConnection conexion499NA = new SqlConnection(cadenaConexion499NA))
            {
                using (SqlCommand comando499NA = new SqlCommand("SP_Usuario_ModificarContraseña", conexion499NA))
                {
                    comando499NA.CommandType = CommandType.StoredProcedure;
                    comando499NA.Parameters.AddWithValue("@NombreUsuario", nombreUsuario499NA);
                    comando499NA.Parameters.AddWithValue("@NuevaContraseña", nuevaClaveHasheada499NA);

                    conexion499NA.Open();
                    comando499NA.ExecuteNonQuery();
                }
            }
        }

        public List<UsuarioServicios499NA> ListarUsuarios499NA(bool mostrarTodos)
        {
            List<UsuarioServicios499NA> lista = new List<UsuarioServicios499NA>();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion499NA))
            {
                using (SqlCommand cmd = new SqlCommand("SP_Usuario_Listar", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MostrarTodos", mostrarTodos);

                    conexion.Open();
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            lista.Add(new UsuarioServicios499NA
                            {
                                Dni499NA = r["DNI"].ToString(),
                                Nombre499NA = r["Nombre"].ToString(),
                                Apellidos499NA = r["Apellidos"].ToString(),
                                NombreUsuario499NA = r["NombreUsuario"].ToString(),
                                Rol499NA = r["NombreRol"].ToString(),
                                Email499NA = r["Email"].ToString(),
                                Bloqueo499NA = Convert.ToBoolean(r["Bloqueo"]),
                                Activo499NA = Convert.ToBoolean(r["Activo"])
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public void DesbloquearUsuario499NA(string nombreUsuario)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion499NA))
            {
                using (SqlCommand cmd = new SqlCommand("SP_Usuario_Desbloqueo", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
