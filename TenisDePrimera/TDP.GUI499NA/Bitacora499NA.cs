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

        BitacoraBLL499NA bllBitacora = new BitacoraBLL499NA();



        private void Bitacora499NA_Load(object sender, EventArgs e)
        {

        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string usuario = txtNombreUsuario.Text;
            string modulo = txtModulo.Text;

            int? criticidad = string.IsNullOrEmpty(txtCriticidad.Text) ? (int?)null : int.Parse(txtCriticidad.Text);

            // CORRECCIÓN: Se usa .Value para los DateTimePicker de escritorio
            DateTime inicio = dtFechaInicio.Value;
            DateTime fin = dtFechaFin.Value;

            // Ahora que bllBitacora está declarada arriba, esto compila perfecto
            dgBitacora.DataSource = bllBitacora.ConsultarBitacora499NA(nombre, apellido, usuario, modulo, criticidad, inicio, fin);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNombreUsuario.Text = "";
            txtModulo.Text = "";
            txtEvento.Text = "";
            txtCriticidad.Text = "";

            // CORRECCIÓN: Se asigna el valor a la propiedad .Value del control
            dtFechaInicio.Value = DateTime.Now.AddMonths(-1);
            dtFechaFin.Value = DateTime.Now;

            dgBitacora.DataSource = null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MenuPrincipal499NA mp = new MenuPrincipal499NA();
            mp.Show();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
        }

        

    }
}
