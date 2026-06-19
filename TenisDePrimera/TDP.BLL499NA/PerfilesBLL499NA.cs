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

        public List<Componente499NA> ObtenerArbolDePermisos()
        {
            List<Componente499NA> listaPlana = perfilesDAL.ObtenerListaPlana();

            var diccionario = listaPlana.ToDictionary(x => x.ID_Componente);
            List<Componente499NA> raices = new List<Componente499NA>();

            foreach (var item in listaPlana)
            {
                if (item.ID_Padre.HasValue && diccionario.ContainsKey(item.ID_Padre.Value))
                {
                    diccionario[item.ID_Padre.Value].AgregarHijo(item);
                }
                else
                {
                    raices.Add(item);
                }
            }

            return raices; 
        }
    }
}
