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

            Login499NA pantallaLogin499NA = new Login499NA();
            pantallaLogin499NA.Show();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal499NA mp = new MenuPrincipal499NA();
            mp.Show();

            
        }
    }
}
