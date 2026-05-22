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

        public List<BitacoraServicios499NA> ConsultarBitacora499NA(string usr, string mod, int? crit, DateTime ini, DateTime fin)
        {
            BitacoraDAL499NA dal = new BitacoraDAL499NA();
            return dal.ListarBitacoraFiltrada499NA(usr, mod, crit, ini, fin);
        }

       


        
    }
}
