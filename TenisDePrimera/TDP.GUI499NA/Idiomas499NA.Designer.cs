namespace TDP.GUI499NA
{
    partial class Idiomas499NA
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
            this.cmbIdiomas = new System.Windows.Forms.ComboBox();
            this.btnCambiarIdioma = new System.Windows.Forms.Button();
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gbSeleccionarIdioma = new System.Windows.Forms.GroupBox();
            this.gbSeleccionarIdioma.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbIdiomas
            // 
            this.cmbIdiomas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdiomas.FormattingEnabled = true;
            this.cmbIdiomas.Location = new System.Drawing.Point(342, 145);
            this.cmbIdiomas.Name = "cmbIdiomas";
            this.cmbIdiomas.Size = new System.Drawing.Size(178, 24);
            this.cmbIdiomas.TabIndex = 1;
            // 
            // btnCambiarIdioma
            // 
            this.btnCambiarIdioma.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCambiarIdioma.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnCambiarIdioma.FlatAppearance.BorderSize = 2;
            this.btnCambiarIdioma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCambiarIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarIdioma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCambiarIdioma.Location = new System.Drawing.Point(162, 243);
            this.btnCambiarIdioma.Name = "btnCambiarIdioma";
            this.btnCambiarIdioma.Size = new System.Drawing.Size(554, 61);
            this.btnCambiarIdioma.TabIndex = 5;
            this.btnCambiarIdioma.Text = "Cambiar Idioma";
            this.btnCambiarIdioma.UseVisualStyleBackColor = false;
            this.btnCambiarIdioma.Click += new System.EventHandler(this.btnCambiarIdioma_Click);
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSeleccionar.Location = new System.Drawing.Point(320, 104);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(226, 29);
            this.lblSeleccionar.TabIndex = 0;
            this.lblSeleccionar.Text = "Seleccionar Idioma:";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.btnVolver.Location = new System.Drawing.Point(162, 323);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(554, 61);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // gbSeleccionarIdioma
            // 
            this.gbSeleccionarIdioma.Controls.Add(this.btnVolver);
            this.gbSeleccionarIdioma.Controls.Add(this.lblSeleccionar);
            this.gbSeleccionarIdioma.Controls.Add(this.btnCambiarIdioma);
            this.gbSeleccionarIdioma.Controls.Add(this.cmbIdiomas);
            this.gbSeleccionarIdioma.Location = new System.Drawing.Point(313, 37);
            this.gbSeleccionarIdioma.Name = "gbSeleccionarIdioma";
            this.gbSeleccionarIdioma.Size = new System.Drawing.Size(892, 488);
            this.gbSeleccionarIdioma.TabIndex = 6;
            this.gbSeleccionarIdioma.TabStop = false;
            this.gbSeleccionarIdioma.Text = "Seleccionar Idioma";
            // 
            // Idiomas499NA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1442, 694);
            this.Controls.Add(this.gbSeleccionarIdioma);
            this.Name = "Idiomas499NA";
            this.Text = "Idiomas499NA";
            this.Load += new System.EventHandler(this.Idiomas499NA_Load);
            this.gbSeleccionarIdioma.ResumeLayout(false);
            this.gbSeleccionarIdioma.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIdiomas;
        private System.Windows.Forms.Button btnCambiarIdioma;
        private System.Windows.Forms.Label lblSeleccionar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox gbSeleccionarIdioma;
    }
}