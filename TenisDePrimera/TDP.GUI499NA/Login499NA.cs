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
            ActualizarIdioma499NA();
        }

        

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string usrIngresado = txtNombre.Text.Trim();
                BLL499NA.BitacoraBLL499NA bll = new BLL499NA.BitacoraBLL499NA();

                
                if (SessionManager499NA.Instancia499NA.UsuarioLogueado499NA != null)
                {
                    string usuarioActivo = SessionManager499NA.Instancia499NA.UsuarioLogueado499NA.Nombre499NA;

                    
                    bll.RegistrarEventoManual("Seguridad", $"Intento de re-login denegado. Sesión activa: {usuarioActivo}. Intento con: {usrIngresado}", 2, usuarioActivo);

                    MessageBox.Show($"Ya existe una sesión activa ({usuarioActivo}) en el sistema.",
                                    "Acción Denegada",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return; 
                }

                if (string.IsNullOrEmpty(usrIngresado) || string.IsNullOrEmpty(txtContraseña.Text.Trim()))
                {
                    MessageBox.Show("Por favor, ingrese su usuario y contraseña.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool loginOk = usuariosBLL499NA.ValidarLogin499NA(usrIngresado, txtContraseña.Text.Trim());

                if (loginOk)
                {
                    bll.RegistrarEvento("Seguridad", "Inicio de Sesión Exitoso", 1);
                    MessageBox.Show("¡Bienvenido al sistema de Tenis de Primera, " + usrIngresado + "!", "Login Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MenuPrincipal499NA menu = new MenuPrincipal499NA();
                    Navegador499NA.CambiarPantalla(menu);
                    this.Hide();
                }
                else
                {
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

        public void ActualizarIdioma499NA()
        {
            lblNombre.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("lblNombre");
            lblContraseña.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("lblContraseña");
            btnIngresar.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("btnIngresar");
            btnSalir.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("btnSalir");
        }
    }
}
