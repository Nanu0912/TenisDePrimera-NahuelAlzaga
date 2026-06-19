using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDP.DAL499NA;
using TDP.Servicios499NA;

namespace TDP.BLL499NA
{
    public class PerfilesBLL499NA
    {
        private PerfilesDAL499NA perfilesDAL = new PerfilesDAL499NA();

        /// <summary>
        /// Levanta todos los componentes de la base de datos y los estructura como un árbol recursivo.
        /// </summary>
        public List<Componente499NA> ObtenerArbolDePermisos()
        {
            // 1. Buscamos la lista plana real desde la nueva tabla de la DAL
            List<Componente499NA> listaPlana = perfilesDAL.ObtenerListaPlana();

            // 2. Diccionario indexado por ID para enlazar los nodos de manera eficiente
            var diccionario = listaPlana.ToDictionary(x => x.ID_Componente);
            List<Componente499NA> raices = new List<Componente499NA>();

            // 3. Recorremos los elementos construyendo las relaciones Padre e Hijo
            foreach (var item in listaPlana)
            {
                if (item.ID_Padre.HasValue && diccionario.ContainsKey(item.ID_Padre.Value))
                {
                    // Si tiene padre, lo metemos en la lista interna de ese componente padre
                    diccionario[item.ID_Padre.Value].AgregarHijo(item);
                }
                else
                {
                    // Si no tiene padre asignado (es NULL), es un Perfil Raíz (Ej: Administrador, Operador)
                    raices.Add(item);
                }
            }

            return raices; // Retorna únicamente las Familias principales con sus hijos ya estructurados
        }
    }
}
