using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDP.BE499NA;

namespace TDP.Servicios499NA
{
    public class SessionManager499NA
    {
        private static SessionManager499NA instancia499NA = null;

        public UsuarioBE499NA UsuarioLogueado499NA { get; private set; }

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
        public void IniciarSesion499NA(UsuarioBE499NA usuario499NA)
        {
            if (UsuarioLogueado499NA == null)
            {
                UsuarioLogueado499NA = usuario499NA;
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
