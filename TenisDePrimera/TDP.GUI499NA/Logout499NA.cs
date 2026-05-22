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
                // 1. INSTANCIAMOS LA BLL
                BLL499NA.BitacoraBLL499NA bll = new BLL499NA.BitacoraBLL499NA();

                // 2. REGISTRAMOS EL EVENTO PRIMERO
                // Como la sesión todavía NO se cerró, esa línea de la BLL va a leer 
                // perfecto el usuario desde el SessionManager de forma automática.
                bll.RegistrarEvento("Seguridad", "Cierre de Sesión Exitoso", 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar en bitácora: " + ex.Message);
            }

            // 3. RECIÉN AHORA DESTRUIMOS LA SESIÓN EN MEMORIA
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
