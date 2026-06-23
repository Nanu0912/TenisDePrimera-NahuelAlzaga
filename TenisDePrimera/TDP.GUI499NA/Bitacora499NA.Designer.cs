namespace TDP.GUI499NA
{
    partial class Bitacora499NA
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
            this.lblBITACORADEEVENTOS = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgBitacora = new System.Windows.Forms.DataGridView();
            this.NombreUsuario499NA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha499NA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora499NA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modulo499NA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evento499NA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Criticidad499NA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblModulo = new System.Windows.Forms.Label();
            this.txtModulo = new System.Windows.Forms.TextBox();
            this.lblNombreDeUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblCriticidad = new System.Windows.Forms.Label();
            this.txtCriticidad = new System.Windows.Forms.TextBox();
            this.lblEvento = new System.Windows.Forms.Label();
            this.txtEvento = new System.Windows.Forms.TextBox();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBITACORADEEVENTOS
            // 
            this.lblBITACORADEEVENTOS.AutoSize = true;
            this.lblBITACORADEEVENTOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.lblBITACORADEEVENTOS.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBITACORADEEVENTOS.Location = new System.Drawing.Point(106, 42);
            this.lblBITACORADEEVENTOS.Name = "lblBITACORADEEVENTOS";
            this.lblBITACORADEEVENTOS.Size = new System.Drawing.Size(368, 36);
            this.lblBITACORADEEVENTOS.TabIndex = 1;
            this.lblBITACORADEEVENTOS.Text = "BITACORA DE EVENTOS";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnLimpiar.FlatAppearance.BorderSize = 2;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpiar.Location = new System.Drawing.Point(123, 522);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(199, 61);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAplicar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnAplicar.FlatAppearance.BorderSize = 2;
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAplicar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAplicar.Location = new System.Drawing.Point(434, 522);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(199, 61);
            this.btnAplicar.TabIndex = 6;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = false;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnImprimir.FlatAppearance.BorderSize = 2;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnImprimir.Location = new System.Drawing.Point(773, 522);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(199, 61);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Location = new System.Drawing.Point(1022, 42);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(199, 61);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgBitacora
            // 
            this.dgBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBitacora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreUsuario499NA,
            this.Fecha499NA,
            this.Hora499NA,
            this.Modulo499NA,
            this.Evento499NA,
            this.Criticidad499NA});
            this.dgBitacora.Location = new System.Drawing.Point(39, 109);
            this.dgBitacora.Name = "dgBitacora";
            this.dgBitacora.RowHeadersWidth = 51;
            this.dgBitacora.RowTemplate.Height = 24;
            this.dgBitacora.Size = new System.Drawing.Size(1182, 249);
            this.dgBitacora.TabIndex = 11;
            // 
            // NombreUsuario499NA
            // 
            this.NombreUsuario499NA.DataPropertyName = "NombreUsuario499NA";
            this.NombreUsuario499NA.HeaderText = "Nombre de Usuario";
            this.NombreUsuario499NA.MinimumWidth = 6;
            this.NombreUsuario499NA.Name = "NombreUsuario499NA";
            this.NombreUsuario499NA.Width = 125;
            // 
            // Fecha499NA
            // 
            this.Fecha499NA.DataPropertyName = "Fecha499NA";
            this.Fecha499NA.HeaderText = "Fecha";
            this.Fecha499NA.MinimumWidth = 6;
            this.Fecha499NA.Name = "Fecha499NA";
            this.Fecha499NA.Width = 125;
            // 
            // Hora499NA
            // 
            this.Hora499NA.DataPropertyName = "Hora499NA";
            this.Hora499NA.HeaderText = "Hora";
            this.Hora499NA.MinimumWidth = 6;
            this.Hora499NA.Name = "Hora499NA";
            this.Hora499NA.Width = 125;
            // 
            // Modulo499NA
            // 
            this.Modulo499NA.DataPropertyName = "Modulo499NA";
            this.Modulo499NA.HeaderText = "Modulo";
            this.Modulo499NA.MinimumWidth = 6;
            this.Modulo499NA.Name = "Modulo499NA";
            this.Modulo499NA.Width = 125;
            // 
            // Evento499NA
            // 
            this.Evento499NA.DataPropertyName = "Evento499NA";
            this.Evento499NA.HeaderText = "Evento";
            this.Evento499NA.MinimumWidth = 6;
            this.Evento499NA.Name = "Evento499NA";
            this.Evento499NA.Width = 125;
            // 
            // Criticidad499NA
            // 
            this.Criticidad499NA.DataPropertyName = "Criticidad499NA";
            this.Criticidad499NA.HeaderText = "Criticidad";
            this.Criticidad499NA.MinimumWidth = 6;
            this.Criticidad499NA.Name = "Criticidad499NA";
            this.Criticidad499NA.Width = 125;
            // 
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.Location = new System.Drawing.Point(135, 450);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(52, 16);
            this.lblModulo.TabIndex = 17;
            this.lblModulo.Text = "Modulo";
            // 
            // txtModulo
            // 
            this.txtModulo.Location = new System.Drawing.Point(225, 444);
            this.txtModulo.Name = "txtModulo";
            this.txtModulo.Size = new System.Drawing.Size(182, 22);
            this.txtModulo.TabIndex = 16;
            // 
            // lblNombreDeUsuario
            // 
            this.lblNombreDeUsuario.AutoSize = true;
            this.lblNombreDeUsuario.Location = new System.Drawing.Point(73, 386);
            this.lblNombreDeUsuario.Name = "lblNombreDeUsuario";
            this.lblNombreDeUsuario.Size = new System.Drawing.Size(125, 16);
            this.lblNombreDeUsuario.TabIndex = 15;
            this.lblNombreDeUsuario.Text = "Nombre de Usuario";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(225, 380);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(182, 22);
            this.txtNombreUsuario.TabIndex = 14;
            // 
            // lblCriticidad
            // 
            this.lblCriticidad.AutoSize = true;
            this.lblCriticidad.Location = new System.Drawing.Point(747, 450);
            this.lblCriticidad.Name = "lblCriticidad";
            this.lblCriticidad.Size = new System.Drawing.Size(63, 16);
            this.lblCriticidad.TabIndex = 21;
            this.lblCriticidad.Text = "Criticidad";
            // 
            // txtCriticidad
            // 
            this.txtCriticidad.Location = new System.Drawing.Point(840, 444);
            this.txtCriticidad.Name = "txtCriticidad";
            this.txtCriticidad.Size = new System.Drawing.Size(182, 22);
            this.txtCriticidad.TabIndex = 20;
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Location = new System.Drawing.Point(445, 450);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(49, 16);
            this.lblEvento.TabIndex = 19;
            this.lblEvento.Text = "Evento";
            // 
            // txtEvento
            // 
            this.txtEvento.Location = new System.Drawing.Point(543, 444);
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(182, 22);
            this.txtEvento.TabIndex = 18;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(431, 386);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(79, 16);
            this.lblFechaInicio.TabIndex = 23;
            this.lblFechaInicio.Text = "Fecha Inicio";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(747, 386);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(66, 16);
            this.lblFechaFin.TabIndex = 25;
            this.lblFechaFin.Text = "Fecha Fin";
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Location = new System.Drawing.Point(543, 381);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(182, 22);
            this.dtFechaInicio.TabIndex = 26;
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Location = new System.Drawing.Point(840, 381);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(182, 22);
            this.dtFechaFin.TabIndex = 27;
            // 
            // Bitacora499NA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1302, 610);
            this.Controls.Add(this.dtFechaFin);
            this.Controls.Add(this.dtFechaInicio);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.lblCriticidad);
            this.Controls.Add(this.txtCriticidad);
            this.Controls.Add(this.lblEvento);
            this.Controls.Add(this.txtEvento);
            this.Controls.Add(this.lblModulo);
            this.Controls.Add(this.txtModulo);
            this.Controls.Add(this.lblNombreDeUsuario);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.dgBitacora);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblBITACORADEEVENTOS);
            this.Name = "Bitacora499NA";
            this.Text = "Bitacora499NA";
            this.Load += new System.EventHandler(this.Bitacora499NA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBITACORADEEVENTOS;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgBitacora;
        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.TextBox txtModulo;
        private System.Windows.Forms.Label lblNombreDeUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblCriticidad;
        private System.Windows.Forms.TextBox txtCriticidad;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.TextBox txtEvento;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario499NA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha499NA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora499NA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modulo499NA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evento499NA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Criticidad499NA;
    }
}