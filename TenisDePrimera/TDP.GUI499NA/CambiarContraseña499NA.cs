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
            mp.Show();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Guardamos el usuario actual en una variable corta
                string usrAct = Servicios499NA.SessionManager499NA.Instancia499NA.UsuarioLogueado499NA.NombreUsuario499NA;

                BLL499NA.UsuariosBLL499NA usrBLL = new BLL499NA.UsuariosBLL499NA();

                // 2. Ejecutamos tu lógica nativa de cambio de clave
                usrBLL.CambiarContraseña499NA(
                    usrAct,
                    txtContraseñaActual.Text,
                    txtContraseñaNueva.Text,
                    txtConfirmarContraseña.Text
                );

                // 3. LLAMADA LIMPIA: Registramos el éxito pasándole la variable segura y criticidad 2
                try
                {
                    BLL499NA.BitacoraBLL499NA bll = new BLL499NA.BitacoraBLL499NA();
                    bll.RegistrarCambioContraseña499NA(usrAct, 2);
                }
                catch { }

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
