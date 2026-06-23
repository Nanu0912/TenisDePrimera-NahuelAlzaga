namespace TDP.GUI499NA
{
    partial class Perfiles499NA
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
            this.twPerfiles = new System.Windows.Forms.TreeView();
            this.gbCrearComponentes = new System.Windows.Forms.GroupBox();
            this.btnEliminarComponente = new System.Windows.Forms.Button();
            this.btnCrearComponente = new System.Windows.Forms.Button();
            this.chkEsFamilia = new System.Windows.Forms.CheckBox();
            this.txtNombreComponente = new System.Windows.Forms.TextBox();
            this.gbAgregarAsignarArbol = new System.Windows.Forms.GroupBox();
            this.btnAgregarAlArbol = new System.Windows.Forms.Button();
            this.cmbComponentesSueltos = new System.Windows.Forms.ComboBox();
            this.gbQuitarDelArbol = new System.Windows.Forms.GroupBox();
            this.btnQuitarDelArbol = new System.Windows.Forms.Button();
            this.lblMensajeSistema = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbCrearComponentes.SuspendLayout();
            this.gbAgregarAsignarArbol.SuspendLayout();
            this.gbQuitarDelArbol.SuspendLayout();
            this.SuspendLayout();
            // 
            // twPerfiles
            // 
            this.twPerfiles.Location = new System.Drawing.Point(31, 12);
            this.twPerfiles.Name = "twPerfiles";
            this.twPerfiles.Size = new System.Drawing.Size(788, 499);
            this.twPerfiles.TabIndex = 0;
            // 
            // gbCrearComponentes
            // 
            this.gbCrearComponentes.Controls.Add(this.btnEliminarComponente);
            this.gbCrearComponentes.Controls.Add(this.btnCrearComponente);
            this.gbCrearComponentes.Controls.Add(this.chkEsFamilia);
            this.gbCrearComponentes.Controls.Add(this.txtNombreComponente);
            this.gbCrearComponentes.Location = new System.Drawing.Point(936, 12);
            this.gbCrearComponentes.Name = "gbCrearComponentes";
            this.gbCrearComponentes.Size = new System.Drawing.Size(353, 275);
            this.gbCrearComponentes.TabIndex = 1;
            this.gbCrearComponentes.TabStop = false;
            this.gbCrearComponentes.Text = "Crear Componentes";
            // 
            // btnEliminarComponente
            // 
            this.btnEliminarComponente.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEliminarComponente.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnEliminarComponente.FlatAppearance.BorderSize = 2;
            this.btnEliminarComponente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarComponente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarComponente.Location = new System.Drawing.Point(71, 200);
            this.btnEliminarComponente.Name = "btnEliminarComponente";
            this.btnEliminarComponente.Size = new System.Drawing.Size(187, 61);
            this.btnEliminarComponente.TabIndex = 8;
            this.btnEliminarComponente.Text = "Eliminar Seleccionado";
            this.btnEliminarComponente.UseVisualStyleBackColor = false;
            this.btnEliminarComponente.Click += new System.EventHandler(this.btnEliminarComponente_Click);
            // 
            // btnCrearComponente
            // 
            this.btnCrearComponente.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCrearComponente.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnCrearComponente.FlatAppearance.BorderSize = 2;
            this.btnCrearComponente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrearComponente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCrearComponente.Location = new System.Drawing.Point(71, 118);
            this.btnCrearComponente.Name = "btnCrearComponente";
            this.btnCrearComponente.Size = new System.Drawing.Size(187, 61);
            this.btnCrearComponente.TabIndex = 5;
            this.btnCrearComponente.Text = "Crear Nuevo";
            this.btnCrearComponente.UseVisualStyleBackColor = false;
            this.btnCrearComponente.Click += new System.EventHandler(this.btnCrearComponente_Click);
            // 
            // chkEsFamilia
            // 
            this.chkEsFamilia.AutoSize = true;
            this.chkEsFamilia.Location = new System.Drawing.Point(71, 83);
            this.chkEsFamilia.Name = "chkEsFamilia";
            this.chkEsFamilia.Size = new System.Drawing.Size(126, 20);
            this.chkEsFamilia.TabIndex = 7;
            this.chkEsFamilia.Text = "Es Familia/Perfil";
            this.chkEsFamilia.UseVisualStyleBackColor = true;
            // 
            // txtNombreComponente
            // 
            this.txtNombreComponente.Location = new System.Drawing.Point(71, 43);
            this.txtNombreComponente.Name = "txtNombreComponente";
            this.txtNombreComponente.Size = new System.Drawing.Size(187, 22);
            this.txtNombreComponente.TabIndex = 6;
            // 
            // gbAgregarAsignarArbol
            // 
            this.gbAgregarAsignarArbol.Controls.Add(this.btnAgregarAlArbol);
            this.gbAgregarAsignarArbol.Controls.Add(this.cmbComponentesSueltos);
            this.gbAgregarAsignarArbol.Location = new System.Drawing.Point(936, 293);
            this.gbAgregarAsignarArbol.Name = "gbAgregarAsignarArbol";
            this.gbAgregarAsignarArbol.Size = new System.Drawing.Size(353, 218);
            this.gbAgregarAsignarArbol.TabIndex = 9;
            this.gbAgregarAsignarArbol.TabStop = false;
            this.gbAgregarAsignarArbol.Text = "Asignar / Agregar Arbol";
            // 
            // btnAgregarAlArbol
            // 
            this.btnAgregarAlArbol.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAgregarAlArbol.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnAgregarAlArbol.FlatAppearance.BorderSize = 2;
            this.btnAgregarAlArbol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarAlArbol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarAlArbol.Location = new System.Drawing.Point(71, 127);
            this.btnAgregarAlArbol.Name = "btnAgregarAlArbol";
            this.btnAgregarAlArbol.Size = new System.Drawing.Size(187, 61);
            this.btnAgregarAlArbol.TabIndex = 7;
            this.btnAgregarAlArbol.Text = "Agregar a Seleccion";
            this.btnAgregarAlArbol.UseVisualStyleBackColor = false;
            this.btnAgregarAlArbol.Click += new System.EventHandler(this.btnAgregarAlArbol_Click);
            // 
            // cmbComponentesSueltos
            // 
            this.cmbComponentesSueltos.FormattingEnabled = true;
            this.cmbComponentesSueltos.Location = new System.Drawing.Point(71, 47);
            this.cmbComponentesSueltos.Name = "cmbComponentesSueltos";
            this.cmbComponentesSueltos.Size = new System.Drawing.Size(187, 24);
            this.cmbComponentesSueltos.TabIndex = 6;
            // 
            // gbQuitarDelArbol
            // 
            this.gbQuitarDelArbol.Controls.Add(this.btnQuitarDelArbol);
            this.gbQuitarDelArbol.Location = new System.Drawing.Point(936, 517);
            this.gbQuitarDelArbol.Name = "gbQuitarDelArbol";
            this.gbQuitarDelArbol.Size = new System.Drawing.Size(353, 119);
            this.gbQuitarDelArbol.TabIndex = 10;
            this.gbQuitarDelArbol.TabStop = false;
            this.gbQuitarDelArbol.Text = "Quitar del Arbol";
            // 
            // btnQuitarDelArbol
            // 
            this.btnQuitarDelArbol.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnQuitarDelArbol.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnQuitarDelArbol.FlatAppearance.BorderSize = 2;
            this.btnQuitarDelArbol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuitarDelArbol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQuitarDelArbol.Location = new System.Drawing.Point(71, 36);
            this.btnQuitarDelArbol.Name = "btnQuitarDelArbol";
            this.btnQuitarDelArbol.Size = new System.Drawing.Size(187, 61);
            this.btnQuitarDelArbol.TabIndex = 7;
            this.btnQuitarDelArbol.Text = "Quitar";
            this.btnQuitarDelArbol.UseVisualStyleBackColor = false;
            this.btnQuitarDelArbol.Click += new System.EventHandler(this.btnQuitarDelArbol_Click);
            // 
            // lblMensajeSistema
            // 
            this.lblMensajeSistema.AutoSize = true;
            this.lblMensajeSistema.ForeColor = System.Drawing.Color.Transparent;
            this.lblMensajeSistema.Location = new System.Drawing.Point(28, 575);
            this.lblMensajeSistema.Name = "lblMensajeSistema";
            this.lblMensajeSistema.Size = new System.Drawing.Size(44, 16);
            this.lblMensajeSistema.TabIndex = 11;
            this.lblMensajeSistema.Text = "label1";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Location = new System.Drawing.Point(632, 575);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(187, 61);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Perfiles499NA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1431, 664);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblMensajeSistema);
            this.Controls.Add(this.gbQuitarDelArbol);
            this.Controls.Add(this.gbAgregarAsignarArbol);
            this.Controls.Add(this.gbCrearComponentes);
            this.Controls.Add(this.twPerfiles);
            this.Name = "Perfiles499NA";
            this.Text = "Perfiles499NA";
            this.Load += new System.EventHandler(this.Perfiles499NA_Load);
            this.gbCrearComponentes.ResumeLayout(false);
            this.gbCrearComponentes.PerformLayout();
            this.gbAgregarAsignarArbol.ResumeLayout(false);
            this.gbQuitarDelArbol.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView twPerfiles;
        private System.Windows.Forms.GroupBox gbCrearComponentes;
        private System.Windows.Forms.CheckBox chkEsFamilia;
        private System.Windows.Forms.TextBox txtNombreComponente;
        private System.Windows.Forms.Button btnEliminarComponente;
        private System.Windows.Forms.Button btnCrearComponente;
        private System.Windows.Forms.GroupBox gbAgregarAsignarArbol;
        private System.Windows.Forms.ComboBox cmbComponentesSueltos;
        private System.Windows.Forms.Button btnAgregarAlArbol;
        private System.Windows.Forms.GroupBox gbQuitarDelArbol;
        private System.Windows.Forms.Button btnQuitarDelArbol;
        private System.Windows.Forms.Label lblMensajeSistema;
        private System.Windows.Forms.Button btnSalir;
    }
}