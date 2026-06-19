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
                                Intentos499NA = Convert.ToInt32(lector499NA["Intentos"]),
                                IdPermisoRaiz = lector499NA["id_permiso_raiz"] != DBNull.Value ? Convert.ToInt32(lector499NA["id_permiso_raiz"]) : 0
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
                    cmd.Parameters.AddWithValue("@id_permiso_raiz", nuevoUsuario499NA.IdPermisoRaiz);

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


        public void ModificarUsuario499NA(Servicios499NA.UsuarioServicios499NA usr)
        {
            string cadenaConexion = "Data Source=.;Initial Catalog=TenisDePrimera;Integrated Security=True";

  
            int idRolNumerico = 0; 
            if (usr.Rol499NA == "Administrador" || usr.Rol499NA == "Admin" || usr.Rol499NA == "Administrador del Sistema") idRolNumerico = 1;
            else  idRolNumerico = 2;

            using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(cadenaConexion))
            {
                string query = @"UPDATE Usuarios 
                         SET DNI = @dni, 
                             Apellidos = @ape, 
                             Nombre = @nom, 
                             IdRol = @idRol, 
                             Email = @em,
                             id_permiso_raiz = @idPermisoRaiz
                         WHERE NombreUsuario = @usrName";

                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@dni", usr.Dni499NA);          
                    cmd.Parameters.AddWithValue("@ape", usr.Apellidos499NA);    
                    cmd.Parameters.AddWithValue("@nom", usr.Nombre499NA);        
                    cmd.Parameters.AddWithValue("@idRol", idRolNumerico);       
                    cmd.Parameters.AddWithValue("@em", usr.Email499NA);         
                    cmd.Parameters.AddWithValue("@usrName", usr.NombreUsuario499NA);
                    cmd.Parameters.AddWithValue("@idPermisoRaiz", usr.IdPermisoRaiz);

                    try
                    {
                        con.Open();
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas == 0)
                        {
                            throw new Exception("No se encontró el usuario en la base de datos para modificar.");
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error en la base de datos al modificar usuario: " + ex.Message);
                    }
                }
            }
        }

        public void DesbloquearUsuario499NA(string nombreUsuario)
        {
            string cadenaConexion = "Data Source=.;Initial Catalog=TenisDePrimera;Integrated Security=True";

            using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(cadenaConexion))
            {
                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("dbo.SP_Usuario_Desbloqueo", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error en la base de datos al desbloquear: " + ex.Message);
                    }
                }
            }
        }

        public void CambiarEstadoActivo499NA(string nombreUsuario, bool nuevoEstado)
        {
            string cadenaConexion = "Data Source=.;Initial Catalog=TenisDePrimera;Integrated Security=True";

            using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(cadenaConexion))
            {
                string query = @"UPDATE Usuarios 
                         SET Activo = @nuevoEstado 
                         WHERE NombreUsuario = @usrName";

                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nuevoEstado", nuevoEstado);
                    cmd.Parameters.AddWithValue("@usrName", nombreUsuario);

                    try
                    {
                        con.Open();
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas == 0)
                        {
                            throw new Exception("No se encontró el usuario en la base de datos.");
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error en la base de datos al cambiar estado: " + ex.Message);
                    }
                }
            }
        }
    }
}
