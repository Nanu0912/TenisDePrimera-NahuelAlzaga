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
                string usrIngresado = txtNombre.Text.Trim();

                if (string.IsNullOrEmpty(usrIngresado) || string.IsNullOrEmpty(txtContraseña.Text.Trim()))
                {
                    MessageBox.Show("Por favor, ingrese su usuario y contraseña.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool loginOk = usuariosBLL499NA.ValidarLogin499NA(usrIngresado, txtContraseña.Text.Trim());
                BLL499NA.BitacoraBLL499NA bll = new BLL499NA.BitacoraBLL499NA();

                if (loginOk)
                {
                    bll.RegistrarEvento("Seguridad", "Inicio de Sesión Exitoso", 1);
                    MessageBox.Show("¡Bienvenido al sistema de Tenis de Primera, " + usrIngresado + "!", "Login Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MenuPrincipal499NA menu = new MenuPrincipal499NA();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    // Guarda el nombre tipeado en pantalla para rastrear el error de clave
                    bll.RegistrarEventoManual("Seguridad", "Contraseña incorrecta", 3, usrIngresado);

                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContraseña.Clear();
                    txtContraseña.Focus();
                }
            }
            catch (Exception ex)
            {
                try
                {
                    BLL499NA.BitacoraBLL499NA bll = new BLL499NA.BitacoraBLL499NA();
                    bll.RegistrarEventoManual("Seguridad", "Error crítico: " + ex.Message, 3, txtNombre.Text.Trim());
                }
                catch { }

                MessageBox.Show("Error de Autenticación: " + ex.Message, "No se pudo iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
