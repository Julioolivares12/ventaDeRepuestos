namespace VentaDeRepuestos.Administrador
{
    partial class PuntoVenta
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
            this.cmbDocumento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtTracking = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnClienteNuevo = new System.Windows.Forms.Button();
            this.btnBuscarItem = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.cmbMetodo1 = new System.Windows.Forms.Button();
            this.txtTomar = new System.Windows.Forms.TextBox();
            this.txtDar = new System.Windows.Forms.TextBox();
            this.cmbMetodo2 = new System.Windows.Forms.Button();
            this.txtConsolidado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.btnPagarImprimir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.UPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCUENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_UNITARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REMOVER = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.METODO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUITAR = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDocumento
            // 
            this.cmbDocumento.FormattingEnabled = true;
            this.cmbDocumento.Location = new System.Drawing.Point(105, 30);
            this.cmbDocumento.Name = "cmbDocumento";
            this.cmbDocumento.Size = new System.Drawing.Size(121, 21);
            this.cmbDocumento.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DOCUMENTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CLIENTE";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(105, 70);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(121, 20);
            this.txtCliente.TabIndex = 3;
            // 
            // txtTracking
            // 
            this.txtTracking.Location = new System.Drawing.Point(361, 30);
            this.txtTracking.Name = "txtTracking";
            this.txtTracking.Size = new System.Drawing.Size(121, 20);
            this.txtTracking.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "TRACKING N°";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(604, 30);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(121, 20);
            this.txtFecha.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "FECHA VENTA";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(232, 68);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliente.TabIndex = 8;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // btnClienteNuevo
            // 
            this.btnClienteNuevo.Location = new System.Drawing.Point(313, 67);
            this.btnClienteNuevo.Name = "btnClienteNuevo";
            this.btnClienteNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnClienteNuevo.TabIndex = 9;
            this.btnClienteNuevo.UseVisualStyleBackColor = true;
            // 
            // btnBuscarItem
            // 
            this.btnBuscarItem.Location = new System.Drawing.Point(427, 117);
            this.btnBuscarItem.Name = "btnBuscarItem";
            this.btnBuscarItem.Size = new System.Drawing.Size(48, 23);
            this.btnBuscarItem.TabIndex = 12;
            this.btnBuscarItem.UseVisualStyleBackColor = true;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(141, 120);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(280, 20);
            this.txtItem.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "BUSCAR REPUESTO";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(604, 116);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(121, 20);
            this.txtDescuento.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "DESCUENTO GLOBAL";
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UPC,
            this.DESCRIPCION,
            this.CANTIDAD,
            this.DESCUENTO,
            this.PRECIO_UNITARIO,
            this.PRECIO_TOTAL,
            this.REMOVER});
            this.dgvItems.Location = new System.Drawing.Point(16, 159);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(837, 150);
            this.dgvItems.TabIndex = 15;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(25, 315);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(494, 96);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(732, 315);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(121, 20);
            this.txtIva.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(679, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "IVA: $";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(732, 367);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(121, 20);
            this.txtMontoTotal.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(618, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "MONTO TOTAL: $";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(732, 341);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(121, 20);
            this.txtSubtotal.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(639, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "SUBTOTAL: $";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 420);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "TOMAR";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(216, 417);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 447);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "DAR";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(216, 447);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 25;
            // 
            // cmbMetodo1
            // 
            this.cmbMetodo1.Location = new System.Drawing.Point(346, 415);
            this.cmbMetodo1.Name = "cmbMetodo1";
            this.cmbMetodo1.Size = new System.Drawing.Size(117, 23);
            this.cmbMetodo1.TabIndex = 28;
            this.cmbMetodo1.Text = "TOMAR PAGO";
            this.cmbMetodo1.UseVisualStyleBackColor = true;
            // 
            // txtTomar
            // 
            this.txtTomar.Location = new System.Drawing.Point(74, 417);
            this.txtTomar.Name = "txtTomar";
            this.txtTomar.Size = new System.Drawing.Size(121, 20);
            this.txtTomar.TabIndex = 29;
            // 
            // txtDar
            // 
            this.txtDar.Location = new System.Drawing.Point(74, 447);
            this.txtDar.Name = "txtDar";
            this.txtDar.Size = new System.Drawing.Size(121, 20);
            this.txtDar.TabIndex = 30;
            // 
            // cmbMetodo2
            // 
            this.cmbMetodo2.Location = new System.Drawing.Point(346, 445);
            this.cmbMetodo2.Name = "cmbMetodo2";
            this.cmbMetodo2.Size = new System.Drawing.Size(114, 23);
            this.cmbMetodo2.TabIndex = 31;
            this.cmbMetodo2.Text = "DAR VUELTO";
            this.cmbMetodo2.UseVisualStyleBackColor = true;
            // 
            // txtConsolidado
            // 
            this.txtConsolidado.Location = new System.Drawing.Point(732, 430);
            this.txtConsolidado.Name = "txtConsolidado";
            this.txtConsolidado.Size = new System.Drawing.Size(121, 20);
            this.txtConsolidado.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(618, 437);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "CONSOLIDADO";
            // 
            // dgvPagos
            // 
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TIPO,
            this.METODO,
            this.VALOR,
            this.QUITAR});
            this.dgvPagos.Location = new System.Drawing.Point(25, 483);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.Size = new System.Drawing.Size(494, 98);
            this.dgvPagos.TabIndex = 34;
            // 
            // btnPagarImprimir
            // 
            this.btnPagarImprimir.Location = new System.Drawing.Point(525, 515);
            this.btnPagarImprimir.Name = "btnPagarImprimir";
            this.btnPagarImprimir.Size = new System.Drawing.Size(117, 23);
            this.btnPagarImprimir.TabIndex = 35;
            this.btnPagarImprimir.Text = "PAGAR E IMPRIMIR";
            this.btnPagarImprimir.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(745, 515);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 23);
            this.btnLimpiar.TabIndex = 36;
            this.btnLimpiar.Text = "LIMPIAR TODO";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(648, 515);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(91, 23);
            this.btnPagar.TabIndex = 37;
            this.btnPagar.Text = "SOLO PAGAR";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // UPC
            // 
            this.UPC.Frozen = true;
            this.UPC.HeaderText = "UPC";
            this.UPC.Name = "UPC";
            this.UPC.ReadOnly = true;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.Frozen = true;
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.Frozen = true;
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            // 
            // DESCUENTO
            // 
            this.DESCUENTO.Frozen = true;
            this.DESCUENTO.HeaderText = "DESCUENTO";
            this.DESCUENTO.Name = "DESCUENTO";
            // 
            // PRECIO_UNITARIO
            // 
            this.PRECIO_UNITARIO.Frozen = true;
            this.PRECIO_UNITARIO.HeaderText = "PRECIO UNITARIO";
            this.PRECIO_UNITARIO.Name = "PRECIO_UNITARIO";
            this.PRECIO_UNITARIO.ReadOnly = true;
            // 
            // PRECIO_TOTAL
            // 
            this.PRECIO_TOTAL.HeaderText = "PRECIO TOTAL";
            this.PRECIO_TOTAL.Name = "PRECIO_TOTAL";
            // 
            // REMOVER
            // 
            this.REMOVER.HeaderText = "REMOVER";
            this.REMOVER.Name = "REMOVER";
            // 
            // TIPO
            // 
            this.TIPO.Frozen = true;
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            // 
            // METODO
            // 
            this.METODO.Frozen = true;
            this.METODO.HeaderText = "METODO";
            this.METODO.Name = "METODO";
            this.METODO.ReadOnly = true;
            // 
            // VALOR
            // 
            this.VALOR.Frozen = true;
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            // 
            // QUITAR
            // 
            this.QUITAR.Frozen = true;
            this.QUITAR.HeaderText = "QUITAR";
            this.QUITAR.Name = "QUITAR";
            this.QUITAR.ReadOnly = true;
            // 
            // PuntoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 593);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnPagarImprimir);
            this.Controls.Add(this.dgvPagos);
            this.Controls.Add(this.txtConsolidado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbMetodo2);
            this.Controls.Add(this.txtDar);
            this.Controls.Add(this.txtTomar);
            this.Controls.Add(this.cmbMetodo1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBuscarItem);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClienteNuevo);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTracking);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDocumento);
            this.Name = "PuntoVenta";
            this.Text = "PuntoVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtTracking;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnClienteNuevo;
        private System.Windows.Forms.Button btnBuscarItem;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button cmbMetodo1;
        private System.Windows.Forms.TextBox txtTomar;
        private System.Windows.Forms.TextBox txtDar;
        private System.Windows.Forms.Button cmbMetodo2;
        private System.Windows.Forms.TextBox txtConsolidado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.Button btnPagarImprimir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCUENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_UNITARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_TOTAL;
        private System.Windows.Forms.DataGridViewButtonColumn REMOVER;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn METODO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewButtonColumn QUITAR;
    }
}