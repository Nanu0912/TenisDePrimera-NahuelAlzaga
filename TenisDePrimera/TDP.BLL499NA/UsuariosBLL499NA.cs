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
        public void CrearUsuario499NA(UsuarioBE499NA usuarioNuevo499NA, string clavePlana499NA)
        {
            if (string.IsNullOrEmpty(usuarioNuevo499NA.Dni499NA) || string.IsNullOrEmpty(usuarioNuevo499NA.NombreUsuario499NA))
            {
                throw new Exception("No cumple con los requisitos: Campos obligatorios vacíos.");
            }

            usuarioNuevo499NA.Contraseña499NA = Cripto499NA.Instancia499NA.Encriptar499NA(clavePlana499NA);
            UsuariosDAL499NA.Instancia499NA.InsertarUsuario499NA(usuarioNuevo499NA);
        }

        
        public bool ValidarLogin499NA(string usuarioLogin499NA, string clavePlana499NA)
        {
            UsuarioBE499NA usuarioBD499NA = UsuariosDAL499NA.Instancia499NA.BuscarPorNombre499NA(usuarioLogin499NA);

            if (usuarioBD499NA == null)
            {
                throw new Exception("El usuario no existe.");
            }

            if (!usuarioBD499NA.Activo499NA || usuarioBD499NA.Bloqueo499NA)
            {
                throw new Exception("La cuenta se encuentra inactiva o bloqueada.");
            }

            string claveHasheada499NA = Cripto499NA.Instancia499NA.Encriptar499NA(clavePlana499NA);

            if (usuarioBD499NA.Contraseña499NA == claveHasheada499NA)
            {
                SessionManager499NA.Instancia499NA.IniciarSesion499NA(usuarioBD499NA);
                return true;
            }
            else
            {
                UsuariosDAL499NA.Instancia499NA.IncrementarIntentos499NA(usuarioLogin499NA);

                throw new Exception("Contraseña incorrecta. Intento registrado.");
            }
        }

        public void CambiarContraseña499NA(string nombreUsuario499NA, string claveActualPlana499NA, string nuevaClavePlana499NA, string confirmacionClavePlana499NA)
        {
            if (string.IsNullOrEmpty(claveActualPlana499NA) || string.IsNullOrEmpty(nuevaClavePlana499NA) || string.IsNullOrEmpty(confirmacionClavePlana499NA))
            {
                throw new Exception("Todos los campos son obligatorios.");
            }

            if (nuevaClavePlana499NA != confirmacionClavePlana499NA)
            {
                throw new Exception("La nueva contraseña y su confirmación no coinciden.");
            }

            UsuarioBE499NA usuarioBD499NA = UsuariosDAL499NA.Instancia499NA.BuscarPorNombre499NA(nombreUsuario499NA);
            if (usuarioBD499NA == null)
            {
                throw new Exception("Error crítico: El usuario no existe.");
            }

            string hashActual499NA = Servicios499NA.Cripto499NA.Instancia499NA.Encriptar499NA(claveActualPlana499NA);
            if (usuarioBD499NA.Contraseña499NA != hashActual499NA)
            {
                throw new Exception("La contraseña actual ingresada es incorrecta.");
            }

            string hashNueva499NA = Servicios499NA.Cripto499NA.Instancia499NA.Encriptar499NA(nuevaClavePlana499NA);
            UsuariosDAL499NA.Instancia499NA.ModificarContraseña499NA(nombreUsuario499NA, hashNueva499NA);
        }
    }
}
