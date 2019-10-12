namespace VentaDeRepuestos.Administrador
{
    partial class CrearUsuario
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
            this.SuspendLayout();
            // 
            // cbPerfil
            // 
            this.cbPerfil.Size = new System.Drawing.Size(230, 24);
            this.cbPerfil.SelectedIndexChanged += new System.EventHandler(this.CbPerfil_SelectedIndexChanged);
            // 
            // cbCargo
            // 
            this.cbCargo.Size = new System.Drawing.Size(230, 24);
            this.cbCargo.SelectedIndexChanged += new System.EventHandler(this.CbCargo_SelectedIndexChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.Size = new System.Drawing.Size(74, 24);
            this.cbEstadoCivil.SelectedIndexChanged += new System.EventHandler(this.CbEstadoCivil_SelectedIndexChanged);
            // 
            // cbSexo
            // 
            this.cbSexo.Size = new System.Drawing.Size(74, 24);
            this.cbSexo.SelectedIndexChanged += new System.EventHandler(this.CbSexo_SelectedIndexChanged);
            // 
            // btnCrear
            // 
            this.btnCrear.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCrear.FlatAppearance.BorderSize = 2;
            this.btnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "CrearUsuario";
            this.Text = "CrearUsuario";
            this.Load += new System.EventHandler(this.CrearUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}