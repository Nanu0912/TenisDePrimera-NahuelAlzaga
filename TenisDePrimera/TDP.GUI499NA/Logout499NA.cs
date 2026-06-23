using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDP.BLL499NA;
using TDP.Servicios499NA;

namespace TDP.GUI499NA
{
    public partial class Logout499NA : Form
    {
        public Logout499NA()
        {
            InitializeComponent();
        }

        private void Logout499NA_Load(object sender, EventArgs e)
        {
            ActualizarIdioma499NA();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (Servicios499NA.SessionManager499NA.Instancia499NA.UsuarioLogueado499NA == null)
            {
                MessageBox.Show("No hay ninguna sesión activa.", "Atención");
                Application.Exit();
                return;
            }

            try
            {
                BLL499NA.BitacoraBLL499NA bll = new BLL499NA.BitacoraBLL499NA();

                bll.RegistrarEvento("Seguridad", "Cierre de Sesión Exitoso", 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar en bitácora: " + ex.Message);
            }

            SessionManager499NA.Instancia499NA.CerrarSesion499NA();

            MessageBox.Show("Sesión finalizada correctamente.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Login499NA plogin = new Login499NA();
            Navegador499NA.CambiarPantalla(plogin);

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal499NA mp = new MenuPrincipal499NA();
            Navegador499NA.CambiarPantalla(mp);


        }

        public void ActualizarIdioma499NA()
        {
            btnLogout.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("btnLogout");
            btnVolver.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("btnVolver");
        }
    }
}
