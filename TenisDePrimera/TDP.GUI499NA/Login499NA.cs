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
                if (string.IsNullOrEmpty(txtNombre.Text.Trim()) || string.IsNullOrEmpty(txtContraseña.Text.Trim()))
                {
                    MessageBox.Show("Por favor, ingrese su usuario y contraseña.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool loginExitoso499NA = usuariosBLL499NA.ValidarLogin499NA(txtNombre.Text.Trim(), txtContraseña.Text.Trim());

                if (loginExitoso499NA)
                {
                    // --- NUEVO: Instanciamos la BLL de bitácora ---
                    BLL499NA.BitacoraBLL499NA bitacoraBLL = new BLL499NA.BitacoraBLL499NA();

                    // Registramos el éxito (Criticidad 1 - Baja). 
                    // Como SessionManager ya tiene el usuario logueado por dentro de ValidarLogin, lo va a capturar solo.
                    bitacoraBLL.RegistrarEvento("Seguridad", "Inicio de Sesión Exitoso", 1);

                    MessageBox.Show("¡Bienvenido al sistema de Tenis de Primera, " + txtNombre.Text + "!", "Login Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MenuPrincipal499NA formularioMenu499NA = new MenuPrincipal499NA();
                    formularioMenu499NA.Show();
                    this.Hide();
                }
                else
                {
                    // --- NUEVO: Si las credenciales son incorrectas, registramos el fallo antes del aviso ---
                    BLL499NA.BitacoraBLL499NA bitacoraBLL = new BLL499NA.BitacoraBLL499NA();

                    // Guardamos el rastro indicando qué usuario se intentó forzar o tipeó mal.
                    // Como la sesión va a ser null, la BLL le clavará "ANÓNIMO/SISTEMA" y Criticidad 3 automáticamente.
                    bitacoraBLL.RegistrarEventoConUsuarioManual499NA("Seguridad", "Intento fallido de Login para el usuario: " + txtNombre.Text.Trim(), 3, txtNombre.Text.Trim());

                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContraseña.Clear();
                    txtContraseña.Focus();
                }
            }
            catch (Exception ex499NA)
            {
                // En caso de una excepción grave en el intento de conexión o consulta de datos
                try
                {
                    BLL499NA.BitacoraBLL499NA bitacoraBLL = new BLL499NA.BitacoraBLL499NA();
                    bitacoraBLL.RegistrarEventoConUsuarioManual499NA("Seguridad", "Error crítico en el proceso de Login: " + ex499NA.Message, 3, txtNombre.Text.Trim());
                }
                catch { /* Evitamos un bucle de excepciones por si cae la base entera */ }

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
