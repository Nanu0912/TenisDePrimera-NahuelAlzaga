using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDP.Servicios499NA;

namespace TDP.DAL499NA
{
    public class PerfilesDAL499NA
    {
        private string cadenaConexion499NA = "Server=.;Database=TenisDePrimera;Trusted_Connection=True;";

        public List<Componente499NA> ObtenerListaPlana499NA()
        {
            List<Componente499NA> lista = new List<Componente499NA>();

            string query = "SELECT id_componente, nombre, codigo, es_familia, id_padre FROM PermisoComponente";

            using (SqlConnection conexion499NA = new SqlConnection(cadenaConexion499NA))
            {
                using (SqlCommand comando499NA = new SqlCommand(query, conexion499NA))
                {
                    try
                    {
                        conexion499NA.Open();
                        using (SqlDataReader lector499NA = comando499NA.ExecuteReader())
                        {
                            while (lector499NA.Read())
                            {
                                Componente499NA componente = new Componente499NA
                                {
                                    ID_Componente = Convert.ToInt32(lector499NA["id_componente"]),
                                    Nombre = lector499NA["nombre"].ToString(),
                                    Codigo = lector499NA["codigo"] != DBNull.Value ? lector499NA["codigo"].ToString() : null,
                                    EsFamilia = Convert.ToBoolean(lector499NA["es_familia"]),
                                    ID_Padre = lector499NA["id_padre"] != DBNull.Value ? (int?)Convert.ToInt32(lector499NA["id_padre"]) : null
                                };

                                lista.Add(componente);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error en PerfilesDAL al leer componentes: " + ex.Message);
                    }
                }
            }

            return lista;
        }

        public void InsertarComponente499NA(Componente499NA nuevo)
        {
            string query = "INSERT INTO PermisoComponente (nombre, codigo, es_familia, id_padre) VALUES (@nom, @cod, @esFam, @idPadre)";

            using (SqlConnection con = new SqlConnection(cadenaConexion499NA))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nom", nuevo.Nombre);
                    cmd.Parameters.AddWithValue("@cod", string.IsNullOrEmpty(nuevo.Codigo) ? (object)DBNull.Value : nuevo.Codigo);
                    cmd.Parameters.AddWithValue("@esFam", nuevo.EsFamilia);
                    cmd.Parameters.AddWithValue("@idPadre", nuevo.ID_Padre.HasValue ? (object)nuevo.ID_Padre.Value : DBNull.Value);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarPadre499NA(int idHijo, int? idPadre)
        {
            string query = "UPDATE PermisoComponente SET id_padre = @idPadre WHERE id_componente = @idHijo";

            using (SqlConnection con = new SqlConnection(cadenaConexion499NA))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@idHijo", idHijo);
                    cmd.Parameters.AddWithValue("@idPadre", idPadre.HasValue ? (object)idPadre.Value : DBNull.Value);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarComponente499NA(int idComponente)
        {
            string queryDesvincular = "UPDATE PermisoComponente SET id_padre = NULL WHERE id_padre = @id";
            string queryEliminar = "DELETE FROM PermisoComponente WHERE id_componente = @id";

            using (SqlConnection con = new SqlConnection(cadenaConexion499NA))
            {
                con.Open();
                using (SqlTransaction txn = con.BeginTransaction()) 
                {
                    try
                    {
                        using (SqlCommand cmd1 = new SqlCommand(queryDesvincular, con, txn))
                        {
                            cmd1.Parameters.AddWithValue("@id", idComponente);
                            cmd1.ExecuteNonQuery();
                        }

                        using (SqlCommand cmd2 = new SqlCommand(queryEliminar, con, txn))
                        {
                            cmd2.Parameters.AddWithValue("@id", idComponente);
                            cmd2.ExecuteNonQuery();
                        }

                        txn.Commit();
                    }
                    catch (Exception)
                    {
                        txn.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
