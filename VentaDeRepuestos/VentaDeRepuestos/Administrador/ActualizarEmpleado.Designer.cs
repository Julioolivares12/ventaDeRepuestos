namespace VentaDeRepuestos.Administrador
{
    partial class ActualizarEmpleado
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
            this.txtCargoActual = new System.Windows.Forms.TextBox();
            this.txtPerfilActual = new System.Windows.Forms.TextBox();
            this.txtSexoActual = new System.Windows.Forms.TextBox();
            this.txtEstadoActual = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(424, 158);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(418, 103);
            // 
            // cbPerfil
            // 
            this.cbPerfil.Location = new System.Drawing.Point(470, 158);
            this.cbPerfil.Size = new System.Drawing.Size(138, 24);
            // 
            // cbCargo
            // 
            this.cbCargo.Location = new System.Drawing.Point(470, 100);
            this.cbCargo.Size = new System.Drawing.Size(138, 24);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(475, 36);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(418, 36);
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.Size = new System.Drawing.Size(74, 24);
            // 
            // cbSexo
            // 
            this.cbSexo.Size = new System.Drawing.Size(74, 24);
            // 
            // btnCrear
            // 
            this.btnCrear.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCrear.FlatAppearance.BorderSize = 2;
            this.btnCrear.Location = new System.Drawing.Point(470, 202);
            this.btnCrear.Text = "Actualizar";
            this.btnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // txtCargoActual
            // 
            this.txtCargoActual.Location = new System.Drawing.Point(624, 103);
            this.txtCargoActual.Name = "txtCargoActual";
            this.txtCargoActual.Size = new System.Drawing.Size(148, 22);
            this.txtCargoActual.TabIndex = 52;
            // 
            // txtPerfilActual
            // 
            this.txtPerfilActual.Location = new System.Drawing.Point(624, 158);
            this.txtPerfilActual.Name = "txtPerfilActual";
            this.txtPerfilActual.Size = new System.Drawing.Size(148, 22);
            this.txtPerfilActual.TabIndex = 53;
            // 
            // txtSexoActual
            // 
            this.txtSexoActual.Location = new System.Drawing.Point(284, 350);
            this.txtSexoActual.Name = "txtSexoActual";
            this.txtSexoActual.Size = new System.Drawing.Size(52, 22);
            this.txtSexoActual.TabIndex = 54;
            // 
            // txtEstadoActual
            // 
            this.txtEstadoActual.Location = new System.Drawing.Point(284, 398);
            this.txtEstadoActual.Name = "txtEstadoActual";
            this.txtEstadoActual.Size = new System.Drawing.Size(52, 22);
            this.txtEstadoActual.TabIndex = 55;
            // 
            // ActualizarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEstadoActual);
            this.Controls.Add(this.txtSexoActual);
            this.Controls.Add(this.txtPerfilActual);
            this.Controls.Add(this.txtCargoActual);
            this.Name = "ActualizarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActualizarEmpleado";
            this.Load += new System.EventHandler(this.ActualizarEmpleado_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtPrimerNombre, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtSegundoNombre, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtPrimerApellido, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtSegundoApellido, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtDireccion, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtTelefono, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtFechaNac, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.cbSexo, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.cbEstadoCivil, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.cbCargo, 0);
            this.Controls.SetChildIndex(this.cbPerfil, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.btnCrear, 0);
            this.Controls.SetChildIndex(this.txtCargoActual, 0);
            this.Controls.SetChildIndex(this.txtPerfilActual, 0);
            this.Controls.SetChildIndex(this.txtSexoActual, 0);
            this.Controls.SetChildIndex(this.txtEstadoActual, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCargoActual;
        private System.Windows.Forms.TextBox txtPerfilActual;
        private System.Windows.Forms.TextBox txtSexoActual;
        private System.Windows.Forms.TextBox txtEstadoActual;
    }
}