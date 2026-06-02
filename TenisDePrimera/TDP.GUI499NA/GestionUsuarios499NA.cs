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
using TDP.BLL499NA;
using TDP.Servicios499NA;

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
            rbActivos.Checked = true; 
            CargarRolesMock499NA();
            LlenarGrilla499NA();
            AlternarCampos499NA(false);
        }

        private void gbNotificaciones_Enter(object sender, EventArgs e)
        {
            lblMensajeSistema.Text = "";
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
                List<UsuarioServicios499NA> usuarios = usuariosBLL499NA.ListarUsuarios499NA(verTodos);

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
                BLL499NA.BitacoraBLL499NA bitacoraBLL = new BLL499NA.BitacoraBLL499NA();

                if (accionActual499NA == "ALTA")
                {
                    if (string.IsNullOrEmpty(txtNombre.Text.Trim()) || string.IsNullOrEmpty(txtDNI.Text.Trim()))
                    {
                        throw new Exception("El Nombre y el DNI son obligatorios para generar la contraseña inicial.");
                    }

                    string contraseña = (txtNombre.Text.Trim() + txtDNI.Text.Trim());

                    string nombreusuario = txtNombre.Text.Trim() + txtApellido.Text.Trim();

                    UsuarioServicios499NA nuevo = new UsuarioServicios499NA
                    {
                        Dni499NA = txtDNI.Text.Trim(),
                        Nombre499NA = txtNombre.Text.Trim(),
                        Apellidos499NA = txtApellido.Text.Trim(),
                        Email499NA = txtEmail.Text.Trim(),

                        NombreUsuario499NA = nombreusuario,

                        Rol499NA = listRol.SelectedItem.ToString(),
                        Activo499NA = true,
                        Bloqueo499NA = false,
                        Intentos499NA = 0
                    };

                    usuariosBLL499NA.CrearUsuario499NA(nuevo, contraseña);

                    try
                    {
                        string msgAlta = $"Alta de usuario exitosa: {nuevo.NombreUsuario499NA} (Rol: {nuevo.Rol499NA})";
                        bitacoraBLL.RegistrarEvento("Usuarios", msgAlta, 2);
                    }
                    catch (Exception exBit)
                    {
                        System.Diagnostics.Debug.WriteLine("Error bitácora Alta: " + exBit.Message);
                    }

                    lblMensajeSistema.Text = $"Usuario creado con éxito. Usuario: {nombreusuario} | Clave inicial: {contraseña}";
                }
                else if (accionActual499NA == "MODIFICACION")
                {
                    if (dgUsuarios.CurrentRow == null)
                    {
                        throw new Exception("Debe seleccionar un usuario de la grilla para poder aplicar las modificaciones.");
                    }

                    string usuarioSeleccionadoEnGrilla = dgUsuarios.CurrentRow.Cells["NombreUsuario499NA"].Value.ToString();

                    UsuarioServicios499NA editado = new UsuarioServicios499NA
                    {
                        NombreUsuario499NA = usuarioSeleccionadoEnGrilla,

                        Dni499NA = txtDNI.Text.Trim(),
                        Nombre499NA = txtNombre.Text.Trim(),
                        Apellidos499NA = txtApellido.Text.Trim(),
                        Email499NA = txtEmail.Text.Trim(),
                        Rol499NA = listRol.SelectedItem.ToString(),

                        Activo499NA = true,
                        Bloqueo499NA = false,
                        Intentos499NA = 0
                    };

                    usuariosBLL499NA.ModificarUsuario499NA(editado);

                    try
                    {
                        string msgMod = $"Modificación de datos exitosa para el usuario: {editado.NombreUsuario499NA}";
                        bitacoraBLL.RegistrarEvento("Usuarios", msgMod, 2);
                    }
                    catch (Exception exBit)
                    {
                        System.Diagnostics.Debug.WriteLine("Error bitácora Modificación: " + exBit.Message);
                    }

                    lblMensajeSistema.Text = $"Usuario '{editado.NombreUsuario499NA}' modificado con éxito.";
                }

                LlenarGrilla499NA();
                AlternarCampos499NA(false);
                accionActual499NA = "";
            }
            catch (Exception ex)
            {
                lblMensajeSistema.Text = "Error al procesar la acción: " + ex.Message;
            }
        }

        private void AlternarCampos499NA(bool estado499NA)
        {
            txtDNI.Enabled = estado499NA;
            txtNombre.Enabled = estado499NA;
            txtApellido.Enabled = estado499NA;
            txtEmail.Enabled = estado499NA;
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
                UsuarioServicios499NA seleccionado = (UsuarioServicios499NA)dgUsuarios.CurrentRow.DataBoundItem;

                txtDNI.Text = seleccionado.Dni499NA;
                txtNombre.Text = seleccionado.Nombre499NA;
                txtApellido.Text = seleccionado.Apellidos499NA;
                txtEmail.Text = seleccionado.Email499NA;

                cbBloqueado.Checked = seleccionado.Bloqueo499NA;
                cbUsuarioActivo.Checked = seleccionado.Activo499NA;

                if (seleccionado.Rol499NA == "Administrador") listRol.SelectedIndex = 0;
                else listRol.SelectedIndex = 1;
            }
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgUsuarios.CurrentRow == null)
                {
                    MessageBox.Show("Por favor, seleccione un usuario de la grilla para desbloquear.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string usuarioSeleccionado = dgUsuarios.CurrentRow.Cells["NombreUsuario499NA"].Value.ToString();

                DialogResult result = MessageBox.Show($"¿Está seguro que desea desbloquear al usuario '{usuarioSeleccionado}'?", "Confirmar Desbloqueo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    usuariosBLL499NA.DesbloquearUsuario499NA(usuarioSeleccionado);
                    try
                    {
                        BLL499NA.BitacoraBLL499NA bitacoraBLL = new BLL499NA.BitacoraBLL499NA();
                        string msgDesbloqueo = $"Desbloqueo de usuario exitoso: {usuarioSeleccionado}";
                        bitacoraBLL.RegistrarEvento("Usuarios", msgDesbloqueo, 2);
                    }
                    catch (Exception exBit)
                    {
                        System.Diagnostics.Debug.WriteLine("Error bitácora Desbloqueo: " + exBit.Message);
                    }
                    LlenarGrilla499NA();
                    lblMensajeSistema.Text = $"El usuario '{usuarioSeleccionado}' ha sido desbloqueado con éxito.";
                }
            }
            catch (Exception ex)
            {
                lblMensajeSistema.Text = "Error al desbloquear usuario: " + ex.Message;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MenuPrincipal499NA mp = new MenuPrincipal499NA();

            mp.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgUsuarios.CurrentRow == null)
                {
                    MessageBox.Show("Por favor, seleccione un usuario de la grilla para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                accionActual499NA = "MODIFICACION";

                AlternarCampos499NA(true);


                txtDNI.Text = dgUsuarios.CurrentRow.Cells["Dni499NA"].Value.ToString();
                txtNombre.Text = dgUsuarios.CurrentRow.Cells["Nombre499NA"].Value.ToString();
                txtApellido.Text = dgUsuarios.CurrentRow.Cells["Apellidos499NA"].Value.ToString();

                if (dgUsuarios.CurrentRow.Cells["Email499NA"] != null && dgUsuarios.CurrentRow.Cells["Email499NA"].Value != null)
                {
                    txtEmail.Text = dgUsuarios.CurrentRow.Cells["Email499NA"].Value.ToString();
                }
                else
                {
                    txtEmail.Text = "";
                }

                listRol.SelectedItem = dgUsuarios.CurrentRow.Cells["Rol499NA"].Value.ToString();

                lblMensajeSistema.Text = "Campos habilitados para la modificación.";
            }
            catch (Exception ex)
            {
                lblMensajeSistema.Text = "Error al cargar modificación: " + ex.Message;
            }

        }

        private void btnActivarDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgUsuarios.CurrentRow == null)
                {
                    MessageBox.Show("Por favor, seleccione un usuario de la grilla para alterar su estado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                UsuarioServicios499NA seleccionado = (UsuarioServicios499NA)dgUsuarios.CurrentRow.DataBoundItem;

                string username = seleccionado.NombreUsuario499NA;
                bool estadoActual = seleccionado.Activo499NA;

                bool nuevoEstado = !estadoActual;
                string accionTexto = nuevoEstado ? "ACTIVAR" : "DESACTIVAR";

                DialogResult result = MessageBox.Show($"¿Está seguro que desea {accionTexto} al usuario '{username}'?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    usuariosBLL499NA.CambiarEstadoActivo499NA(username, nuevoEstado);

                    try
                    {
                        BLL499NA.BitacoraBLL499NA bitacoraBLL = new BLL499NA.BitacoraBLL499NA();
                        string msgBitacora = nuevoEstado
                            ? $"Alta lógica (Activación) del usuario: {username}"
                            : $"Baja lógica (Desactivación) del usuario: {username}";

                        bitacoraBLL.RegistrarEvento("Usuarios", msgBitacora, 2);
                    }
                    catch (Exception exBit)
                    {
                        System.Diagnostics.Debug.WriteLine("Error bitácora Act/Desact: " + exBit.Message);
                    }
                    LlenarGrilla499NA();

                    string msgExito = nuevoEstado ? "activado" : "desactivado";
                    lblMensajeSistema.Text = $"El usuario '{username}' fue {msgExito} con éxito.";
                }
            }
            catch (Exception ex)
            {
                lblMensajeSistema.Text = "Error al cambiar estado del usuario: " + ex.Message;
            }
        }
    }
}
