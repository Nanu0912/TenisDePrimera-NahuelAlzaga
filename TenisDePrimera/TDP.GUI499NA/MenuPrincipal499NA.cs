using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDP.BLL499NA;
using TDP.Servicios499NA;

namespace TDP.GUI499NA
{
    public partial class MenuPrincipal499NA : Form, IIdiomaObserver499NA
    {
        public MenuPrincipal499NA()
        {
            InitializeComponent();
            IdiomaSubjectBLL499NA.Instancia499NA.Suscribir(this);
            ActualizarIdioma499NA();
        }

        private void maestroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logout499NA plogout = new Logout499NA();
            Navegador499NA.CambiarPantalla(plogout);




        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarContraseña499NA cc = new CambiarContraseña499NA();
            Navegador499NA.CambiarPantalla(cc);

        }

        private void gestionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionUsuarios499NA gu = new GestionUsuarios499NA();
            Navegador499NA.CambiarPantalla(gu);
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitacora499NA b = new Bitacora499NA();
            Navegador499NA.CambiarPantalla(b);
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionDeCanchasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cambiarIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Idiomas499NA i = new Idiomas499NA();
            Navegador499NA.CambiarPantalla(i);
        }

        private void MenuPrincipal499NA_Load(object sender, EventArgs e)
        {
            try
            {
                var sesionActual = Servicios499NA.SessionManager499NA.Instancia499NA;

                if (sesionActual.UsuarioLogueado499NA != null)
                {
                    bool tieneAccesoCanchas = sesionActual.UsuarioLogueado499NA.TienePermiso("Gestion de Canchas");
                    gestionDeCanchasToolStripMenuItem.Enabled = tieneAccesoCanchas;

                    RegistrarTurnoToolStripMenuItem.Enabled = sesionActual.UsuarioLogueado499NA.TienePermiso("Registrar Turno");
                    CancelarTurnoToolStripMenuItem.Enabled = sesionActual.UsuarioLogueado499NA.TienePermiso("Cancelar Turno");
                    disponibilidadYHorariosToolStripMenuItem.Enabled = sesionActual.UsuarioLogueado499NA.TienePermiso("Disponibilidad y Horarios");
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar los permisos del menú: " + ex.Message, "Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ActualizarIdioma499NA();
        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login499NA plogin = new Login499NA();
            Navegador499NA.CambiarPantalla(plogin);
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void perfilesYPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Perfiles499NA pPerfil = new Perfiles499NA();
            Navegador499NA.CambiarPantalla(pPerfil);
        }

        public void ActualizarIdioma499NA()
        {
            gestionDeCanchasToolStripMenuItem.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("gestionDeCanchasToolStripMenuItem");
            RegistrarTurnoToolStripMenuItem.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("RegistrarTurnoToolStripMenuItem");
            CancelarTurnoToolStripMenuItem.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("CancelarTurnoToolStripMenuItem");
            usuarioToolStripMenuItem.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("usuarioToolStripMenuItem");
        }
    }
}
