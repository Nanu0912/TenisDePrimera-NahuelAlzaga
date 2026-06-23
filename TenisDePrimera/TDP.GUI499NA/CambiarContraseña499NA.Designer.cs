namespace TDP.GUI499NA
{
    partial class CambiarContraseña499NA
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
            this.lblContraseñaNueva = new System.Windows.Forms.Label();
            this.lblContraseñaActual = new System.Windows.Forms.Label();
            this.txtContraseñaNueva = new System.Windows.Forms.TextBox();
            this.txtContraseñaActual = new System.Windows.Forms.TextBox();
            this.lblConfirmarContraseña = new System.Windows.Forms.Label();
            this.txtConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContraseñaNueva
            // 
            this.lblContraseñaNueva.AutoSize = true;
            this.lblContraseñaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblContraseñaNueva.Location = new System.Drawing.Point(446, 202);
            this.lblContraseñaNueva.Name = "lblContraseñaNueva";
            this.lblContraseñaNueva.Size = new System.Drawing.Size(147, 20);
            this.lblContraseñaNueva.TabIndex = 7;
            this.lblContraseñaNueva.Text = "Contraseña Nueva";
            // 
            // lblContraseñaActual
            // 
            this.lblContraseñaActual.AutoSize = true;
            this.lblContraseñaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblContraseñaActual.Location = new System.Drawing.Point(446, 140);
            this.lblContraseñaActual.Name = "lblContraseñaActual";
            this.lblContraseñaActual.Size = new System.Drawing.Size(147, 20);
            this.lblContraseñaActual.TabIndex = 6;
            this.lblContraseñaActual.Text = "Contraseña Actual";
            // 
            // txtContraseñaNueva
            // 
            this.txtContraseñaNueva.Location = new System.Drawing.Point(636, 202);
            this.txtContraseñaNueva.Name = "txtContraseñaNueva";
            this.txtContraseñaNueva.Size = new System.Drawing.Size(250, 22);
            this.txtContraseñaNueva.TabIndex = 5;
            // 
            // txtContraseñaActual
            // 
            this.txtContraseñaActual.Location = new System.Drawing.Point(636, 138);
            this.txtContraseñaActual.Name = "txtContraseñaActual";
            this.txtContraseñaActual.Size = new System.Drawing.Size(250, 22);
            this.txtContraseñaActual.TabIndex = 4;
            // 
            // lblConfirmarContraseña
            // 
            this.lblConfirmarContraseña.AutoSize = true;
            this.lblConfirmarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblConfirmarContraseña.Location = new System.Drawing.Point(428, 265);
            this.lblConfirmarContraseña.Name = "lblConfirmarContraseña";
            this.lblConfirmarContraseña.Size = new System.Drawing.Size(174, 20);
            this.lblConfirmarContraseña.TabIndex = 9;
            this.lblConfirmarContraseña.Text = "Confirmar Contraseña";
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(636, 263);
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(250, 22);
            this.txtConfirmarContraseña.TabIndex = 8;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.btnConfirmar.Location = new System.Drawing.Point(450, 332);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(461, 42);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.btnVolver.Location = new System.Drawing.Point(450, 392);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(461, 42);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // CambiarContraseña499NA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1423, 583);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblConfirmarContraseña);
            this.Controls.Add(this.txtConfirmarContraseña);
            this.Controls.Add(this.lblContraseñaNueva);
            this.Controls.Add(this.lblContraseñaActual);
            this.Controls.Add(this.txtContraseñaNueva);
            this.Controls.Add(this.txtContraseñaActual);
            this.Name = "CambiarContraseña499NA";
            this.Text = "CambiarContraseña499NA";
            this.Load += new System.EventHandler(this.CambiarContraseña499NA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContraseñaNueva;
        private System.Windows.Forms.Label lblContraseñaActual;
        private System.Windows.Forms.TextBox txtContraseñaNueva;
        private System.Windows.Forms.TextBox txtContraseñaActual;
        private System.Windows.Forms.Label lblConfirmarContraseña;
        private System.Windows.Forms.TextBox txtConfirmarContraseña;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnVolver;
    }
}