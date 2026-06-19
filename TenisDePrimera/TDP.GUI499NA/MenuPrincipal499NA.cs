using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDP.GUI499NA
{
    public partial class MenuPrincipal499NA : Form
    {
        public MenuPrincipal499NA()
        {
            InitializeComponent();
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

        }

        private void MenuPrincipal499NA_Load(object sender, EventArgs e)
        {

        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login499NA plogin = new Login499NA();
            Navegador499NA.CambiarPantalla(plogin);
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
