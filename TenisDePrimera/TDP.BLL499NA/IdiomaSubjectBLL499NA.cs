using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDP.Servicios499NA;

namespace TDP.BLL499NA
{
    public class IdiomaSubjectBLL499NA
    {
        private static IdiomaSubjectBLL499NA _instancia499NA;
        private List<IIdiomaObserver499NA> _observadores = new List<IIdiomaObserver499NA>();
        private static Dictionary<string, string> _diccionarioActual = new Dictionary<string, string>();

        private IdiomaSubjectBLL499NA() { }

        public static IdiomaSubjectBLL499NA Instancia499NA
        {
            get
            {
                if (_instancia499NA == null) _instancia499NA = new IdiomaSubjectBLL499NA();
                return _instancia499NA;
            }
        }

        public void Suscribir(IIdiomaObserver499NA obs) => _observadores.Add(obs);
        public void Desuscribir(IIdiomaObserver499NA obs) => _observadores.Remove(obs);

        public void CambiarIdioma(int idIdioma, string archivo)
        {
            try
            {
                TraductorBLL499NA traductor = new TraductorBLL499NA();
                _diccionarioActual = traductor.CargarTraducciones(archivo);

                Notificar();
                BLL499NA.PerfilesBLL499NA perfilesBLL = new BLL499NA.PerfilesBLL499NA();
                perfilesBLL.ActualizarEstructuraTextos499NA();
                

                BitacoraBLL499NA bitacoraBLL = new BitacoraBLL499NA();
                bitacoraBLL.RegistrarEvento("Config", "Cambio de idioma exitoso", 1);
            }
            catch (Exception ex)
            {
                BitacoraBLL499NA bitacoraBLL = new BitacoraBLL499NA();
                bitacoraBLL.RegistrarEvento("Error Idioma", ex.Message, 3);

                throw new Exception("Falla Carga: No se pudo procesar el archivo de idioma.", ex);
            }
        }

        private void Notificar()
        {
            foreach (var obs in _observadores)
            {
                obs.ActualizarIdioma499NA();
            }
        }

        public string ObtenerTexto(string tag)
        {
            return _diccionarioActual.ContainsKey(tag) ? _diccionarioActual[tag] : $"[{tag}]";
        }
    }
}
