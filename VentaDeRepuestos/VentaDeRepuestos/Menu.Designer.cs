namespace VentaDeRepuestos
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.puntoDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foliosYAsignacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoEmpreadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelosDeVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arqueoDiarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clasesDeVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partesDeVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 532);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(843, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puntoDToolStripMenuItem,
            this.foliosYAsignacionesToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.arqueoDiarioToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // puntoDToolStripMenuItem
            // 
            this.puntoDToolStripMenuItem.Name = "puntoDToolStripMenuItem";
            this.puntoDToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.puntoDToolStripMenuItem.Text = "punto de venta";
            // 
            // foliosYAsignacionesToolStripMenuItem
            // 
            this.foliosYAsignacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoEmpreadosToolStripMenuItem,
            this.modelosDeVehiculoToolStripMenuItem,
            this.clasesDeVehiculoToolStripMenuItem,
            this.tiposDeVehiculosToolStripMenuItem,
            this.partesDeVehiculosToolStripMenuItem});
            this.foliosYAsignacionesToolStripMenuItem.Name = "foliosYAsignacionesToolStripMenuItem";
            this.foliosYAsignacionesToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.foliosYAsignacionesToolStripMenuItem.Text = "Mantenimientos";
            // 
            // mantenimientoEmpreadosToolStripMenuItem
            // 
            this.mantenimientoEmpreadosToolStripMenuItem.Name = "mantenimientoEmpreadosToolStripMenuItem";
            this.mantenimientoEmpreadosToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.mantenimientoEmpreadosToolStripMenuItem.Text = "Mantenimiento empreados";
            this.mantenimientoEmpreadosToolStripMenuItem.Click += new System.EventHandler(this.MantenimientoEmpreadosToolStripMenuItem_Click);
            // 
            // modelosDeVehiculoToolStripMenuItem
            // 
            this.modelosDeVehiculoToolStripMenuItem.Name = "modelosDeVehiculoToolStripMenuItem";
            this.modelosDeVehiculoToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.modelosDeVehiculoToolStripMenuItem.Text = "Modelos de vehiculo";
            this.modelosDeVehiculoToolStripMenuItem.Click += new System.EventHandler(this.ModelosDeVehiculoToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // arqueoDiarioToolStripMenuItem
            // 
            this.arqueoDiarioToolStripMenuItem.Name = "arqueoDiarioToolStripMenuItem";
            this.arqueoDiarioToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.arqueoDiarioToolStripMenuItem.Text = "Arqueo Diario";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.EmpleadosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.salirToolStripMenuItem.Text = "salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // clasesDeVehiculoToolStripMenuItem
            // 
            this.clasesDeVehiculoToolStripMenuItem.Name = "clasesDeVehiculoToolStripMenuItem";
            this.clasesDeVehiculoToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.clasesDeVehiculoToolStripMenuItem.Text = "Clases de vehiculo";
            this.clasesDeVehiculoToolStripMenuItem.Click += new System.EventHandler(this.ClasesDeVehiculoToolStripMenuItem_Click);
            // 
            // tiposDeVehiculosToolStripMenuItem
            // 
            this.tiposDeVehiculosToolStripMenuItem.Name = "tiposDeVehiculosToolStripMenuItem";
            this.tiposDeVehiculosToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.tiposDeVehiculosToolStripMenuItem.Text = "tipos de vehiculos";
            this.tiposDeVehiculosToolStripMenuItem.Click += new System.EventHandler(this.TiposDeVehiculosToolStripMenuItem_Click);
            // 
            // partesDeVehiculosToolStripMenuItem
            // 
            this.partesDeVehiculosToolStripMenuItem.Name = "partesDeVehiculosToolStripMenuItem";
            this.partesDeVehiculosToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.partesDeVehiculosToolStripMenuItem.Text = "partes de vehiculos";
            this.partesDeVehiculosToolStripMenuItem.Click += new System.EventHandler(this.PartesDeVehiculosToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem puntoDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foliosYAsignacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arqueoDiarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoEmpreadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelosDeVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clasesDeVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partesDeVehiculosToolStripMenuItem;
    }
}



