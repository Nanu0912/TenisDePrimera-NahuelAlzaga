using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDP.Servicios499NA
{
    public class UsuarioServicios499NA
    {
        public string Dni499NA { get; set; }
        public string Apellidos499NA { get; set; }
        public string Nombre499NA { get; set; }
        public string NombreUsuario499NA { get; set; }
        public string Contraseña499NA { get; set; }
        public string Rol499NA { get; set; }
        public string Email499NA { get; set; }
        public bool Bloqueo499NA { get; set; }
        public bool Activo499NA { get; set; }
        public int Intentos499NA { get; set; }

        public int IdPermisoRaiz { get; set; }

        public Componente499NA PermisoRaiz { get; set; }

        public bool TienePermiso(string codigoPermiso)
        {
            if (PermisoRaiz == null) return false;

            return EvaluarPermisoRecursivo(PermisoRaiz, codigoPermiso);
        }

        private bool EvaluarPermisoRecursivo(Componente499NA componente, string codigoBuscar)
        {
            if (componente.Nombre == codigoBuscar || componente.Codigo == codigoBuscar)
            {
                return true;
            }

            if (componente.EsFamilia && componente.Hijos != null)
            {
                foreach (var hijo in componente.Hijos)
                {
                    if (EvaluarPermisoRecursivo(hijo, codigoBuscar))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
