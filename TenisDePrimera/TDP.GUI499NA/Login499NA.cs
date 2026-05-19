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

namespace TDP.GUI499NA
{
    public partial class Login499NA : Form
    {
        private UsuariosBLL499NA usuariosBLL499NA = new UsuariosBLL499NA();
        public Login499NA()
        {
            InitializeComponent();
            txtContraseña.PasswordChar = '*';
            txtContraseña.ShortcutsEnabled = false;
        }

        private void Login499NA_Load(object sender, EventArgs e)
        {

        }

        

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text.Trim()) || string.IsNullOrEmpty(txtContraseña.Text.Trim()))
                {
                    MessageBox.Show("Por favor, ingrese su usuario y contraseña.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bool loginExitoso499NA = usuariosBLL499NA.ValidarLogin499NA(txtNombre.Text.Trim(), txtContraseña.Text.Trim());

                if (loginExitoso499NA)
                {
                    MessageBox.Show("¡Bienvenido al sistema de Tenis de Primera, " + txtNombre.Text + "!", "Login Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MenuPrincipal499NA formularioMenu499NA = new MenuPrincipal499NA();

                    formularioMenu499NA.Show();

                    this.Hide();
                }
            }
            catch (Exception ex499NA)
            {
                MessageBox.Show("Error de Autenticación: " + ex499NA.Message, "No se pudo iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtContraseña.Clear();
                txtContraseña.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
