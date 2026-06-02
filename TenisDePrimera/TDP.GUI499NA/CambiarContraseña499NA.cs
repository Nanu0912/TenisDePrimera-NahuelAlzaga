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
    public partial class CambiarContraseña499NA : Form
    {
        public CambiarContraseña499NA()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal499NA mp = new MenuPrincipal499NA();
            Navegador499NA.CambiarPantalla(mp);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuarioActual499NA = Servicios499NA.SessionManager499NA.Instancia499NA.UsuarioLogueado499NA.NombreUsuario499NA;

                BLL499NA.UsuariosBLL499NA usuariosBLL499NA = new BLL499NA.UsuariosBLL499NA();

                usuariosBLL499NA.CambiarContraseña499NA(
                    usuarioActual499NA,
                    txtContraseñaActual.Text,
                    txtContraseñaNueva.Text,
                    txtConfirmarContraseña.Text
                );

                try
                {
                    BLL499NA.BitacoraBLL499NA bll = new BLL499NA.BitacoraBLL499NA();
                    bll.RegistrarEvento("Seguridad", "Cambio de contraseña exitoso", 2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar en bitácora: " + ex.Message);
                }

                MessageBox.Show("Contraseña modificada con éxito.", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
