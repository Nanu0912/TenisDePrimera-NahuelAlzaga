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
            List<Componente499NA> listaPlana = perfilesDAL.ObtenerListaPlana499NA();

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

        public List<Componente499NA> ObtenerListaPlanaParaCombo()
        {
            return perfilesDAL.ObtenerListaPlana499NA();
        }

        public void GuardarNuevoComponente499NA(Componente499NA nuevo)
        {
            if (string.IsNullOrEmpty(nuevo.Nombre))
                throw new Exception("El nombre del componente no puede estar vacío.");

            perfilesDAL.InsertarComponente499NA(nuevo);
        }

        public void EliminarComponente499NA(int idComponente)
        {
            perfilesDAL.EliminarComponente499NA(idComponente);
        }

        public void AsignarHijoAPadre499NA(int idHijo, int idPadre)
        {
            if (idHijo == idPadre)
                throw new Exception("Un componente no puede asignarse como hijo de sí mismo.");

            perfilesDAL.ActualizarPadre499NA(idHijo, idPadre);
        }

        public void QuitarHijoDePadre499NA(int idHijo)
        {
            perfilesDAL.ActualizarPadre499NA(idHijo, null);
        }
    }
}
