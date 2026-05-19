using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            SessionManager499NA.Instancia499NA.CerrarSesion499NA();

            MessageBox.Show("Sesión finalizada correctamente.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Login499NA pantallaLogin499NA = new Login499NA();
            pantallaLogin499NA.Show();

            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            foreach (Form formularioAbierto499NA in Application.OpenForms)
            {
                if (formularioAbierto499NA is MenuPrincipal499NA)
                {
                    formularioAbierto499NA.Focus();

                    this.Close();
                    return;
                }
            }
        }
    }
}
