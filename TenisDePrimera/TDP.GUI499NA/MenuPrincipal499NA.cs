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
            Logout499NA pantallaLogout499NA = new Logout499NA();

            // 2. Lo mostramos en la pantalla como un cuadro de diálogo modal.
            // Esto detiene el flujo acá hasta que el usuario elija "Cerrar Sesión" o "Volver".
            pantallaLogout499NA.ShowDialog();

            // 3. CONTROL DE RETORNO: Cuando la pantalla de Logout se cierre...
            // Si el usuario tocó "Cerrar Sesión", el SessionManager va a estar vacío (null).
            if (Servicios499NA.SessionManager499NA.Instancia499NA.UsuarioLogueado499NA == null)
            {
                // Cerramos por completo este menú principal para que no quede flotando
                this.Close();
            }
            AbrirFormularioHijo499NA(new GestionUsuarios499NA());
        }


        private void AbrirFormularioHijo499NA(Form formularioHijo499NA)
        {
            // 1. Le asignamos este menú principal como padre MDI
            formularioHijo499NA.MdiParent = this;

            // 2. Lo centramos o maximizamos para que quede prolijo adentro
            formularioHijo499NA.WindowState = FormWindowState.Normal;

            // 3. Lo mostramos
            formularioHijo499NA.Show();
        }
    }
}
