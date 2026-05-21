using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDP.Servicios499NA
{
    public class SessionManager499NA
    {
        private static SessionManager499NA instancia499NA = null;

        public UsuarioServicios499NA UsuarioLogueado499NA { get; private set; }

        private SessionManager499NA() { }

        public static SessionManager499NA Instancia499NA
        {
            get
            {
                if (instancia499NA == null)
                {
                    instancia499NA = new SessionManager499NA();
                }
                return instancia499NA;
            }
        }
        public void IniciarSesion499NA(UsuarioServicios499NA usuario)
        {
            if (UsuarioLogueado499NA == null)
            {
                UsuarioLogueado499NA = usuario;
            }
            else
            {
                throw new Exception("Ya existe una sesión activa en el sistema.");
            }
        }

        public void CerrarSesion499NA()
        {
            if (UsuarioLogueado499NA != null)
            {
                UsuarioLogueado499NA = null;
            }
        }
    }
}
