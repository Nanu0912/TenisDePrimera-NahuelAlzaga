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
            try
            {
                BLL499NA.BitacoraBLL499NA bll = new BLL499NA.BitacoraBLL499NA();

                // Extraemos los textos y si están vacíos los convertimos en null
                string nombre = string.IsNullOrEmpty(txtNombre.Text.Trim()) ? null : txtNombre.Text.Trim();
                string apellido = string.IsNullOrEmpty(txtApellido.Text.Trim()) ? null : txtApellido.Text.Trim();
                string usuario = string.IsNullOrEmpty(txtNombreUsuario.Text.Trim()) ? null : txtNombreUsuario.Text.Trim();
                string modulo = string.IsNullOrEmpty(txtModulo.Text.Trim()) ? null : txtModulo.Text.Trim();

                // Manejo de la criticidad (si maneja un combobox o txt)
                int? criticidad = null;
                if (!string.IsNullOrEmpty(txtCriticidad.Text) && txtCriticidad.Text != "Todos")
                {
                    criticidad = Convert.ToInt32(txtCriticidad.Text);
                }

                // CORRECCIÓN DE FECHAS: Forzamos a que barra todo el rango horario del día
                DateTime fechaInicio = dtFechaInicio.Value.Date; // 00:00:00
                DateTime fechaFin = dtFechaFin.Value.Date.AddDays(1).AddTicks(-1); // 23:59:59

                // Llamamos a la BLL
                var listaBitacora = bll.ConsultarBitacora499NA(nombre, apellido, usuario, modulo, criticidad, fechaInicio, fechaFin);

                // Asignamos el resultado al DataGridView
                dgBitacora.DataSource = null; // Limpiamos por seguridad
                dgBitacora.DataSource = listaBitacora;

                if (listaBitacora.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros con los filtros seleccionados.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar la bitácora: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
