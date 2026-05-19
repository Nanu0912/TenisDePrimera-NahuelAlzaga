using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDP.BE499NA;
using TDP.DAL499NA;
using TDP.Servicios499NA;

namespace TDP.BLL499NA
{
    public class BitacoraBLL499NA
    {
        public void RegistrarEvento(string moduloOrigen, string eventoOrigen, int criticidadOrigen)
        {
            BitacoraDAL499NA bitacoraDAL = new BitacoraDAL499NA();
            BitacoraBE499NA infoAuditoria = new BitacoraBE499NA();

           
            UsuarioBE499NA usuarioSesion = SessionManager499NA.Instancia499NA.UsuarioLogueado499NA;

            
            if (usuarioSesion != null)
            {
                
                infoAuditoria.NombreUsuario499NA = usuarioSesion.NombreUsuario499NA; 
                infoAuditoria.Modulo499NA = ClasificaAccion499NA(moduloOrigen);
                infoAuditoria.Evento499NA = DefineAccion499NA(eventoOrigen);
                infoAuditoria.Criticidad499NA = AsignaGravedad499NA(criticidadOrigen);
            }
            else
            {
                
                infoAuditoria.NombreUsuario499NA = "ANÓNIMO/SISTEMA";
                infoAuditoria.Modulo499NA = ClasificaAccion499NA(moduloOrigen);
                infoAuditoria.Evento499NA = DefineAccion499NA(eventoOrigen);
                infoAuditoria.Criticidad499NA = 3; 
            }

            
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

        public System.Collections.Generic.List<BE499NA.BitacoraBE499NA> ConsultarBitacora499NA(string nombre, string apellido, string usuario, string modulo, int? criticidad, DateTime inicio, DateTime fin)
        {
            
            DAL499NA.BitacoraDAL499NA dal = new DAL499NA.BitacoraDAL499NA();

            
            return dal.ListarBitacoraFiltrada499NA(nombre, apellido, usuario, modulo, criticidad, inicio, fin);
        }
    }
}
