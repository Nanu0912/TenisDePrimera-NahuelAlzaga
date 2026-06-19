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

        public List<Componente499NA> ObtenerListaPlana()
        {
            List<Componente499NA> lista = new List<Componente499NA>();

            // Consulta SQL limpia para extraer la jerarquía de la tabla Composite
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

                                    // Controlamos los nulos para el código (las familias lo tienen en NULL)
                                    Codigo = lector499NA["codigo"] != DBNull.Value ? lector499NA["codigo"].ToString() : null,

                                    EsFamilia = Convert.ToBoolean(lector499NA["es_familia"]),

                                    // Controlamos los nulos para el padre (los perfiles raíz no tienen padre)
                                    ID_Padre = lector499NA["id_padre"] != DBNull.Value ? (int?)Convert.ToInt32(lector499NA["id_padre"]) : null
                                };

                                lista.Add(componente);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error crítico en PerfilesDAL al leer componentes de seguridad: " + ex.Message);
                    }
                }
            }

            return lista;
        }
    }
}
