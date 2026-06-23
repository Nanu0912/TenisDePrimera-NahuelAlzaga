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
    public partial class CambiarContraseña499NA : Form, IIdiomaObserver499NA
    {
        public CambiarContraseña499NA()
        {
            InitializeComponent();
            IdiomaSubjectBLL499NA.Instancia499NA.Suscribir(this);
            ActualizarIdioma499NA();
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

        private void CambiarContraseña499NA_Load(object sender, EventArgs e)
        {
            ActualizarIdioma499NA();
        }

        public void ActualizarIdioma499NA()
        {
            lblContraseñaActual.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("lblContrasenaActual");
            lblContraseñaNueva.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("lblContrasenaNueva");
            lblConfirmarContraseña.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("lblConfirmarContrasena");
            btnConfirmar.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("btnConfirmar");
            btnVolver.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("btnVolver");
        }
    }
}
