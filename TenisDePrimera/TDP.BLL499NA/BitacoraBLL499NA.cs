using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDP.DAL499NA;
using TDP.Servicios499NA;

namespace TDP.BLL499NA
{
    public class BitacoraBLL499NA
    {
        public void RegistrarEvento(string moduloOrigen, string eventoOrigen, int criticidadOrigen)
        {
            BitacoraDAL499NA bitacoraDAL = new BitacoraDAL499NA();
            BitacoraServicios499NA infoAuditoria = new BitacoraServicios499NA();

            UsuarioServicios499NA usuarioSesion = SessionManager499NA.Instancia499NA.UsuarioLogueado499NA;

            if (usuarioSesion != null)
            {
                infoAuditoria.NombreUsuario499NA = usuarioSesion.NombreUsuario499NA;
                infoAuditoria.Modulo499NA = ClasificaAccion499NA(moduloOrigen);
                infoAuditoria.Evento499NA = DefineAccion499NA(eventoOrigen);
                infoAuditoria.Criticidad499NA = AsignaGravedad499NA(criticidadOrigen);
            }
            else
            {
                infoAuditoria.NombreUsuario499NA = usuarioSesion.NombreUsuario499NA;
                infoAuditoria.Modulo499NA = ClasificaAccion499NA(moduloOrigen);
                infoAuditoria.Evento499NA = DefineAccion499NA(eventoOrigen);
                infoAuditoria.Criticidad499NA = 3;
            }

            // Inyectamos de forma automática la fecha y hora actual del sistema antes de mandar a guardar
            infoAuditoria.Fecha499NA = DateTime.Now;
            infoAuditoria.Hora499NA = DateTime.Now.ToString("HH:mm:ss");

            bitacoraDAL.InsertarBitacora499NA(infoAuditoria);
        }
        public void RegistrarEventoConUsuarioManual499NA(string moduloOrigen, string eventoOrigen, int criticidadOrigen, string usuarioManual)
        {
            DAL499NA.BitacoraDAL499NA bitacoraDAL = new DAL499NA.BitacoraDAL499NA();
            Servicios499NA.BitacoraServicios499NA infoAuditoria = new Servicios499NA.BitacoraServicios499NA();

            // Si el usuario ingresó un texto, lo usamos. Si dejó la caja vacía, va ANÓNIMO
            infoAuditoria.NombreUsuario499NA = !string.IsNullOrEmpty(usuarioManual) ? usuarioManual : "ANÓNIMO/SISTEMA";

            infoAuditoria.Modulo499NA = moduloOrigen;
            infoAuditoria.Evento499NA = eventoOrigen;
            infoAuditoria.Criticidad499NA = criticidadOrigen;
            infoAuditoria.Fecha499NA = DateTime.Now;
            infoAuditoria.Hora499NA = DateTime.Now.ToString("HH:mm:ss");

            bitacoraDAL.InsertarBitacora499NA(infoAuditoria);
        }

        private string ClasificaAccion499NA(string modulo)
        {
            return modulo;
        }

        private string DefineAccion499NA(string evento)
        {
            return evento;
        }

        private int AsignaGravedad499NA(int criticidad)
        {
            return criticidad;
        }

        public System.Collections.Generic.List<Servicios499NA.BitacoraServicios499NA> ConsultarBitacora499NA(string nombre, string apellido, string usuario, string modulo, int? criticidad, DateTime inicio, DateTime fin)
        {
            DAL499NA.BitacoraDAL499NA dal = new DAL499NA.BitacoraDAL499NA();

            // Ejecutamos la consulta
            var resultado = dal.ListarBitacoraFiltrada499NA(nombre, apellido, usuario, modulo, criticidad, inicio, fin);

            // CORRECCIÓN: Si por algún motivo la DAL devuelve null, aseguramos una lista vacía para que no tire el Warning
            return resultado ?? new System.Collections.Generic.List<Servicios499NA.BitacoraServicios499NA>();
        }
    }
}
