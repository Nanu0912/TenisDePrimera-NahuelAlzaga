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
    public partial class Idiomas499NA : Form, IIdiomaObserver499NA
    {
        private IdiomaBLL499NA _idiomaBLL = new IdiomaBLL499NA();
        public Idiomas499NA()
        {
            InitializeComponent();
            IdiomaSubjectBLL499NA.Instancia499NA.Suscribir(this);
            ActualizarIdioma499NA();
        }

        private void Idiomas499NA_Load(object sender, EventArgs e)
        {
            try
            {
                
                cmbIdiomas.DataSource = _idiomaBLL.ObtenerListaIdiomas();
                cmbIdiomas.DisplayMember = "Nombre";       
                cmbIdiomas.ValueMember = "NombreArchivo";    

                ActualizarIdioma499NA();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los idiomas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCambiarIdioma_Click(object sender, EventArgs e)
        {
            if (cmbIdiomas.SelectedValue != null)
            {
                try
                {
                    string archivo = cmbIdiomas.SelectedValue.ToString();
                    int idIdioma = ((Servicios499NA.Idioma499NA)cmbIdiomas.SelectedItem).Id_Idioma;

                    IdiomaSubjectBLL499NA.Instancia499NA.CambiarIdioma(idIdioma, archivo);

                    MessageBox.Show("Idioma cambiado con éxito / Language changed successfully.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        public void ActualizarIdioma499NA()
        {
            this.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("titulo_form_idioma");
            lblSeleccionar.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("lbl_seleccionar_idioma");
            btnCambiarIdioma.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("btn_cambiar_idioma");
            btnVolver.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("btn_volver");
            gbSeleccionarIdioma.Text = IdiomaSubjectBLL499NA.Instancia499NA.ObtenerTexto("gbSeleccionarIdioma");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal499NA mp = new MenuPrincipal499NA();
            Navegador499NA.CambiarPantalla(mp);
        }
    }
}
