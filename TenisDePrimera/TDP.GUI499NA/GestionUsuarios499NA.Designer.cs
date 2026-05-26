namespace TDP.GUI499NA
{
    partial class GestionUsuarios499NA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rbActivos = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listRol = new System.Windows.Forms.ListBox();
            this.cbBloqueado = new System.Windows.Forms.CheckBox();
            this.cbUsuarioActivo = new System.Windows.Forms.CheckBox();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnActivarDesactivar = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbNotificaciones = new System.Windows.Forms.GroupBox();
            this.lblMensajeSistema = new System.Windows.Forms.Label();
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            this.btnDesbloquearUsuario = new System.Windows.Forms.Button();
            this.gbNotificaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(59, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "GESTION DE USUARIOS";
            // 
            // rbActivos
            // 
            this.rbActivos.AutoSize = true;
            this.rbActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbActivos.Location = new System.Drawing.Point(912, 48);
            this.rbActivos.Name = "rbActivos";
            this.rbActivos.Size = new System.Drawing.Size(85, 24);
            this.rbActivos.TabIndex = 2;
            this.rbActivos.TabStop = true;
            this.rbActivos.Text = "Activos";
            this.rbActivos.UseVisualStyleBackColor = true;
            this.rbActivos.CheckedChanged += new System.EventHandler(this.rbActivos_CheckedChanged);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbTodos.Location = new System.Drawing.Point(1022, 48);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(76, 24);
            this.rbTodos.TabIndex = 3;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(135, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(193, 384);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(337, 22);
            this.txtDNI.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(193, 422);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(337, 22);
            this.txtNombre.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(105, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(193, 459);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(337, 22);
            this.txtApellido.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(105, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellido";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(193, 497);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(337, 22);
            this.txtEmail.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(122, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(556, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Rol";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(193, 535);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(337, 22);
            this.txtNombreUsuario.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(19, 535);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nombre de Usuario";
            // 
            // listRol
            // 
            this.listRol.FormattingEnabled = true;
            this.listRol.ItemHeight = 16;
            this.listRol.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.listRol.Location = new System.Drawing.Point(560, 410);
            this.listRol.Name = "listRol";
            this.listRol.Size = new System.Drawing.Size(134, 52);
            this.listRol.TabIndex = 20;
            // 
            // cbBloqueado
            // 
            this.cbBloqueado.AutoSize = true;
            this.cbBloqueado.Enabled = false;
            this.cbBloqueado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbBloqueado.ForeColor = System.Drawing.SystemColors.Control;
            this.cbBloqueado.Location = new System.Drawing.Point(193, 574);
            this.cbBloqueado.Name = "cbBloqueado";
            this.cbBloqueado.Size = new System.Drawing.Size(173, 24);
            this.cbBloqueado.TabIndex = 21;
            this.cbBloqueado.Text = "Usuario Bloqueado";
            this.cbBloqueado.UseVisualStyleBackColor = true;
            // 
            // cbUsuarioActivo
            // 
            this.cbUsuarioActivo.AutoSize = true;
            this.cbUsuarioActivo.Enabled = false;
            this.cbUsuarioActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbUsuarioActivo.ForeColor = System.Drawing.SystemColors.Control;
            this.cbUsuarioActivo.Location = new System.Drawing.Point(193, 605);
            this.cbUsuarioActivo.Name = "cbUsuarioActivo";
            this.cbUsuarioActivo.Size = new System.Drawing.Size(140, 24);
            this.cbUsuarioActivo.TabIndex = 22;
            this.cbUsuarioActivo.Text = "Usuario Activo";
            this.cbUsuarioActivo.UseVisualStyleBackColor = true;
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCrearUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnCrearUsuario.FlatAppearance.BorderSize = 2;
            this.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCrearUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCrearUsuario.Location = new System.Drawing.Point(1107, 94);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(199, 61);
            this.btnCrearUsuario.TabIndex = 23;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnModificar.FlatAppearance.BorderSize = 2;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModificar.Location = new System.Drawing.Point(1107, 161);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(199, 61);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnActivarDesactivar
            // 
            this.btnActivarDesactivar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnActivarDesactivar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnActivarDesactivar.FlatAppearance.BorderSize = 2;
            this.btnActivarDesactivar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActivarDesactivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnActivarDesactivar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnActivarDesactivar.Location = new System.Drawing.Point(1107, 295);
            this.btnActivarDesactivar.Name = "btnActivarDesactivar";
            this.btnActivarDesactivar.Size = new System.Drawing.Size(199, 61);
            this.btnActivarDesactivar.TabIndex = 26;
            this.btnActivarDesactivar.Text = "Act. / Desact.";
            this.btnActivarDesactivar.UseVisualStyleBackColor = false;
            // 
            // btnAplicar
            // 
            this.btnAplicar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAplicar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnAplicar.FlatAppearance.BorderSize = 2;
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAplicar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAplicar.Location = new System.Drawing.Point(1107, 362);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(199, 61);
            this.btnAplicar.TabIndex = 27;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = false;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Location = new System.Drawing.Point(1107, 429);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(199, 61);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Location = new System.Drawing.Point(1107, 496);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(199, 61);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbNotificaciones
            // 
            this.gbNotificaciones.BackColor = System.Drawing.Color.White;
            this.gbNotificaciones.Controls.Add(this.lblMensajeSistema);
            this.gbNotificaciones.Location = new System.Drawing.Point(728, 384);
            this.gbNotificaciones.Name = "gbNotificaciones";
            this.gbNotificaciones.Size = new System.Drawing.Size(343, 173);
            this.gbNotificaciones.TabIndex = 30;
            this.gbNotificaciones.TabStop = false;
            this.gbNotificaciones.Text = "Notificaciones";
            this.gbNotificaciones.Enter += new System.EventHandler(this.gbNotificaciones_Enter);
            // 
            // lblMensajeSistema
            // 
            this.lblMensajeSistema.AutoSize = true;
            this.lblMensajeSistema.Location = new System.Drawing.Point(17, 38);
            this.lblMensajeSistema.Name = "lblMensajeSistema";
            this.lblMensajeSistema.Size = new System.Drawing.Size(44, 16);
            this.lblMensajeSistema.TabIndex = 0;
            this.lblMensajeSistema.Text = "label8";
            // 
            // dgUsuarios
            // 
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.Location = new System.Drawing.Point(66, 94);
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.RowHeadersWidth = 51;
            this.dgUsuarios.RowTemplate.Height = 24;
            this.dgUsuarios.Size = new System.Drawing.Size(895, 262);
            this.dgUsuarios.TabIndex = 31;
            this.dgUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsuarios_CellContentClick_1);
            this.dgUsuarios.SelectionChanged += new System.EventHandler(this.dgUsuarios_SelectionChanged);
            // 
            // btnDesbloquearUsuario
            // 
            this.btnDesbloquearUsuario.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDesbloquearUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnDesbloquearUsuario.FlatAppearance.BorderSize = 2;
            this.btnDesbloquearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDesbloquearUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDesbloquearUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDesbloquearUsuario.Location = new System.Drawing.Point(1107, 228);
            this.btnDesbloquearUsuario.Name = "btnDesbloquearUsuario";
            this.btnDesbloquearUsuario.Size = new System.Drawing.Size(199, 61);
            this.btnDesbloquearUsuario.TabIndex = 25;
            this.btnDesbloquearUsuario.Text = "Desbloquear";
            this.btnDesbloquearUsuario.UseVisualStyleBackColor = false;
            this.btnDesbloquearUsuario.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // GestionUsuarios499NA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1342, 653);
            this.Controls.Add(this.dgUsuarios);
            this.Controls.Add(this.gbNotificaciones);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.btnActivarDesactivar);
            this.Controls.Add(this.btnDesbloquearUsuario);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.cbUsuarioActivo);
            this.Controls.Add(this.cbBloqueado);
            this.Controls.Add(this.listRol);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbTodos);
            this.Controls.Add(this.rbActivos);
            this.Controls.Add(this.label1);
            this.Name = "GestionUsuarios499NA";
            this.Text = "GestionUsuarios499NA";
            this.Load += new System.EventHandler(this.GestionUsuarios499NA_Load);
            this.gbNotificaciones.ResumeLayout(false);
            this.gbNotificaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbActivos;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listRol;
        private System.Windows.Forms.CheckBox cbBloqueado;
        private System.Windows.Forms.CheckBox cbUsuarioActivo;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnActivarDesactivar;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbNotificaciones;
        private System.Windows.Forms.Label lblMensajeSistema;
        private System.Windows.Forms.DataGridView dgUsuarios;
        private System.Windows.Forms.Button btnDesbloquearUsuario;
    }
}