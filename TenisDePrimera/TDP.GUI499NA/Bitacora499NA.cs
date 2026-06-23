using System;
using System.IO;
using System.Web;
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
    public partial class Bitacora499NA : Form
    {
        public Bitacora499NA()
        {
            InitializeComponent();
        }

        



        private void Bitacora499NA_Load(object sender, EventArgs e)
        {
            ActualizarIdioma499NA();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            try
            {
                BLL499NA.BitacoraBLL499NA bll = new BLL499NA.BitacoraBLL499NA();

                string usr = string.IsNullOrEmpty(txtNombreUsuario.Text.Trim()) ? null : txtNombreUsuario.Text.Trim();
                string mod = string.IsNullOrEmpty(txtModulo.Text.Trim()) ? null : txtModulo.Text.Trim();

                int? crit = null;
                if (!string.IsNullOrEmpty(txtCriticidad.Text.Trim()))
                {
                    crit = Convert.ToInt32(txtCriticidad.Text.Trim());
                }

                DateTime ini = dtFechaInicio.Value.Date;
                DateTime fin = dtFechaFin.Value.Date.AddDays(1).AddTicks(-1);

                var lista = bll.ConsultarBitacora499NA(usr, mod, crit, ini, fin);

                dgBitacora.DataSource = null;
                dgBitacora.AutoGenerateColumns = false; // Evita que dibuje columnas duplicadas
                dgBitacora.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MenuPrincipal499NA mp = new MenuPrincipal499NA();
            Navegador499NA.CambiarPantalla(mp);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                txtNombreUsuario.Clear();
                txtModulo.Clear();
                txtCriticidad.Clear();

                dtFechaInicio.Value = DateTime.Now;
                dtFechaFin.Value = DateTime.Now;

                BLL499NA.BitacoraBLL499NA bll = new BLL499NA.BitacoraBLL499NA();

                DateTime ini = dtFechaInicio.Value.Date;
                DateTime fin = dtFechaFin.Value.Date.AddDays(1).AddTicks(-1);

                var listaOriginal = bll.ConsultarBitacora499NA(null, null, null, ini, fin);

                dgBitacora.DataSource = null;
                dgBitacora.AutoGenerateColumns = false;
                dgBitacora.DataSource = listaOriginal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al limpiar la pantalla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ActualizarIdioma499NA()
        {
            lblNombreDeUsuario.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("lblNombreDeUsuario");
            lblFechaInicio.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("lblFechaInicio");
            lblFechaFin.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("lblFechaFin");
            lblModulo.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("lblModulo");
            lblEvento.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("lblEvento");
            lblCriticidad.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("lblCriticidad");
            lblBITACORADEEVENTOS.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("lblBITACORADEEVENTOS");
            btnAplicar.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("btnAplicar");
            btnLimpiar.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("btnLimpiar");
            btnImprimir.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("btnImprimir");
            btnSalir.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("btnSalir");
        }
    }
}
