using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDP.BE499NA;
using TDP.BLL499NA;

namespace TDP.GUI499NA
{
    public partial class GestionUsuarios499NA : Form
    {
        private UsuariosBLL499NA usuariosBLL499NA = new UsuariosBLL499NA();
        private string accionActual499NA = "";
        public GestionUsuarios499NA()
        {
            InitializeComponent();
            lblMensajeSistema.Text = "";
        }

        private void GestionUsuarios499NA_Load(object sender, EventArgs e)
        {
            rbActivos.Checked = true; // Filtro por defecto
            CargarRolesMock499NA();
            LlenarGrilla499NA();
            AlternarCampos499NA(false);
        }

        private void gbNotificaciones_Enter(object sender, EventArgs e)
        {

        }

        private void rbActivos_CheckedChanged(object sender, EventArgs e)
        {
            { 
                LlenarGrilla499NA(); 
            }
        }

        private void CargarRolesMock499NA()
        {
            listRol.Items.Clear();
            listRol.Items.Add("Administrador");
            listRol.Items.Add("Empleado");
            listRol.SelectedIndex = 0;
        }

        private void LlenarGrilla499NA()
        {
            try
            {
                bool verTodos = rbTodos.Checked;
                List<UsuarioBE499NA> usuarios = usuariosBLL499NA.ListarUsuarios499NA(verTodos);

                dgUsuarios.DataSource = null;
                dgUsuarios.DataSource = usuarios;

                dgUsuarios.Columns["Dni499NA"].HeaderText = "DNI";
                dgUsuarios.Columns["Nombre499NA"].HeaderText = "Nombre";
                dgUsuarios.Columns["Apellidos499NA"].HeaderText = "Apellido";
                dgUsuarios.Columns["NombreUsuario499NA"].HeaderText = "NombreUsuario";
                dgUsuarios.Columns["Rol499NA"].HeaderText = "Rol";

                dgUsuarios.Columns["Contraseña499NA"].Visible = false;
                dgUsuarios.Columns["Email499NA"].Visible = false;
                dgUsuarios.Columns["Bloqueo499NA"].Visible = false;
                dgUsuarios.Columns["Activo499NA"].Visible = false;
                dgUsuarios.Columns["Intentos499NA"].Visible = false;
            }
            catch (Exception ex)
            {
                lblMensajeSistema.Text = "Error al cargar datos: " + ex.Message;
            }
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            accionActual499NA = "ALTA";
            LimpiarCampos499NA();
            AlternarCampos499NA(true);
            txtDNI.Focus();
            lblMensajeSistema.Text = "Modo: Creando nuevo usuario. Complete campos y pulse Aplicar.";
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            try
            {
                if (accionActual499NA == "ALTA")
                {
                    if (string.IsNullOrEmpty(txtNombre.Text.Trim()) || string.IsNullOrEmpty(txtDNI.Text.Trim()))
                    {
                        throw new Exception("El Nombre y el DNI son obligatorios para generar la contraseña inicial.");
                    }

                    string contraseña = (txtNombre.Text.Trim() + txtDNI.Text.Trim());

                    UsuarioBE499NA nuevo = new UsuarioBE499NA
                    {
                        Dni499NA = txtDNI.Text.Trim(),
                        Nombre499NA = txtNombre.Text.Trim(),
                        Apellidos499NA = txtApellido.Text.Trim(),
                        Email499NA = txtEmail.Text.Trim(),
                        NombreUsuario499NA = txtNombreUsuario.Text.Trim().ToLower(),
                        Rol499NA = listRol.SelectedItem.ToString(),
                        Activo499NA = true,
                        Bloqueo499NA = false,
                        Intentos499NA = 0
                    };

                    usuariosBLL499NA.CrearUsuario499NA(nuevo, contraseña);

                    lblMensajeSistema.Text = $"Usuario creado con éxito. Clave inicial: {contraseña}";
                }
                else if (accionActual499NA == "MODIFICACION")
                {
                    lblMensajeSistema.Text = "Cambios del usuario guardados con éxito.";
                }

                accionActual499NA = "";
                AlternarCampos499NA(false);
                LlenarGrilla499NA();
            }
            catch (Exception ex)
            {
                lblMensajeSistema.Text = "Error: " + ex.Message;
            }
        }

        private void AlternarCampos499NA(bool estado499NA)
        {
            txtDNI.Enabled = estado499NA;
            txtNombre.Enabled = estado499NA;
            txtApellido.Enabled = estado499NA;
            txtEmail.Enabled = estado499NA;
            txtNombreUsuario.Enabled = estado499NA;
            listRol.Enabled = estado499NA;

            btnAplicar.Enabled = estado499NA || (dgUsuarios.CurrentRow != null);
            btnCancelar.Enabled = estado499NA;
        }

        private void LimpiarCampos499NA()
        {
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEmail.Text = "";
            txtNombreUsuario.Text = "";
            cbBloqueado.Checked = false;
            cbUsuarioActivo.Checked = true;
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            { 
                LlenarGrilla499NA();
            }
        }

      

        private void dgUsuarios_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
              
        }

        private void dgUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgUsuarios.CurrentRow != null && accionActual499NA == "")
            {
                UsuarioBE499NA seleccionado = (UsuarioBE499NA)dgUsuarios.CurrentRow.DataBoundItem;

                txtDNI.Text = seleccionado.Dni499NA;
                txtNombre.Text = seleccionado.Nombre499NA;
                txtApellido.Text = seleccionado.Apellidos499NA;
                txtEmail.Text = seleccionado.Email499NA;
                txtNombreUsuario.Text = seleccionado.NombreUsuario499NA;

                cbBloqueado.Checked = seleccionado.Bloqueo499NA;
                cbUsuarioActivo.Checked = seleccionado.Activo499NA;

                if (seleccionado.Rol499NA == "Administrador") listRol.SelectedIndex = 0;
                else listRol.SelectedIndex = 1;
            }
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            // Alerta 1: Para saber si el botón físicamente responde al clic
            MessageBox.Show("¡El botón Desbloquear responde al clic correctamente!", "Paso 1");

            if (dgUsuarios.CurrentRow == null)
            {
                MessageBox.Show("La grilla no tiene ninguna fila seleccionada (CurrentRow es NULL).", "Alerta de Control");
                return;
            }

            try
            {
                UsuarioBE499NA seleccionado499NA = (UsuarioBE499NA)dgUsuarios.CurrentRow.DataBoundItem;

                // Alerta 2: Para ver qué usuario leyó de la grilla
                MessageBox.Show($"Usuario seleccionado para desbloquear: {seleccionado499NA.NombreUsuario499NA}\nEstado Bloqueo: {seleccionado499NA.Bloqueo499NA}", "Paso 2");

                // Alerta 3: Justo antes de ir a la base de datos
                MessageBox.Show("Invocando a la BLL para actualizar SQL...", "Paso 3");

                usuariosBLL499NA.DesbloquearUsuario499NA(seleccionado499NA.NombreUsuario499NA);

                // Alerta 4: Si llegó acá, la base de datos no falló
                MessageBox.Show("La BLL ejecutó con éxito. Refrescando interfaz...", "Paso 4");

                cbBloqueado.Checked = false;
                lblMensajeSistema.Text = $"El usuario '{seleccionado499NA.NombreUsuario499NA}' fue desbloqueado con éxito.";

                LlenarGrilla499NA();
            }
            catch (Exception ex)
            {
                // Forzamos a que el error salte en un cartel flotante sí o sí
                MessageBox.Show("Saltó un error en el proceso:\n\n" + ex.Message, "ERROR CRÍTICO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
