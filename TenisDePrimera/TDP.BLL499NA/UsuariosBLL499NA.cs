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
    public class UsuariosBLL499NA
    {
        public void CrearUsuario499NA(UsuarioBE499NA usuarioNuevo, string clavePlana)
        {
            if (string.IsNullOrEmpty(usuarioNuevo.Dni499NA) || string.IsNullOrEmpty(usuarioNuevo.NombreUsuario499NA))
            {
                throw new Exception("No cumple con los requisitos: Campos obligatorios vacíos.");
            }

            usuarioNuevo.Contraseña499NA = Cripto499NA.Instancia499NA.Encriptar499NA(clavePlana);
            UsuariosDAL499NA.Instancia499NA.InsertarUsuario499NA(usuarioNuevo);
        }

        
        public bool ValidarLogin499NA(string usuarioLogin, string clavePlana)
        {
            UsuarioBE499NA usuarioBD = UsuariosDAL499NA.Instancia499NA.BuscarPorNombre499NA(usuarioLogin);

            if (usuarioBD == null)
            {
                throw new Exception("El usuario no existe.");
            }

            if (!usuarioBD.Activo499NA || usuarioBD.Bloqueo499NA)
            {
                throw new Exception("La cuenta se encuentra inactiva o bloqueada.");
            }

            string claveHasheada = Cripto499NA.Instancia499NA.Encriptar499NA(clavePlana);

            if (usuarioBD.Contraseña499NA == claveHasheada)
            {
                SessionManager499NA.Instancia499NA.IniciarSesion499NA(usuarioBD);
                return true;
            }
            else
            {
                UsuariosDAL499NA.Instancia499NA.IncrementarIntentos499NA(usuarioLogin);

                throw new Exception("Contraseña incorrecta. Intento registrado.");
            }
        }

        public void CambiarContraseña499NA(string nombreUsuario, string claveActualPlana, string nuevaClavePlana, string confirmacionClavePlana)
        {
            if (string.IsNullOrEmpty(claveActualPlana) || string.IsNullOrEmpty(nuevaClavePlana) || string.IsNullOrEmpty(confirmacionClavePlana))
            {
                throw new Exception("Todos los campos son obligatorios.");
            }

            if (nuevaClavePlana != confirmacionClavePlana)
            {
                throw new Exception("La nueva contraseña y su confirmación no coinciden.");
            }

            UsuarioBE499NA usuarioBD = UsuariosDAL499NA.Instancia499NA.BuscarPorNombre499NA(nombreUsuario);
            if (usuarioBD == null)
            {
                throw new Exception("Error crítico: El usuario no existe.");
            }

            string hashActual = Servicios499NA.Cripto499NA.Instancia499NA.Encriptar499NA(claveActualPlana);
            if (usuarioBD.Contraseña499NA != hashActual)
            {
                throw new Exception("La contraseña actual ingresada es incorrecta.");
            }

            string hashNueva = Servicios499NA.Cripto499NA.Instancia499NA.Encriptar499NA(nuevaClavePlana);
            UsuariosDAL499NA.Instancia499NA.ModificarContraseña499NA(nombreUsuario, hashNueva);
        }

        public List<UsuarioBE499NA> ListarUsuarios499NA(bool mostrarTodos)
        {
            return UsuariosDAL499NA.Instancia499NA.ListarUsuarios499NA(mostrarTodos);
        }

        public void DesbloquearUsuario499NA(string nombreUsuario)
        {
            var usuarioActual = Servicios499NA.SessionManager499NA.Instancia499NA.UsuarioLogueado499NA;

            if (usuarioActual == null)
            {
                throw new Exception("Error de seguridad: No hay una sesión activa en el sistema.");
            }
            UsuariosDAL499NA.Instancia499NA.DesbloquearUsuario499NA(nombreUsuario);
        }
    }
}
