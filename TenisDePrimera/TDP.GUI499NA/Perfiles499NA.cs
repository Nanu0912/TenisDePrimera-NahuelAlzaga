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
    public partial class Perfiles499NA : Form
    {
        private PerfilesBLL499NA perfilesBLL = new PerfilesBLL499NA();

        public Perfiles499NA()
        {
            InitializeComponent();
            if (lblMensajeSistema != null) lblMensajeSistema.Text = "";
        }

        public void CargarArbolVisual499NA()
        {
            try
            {
                twPerfiles.Nodes.Clear();
                List<Componente499NA> perfilesRaiz = perfilesBLL.ObtenerArbolDePermisos();

                foreach (var perfil in perfilesRaiz)
                {
                    TreeNode nodoRaiz = new TreeNode(perfil.Nombre);
                    nodoRaiz.Tag = perfil;
                    twPerfiles.Nodes.Add(nodoRaiz);

                    
                    AgregarHijosRecursivos499NA(nodoRaiz, perfil.Hijos);
                }
                twPerfiles.ExpandAll(); 
            }
            catch (Exception ex)
            {
                if (lblMensajeSistema != null) lblMensajeSistema.Text = "Error al cargar árbol: " + ex.Message;
            }
        }
    
        private void AgregarHijosRecursivos499NA(TreeNode nodoVisualPadre, List<Componente499NA> hijosLogicos)
        {
            foreach (var hijo in hijosLogicos)
            {
                TreeNode nodoVisualHijo = new TreeNode(hijo.Nombre);
                nodoVisualHijo.Tag = hijo;
                nodoVisualPadre.Nodes.Add(nodoVisualHijo);

                AgregarHijosRecursivos499NA(nodoVisualHijo, hijo.Hijos);
            }
        }

        private void CargarComboComponentesSueltos499NA()
        {
            try
            {
                cmbComponentesSueltos.DataSource = null;
                cmbComponentesSueltos.DataSource = perfilesBLL.ObtenerListaPlanaParaCombo();
                cmbComponentesSueltos.DisplayMember = "Nombre";
                cmbComponentesSueltos.ValueMember = "ID_Componente";
                cmbComponentesSueltos.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                if (lblMensajeSistema != null) lblMensajeSistema.Text = "Error al cargar combo: " + ex.Message;
            }
        }

        private void btnCrearComponente_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombreComponente.Text.Trim()))
                    throw new Exception("Ingrese un nombre válido para el componente.");

                Componente499NA nuevo = new Componente499NA
                {
                    Nombre = txtNombreComponente.Text.Trim(),
                    EsFamilia = chkEsFamilia.Checked,
                    ID_Padre = null
                };

                perfilesBLL.GuardarNuevoComponente499NA(nuevo);

                try
                {
                    BLL499NA.BitacoraBLL499NA bitacoraBLL = new BLL499NA.BitacoraBLL499NA();
                    string tipo = nuevo.EsFamilia ? "Familia/Perfil" : "Patente/Permiso";
                    bitacoraBLL.RegistrarEvento("Seguridad", $"Creación de componente {tipo}: '{nuevo.Nombre}'", 2);
                }
                catch (Exception exBit) { System.Diagnostics.Debug.WriteLine("Error bitácora: " + exBit.Message); }

                if (lblMensajeSistema != null) lblMensajeSistema.Text = $"Componente '{nuevo.Nombre}' creado con éxito.";
                txtNombreComponente.Text = "";

                CargarArbolVisual499NA();
                CargarComboComponentesSueltos499NA();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnEliminarComponente_Click(object sender, EventArgs e)
        {
            try
            {
                if (twPerfiles.SelectedNode == null)
                    throw new Exception("Debe seleccionar un elemento del árbol para eliminarlo.");

                Componente499NA seleccionado = (Componente499NA)twPerfiles.SelectedNode.Tag;

                DialogResult res = MessageBox.Show($"¿Desea eliminar definitivamente '{seleccionado.Nombre}' de la base de datos?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    perfilesBLL.EliminarComponente499NA(seleccionado.ID_Componente);

                    try
                    {
                        BLL499NA.BitacoraBLL499NA bitacoraBLL = new BLL499NA.BitacoraBLL499NA();
                        bitacoraBLL.RegistrarEvento("Seguridad", $"Eliminación física de componente de seguridad: '{seleccionado.Nombre}'", 3);
                    }
                    catch (Exception exBit) { System.Diagnostics.Debug.WriteLine("Error bitácora: " + exBit.Message); }

                    if (lblMensajeSistema != null) lblMensajeSistema.Text = $"Componente '{seleccionado.Nombre}' eliminado del sistema.";

                    CargarArbolVisual499NA();
                    CargarComboComponentesSueltos499NA();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnAgregarAlArbol_Click(object sender, EventArgs e)
        {
            try
            {
                if (twPerfiles.SelectedNode == null)
                    throw new Exception("Seleccione la Familia o Perfil contenedor en el árbol de la izquierda.");
                if (cmbComponentesSueltos.SelectedIndex == -1)
                    throw new Exception("Seleccione el componente que desea incluir desde el desplegable.");

                Componente499NA padreDestino = (Componente499NA)twPerfiles.SelectedNode.Tag;

                if (!padreDestino.EsFamilia)
                    throw new Exception("No se pueden colgar elementos dentro de una Patente atómica. Seleccione un contenedor válido (Familia o Perfil).");

                int idHijoAAgregar = Convert.ToInt32(cmbComponentesSueltos.SelectedValue);
                string nombreHijo = cmbComponentesSueltos.Text;

                perfilesBLL.AsignarHijoAPadre499NA(idHijoAAgregar, padreDestino.ID_Componente);

                try
                {
                    BLL499NA.BitacoraBLL499NA bitacoraBLL = new BLL499NA.BitacoraBLL499NA();
                    bitacoraBLL.RegistrarEvento("Seguridad", $"Asignación: se incluyó '{nombreHijo}' como hijo de '{padreDestino.Nombre}'", 2);
                }
                catch (Exception exBit) { System.Diagnostics.Debug.WriteLine("Error bitácora: " + exBit.Message); }

                if (lblMensajeSistema != null) lblMensajeSistema.Text = $"'{nombreHijo}' agregado correctamente dentro de '{padreDestino.Nombre}'.";

                CargarArbolVisual499NA();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnQuitarDelArbol_Click(object sender, EventArgs e)
        {
            try
            {
                if (twPerfiles.SelectedNode == null)
                    throw new Exception("Seleccione el componente del árbol que desea desvincular.");

                TreeNode nodoVisual = twPerfiles.SelectedNode;
                if (nodoVisual.Parent == null)
                    throw new Exception("No puede desasignar un Perfil Raíz desde este control. Utilice 'Eliminar Componente'.");

                Componente499NA hijoAQuitar = (Componente499NA)nodoVisual.Tag;
                string nombrePadre = nodoVisual.Parent.Text;

                perfilesBLL.QuitarHijoDePadre499NA(hijoAQuitar.ID_Componente);

                try
                {
                    BLL499NA.BitacoraBLL499NA bitacoraBLL = new BLL499NA.BitacoraBLL499NA();
                    bitacoraBLL.RegistrarEvento("Seguridad", $"Desasignación: se removió '{hijoAQuitar.Nombre}' de la estructura '{nombrePadre}'", 2);
                }
                catch (Exception exBit) { System.Diagnostics.Debug.WriteLine("Error bitácora: " + exBit.Message); }

                if (lblMensajeSistema != null) lblMensajeSistema.Text = $"Componente '{hijoAQuitar.Nombre}' desvinculado de '{nombrePadre}'.";

                CargarArbolVisual499NA();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MenuPrincipal499NA mp = new MenuPrincipal499NA();
            Navegador499NA.CambiarPantalla(mp);
            this.Close();
        }

        private void Perfiles499NA_Load(object sender, EventArgs e)
        {
            CargarArbolVisual499NA();
            CargarComboComponentesSueltos499NA();
        }
    }
    
}
