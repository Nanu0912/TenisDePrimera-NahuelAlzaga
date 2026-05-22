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
        public void RegistrarEvento(string mod, string eve, int crit)
        {
            BitacoraDAL499NA dal = new BitacoraDAL499NA();
            BitacoraServicios499NA info = new BitacoraServicios499NA();

            var usrSesion = SessionManager499NA.Instancia499NA.UsuarioLogueado499NA;

            info.NombreUsuario499NA = (usrSesion != null) ? usrSesion.NombreUsuario499NA : "ANÓNIMO/SISTEMA";
            info.Modulo499NA = mod;
            info.Evento499NA = eve;
            info.Criticidad499NA = crit;
            info.Fecha499NA = DateTime.Now;
            info.Hora499NA = DateTime.Now.ToString("HH:mm:ss");

            dal.InsertarBitacora499NA(info);
        }

        // 2. Inserción Manual (Para capturar el cuadro de texto exacto si la contraseña falla)
        public void RegistrarEventoManual(string mod, string eve, int crit, string usrTxt)
        {
            BitacoraDAL499NA dal = new BitacoraDAL499NA();
            BitacoraServicios499NA info = new BitacoraServicios499NA();

            info.NombreUsuario499NA = !string.IsNullOrEmpty(usrTxt) ? usrTxt : "ANÓNIMO/SISTEMA";
            info.Modulo499NA = mod;
            info.Evento499NA = eve;
            info.Criticidad499NA = crit;
            info.Fecha499NA = DateTime.Now;
            info.Hora499NA = DateTime.Now.ToString("HH:mm:ss");

            dal.InsertarBitacora499NA(info);
        }

        // 3. Consulta puente hacia la DAL
        public List<BitacoraServicios499NA> ConsultarBitacora499NA(string usr, string mod, int? crit, DateTime ini, DateTime fin)
        {
            BitacoraDAL499NA dal = new BitacoraDAL499NA();
            // Le pasa directo los filtros válidos a la DAL
            return dal.ListarBitacoraFiltrada499NA(usr, mod, crit, ini, fin);
        }

        public void RegistrarCierreSesion499NA(string usuario, int crit)
        {
            BitacoraDAL499NA dal = new BitacoraDAL499NA();
            BitacoraServicios499NA info = new BitacoraServicios499NA();

            // Seteamos los datos fijos del Logout y mapeamos las variables
            info.NombreUsuario499NA = usuario;
            info.Modulo499NA = "Seguridad";
            info.Evento499NA = "Cierre de Sesión Exitoso";
            info.Criticidad499NA = crit;
            info.Fecha499NA = DateTime.Now;
            info.Hora499NA = DateTime.Now.ToString("HH:mm:ss");

            dal.InsertarBitacora499NA(info);
        }

        public void RegistrarCambioContraseña499NA(string usuario, int crit)
        {
            BitacoraDAL499NA dal = new BitacoraDAL499NA();
            BitacoraServicios499NA info = new BitacoraServicios499NA();

            // Seteamos los datos fijos del cambio de clave
            info.NombreUsuario499NA = usuario;
            info.Modulo499NA = "Seguridad";
            info.Evento499NA = "Cambio de contraseña exitoso";
            info.Criticidad499NA = crit;
            info.Fecha499NA = DateTime.Now;
            info.Hora499NA = DateTime.Now.ToString("HH:mm:ss");

            dal.InsertarBitacora499NA(info);
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

        
    }
}
