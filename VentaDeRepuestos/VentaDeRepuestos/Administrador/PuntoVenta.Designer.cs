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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDocumento = new System.Windows.Forms.ComboBox();
            this.tIPODOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repuestosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repuestosDataSet = new VentaDeRepuestos.repuestosDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtTracking = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarItem = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTomar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbMetodo1 = new System.Windows.Forms.ComboBox();
            this.mETODOSTOMARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnTomar = new System.Windows.Forms.Button();
            this.btnDar = new System.Windows.Forms.Button();
            this.cmbMetodo2 = new System.Windows.Forms.ComboBox();
            this.mETODOSDARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtConsolidado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnPagarImprimir = new System.Windows.Forms.Button();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.btnClienteNuevo = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.mETODOSDARTableAdapter = new VentaDeRepuestos.repuestosDataSetTableAdapters.METODOSDARTableAdapter();
            this.mETODOSDARBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mETODOSTOMARTableAdapter = new VentaDeRepuestos.repuestosDataSetTableAdapters.METODOSTOMARTableAdapter();
            this.mETODOSTOMARBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tIPODOCTableAdapter = new VentaDeRepuestos.repuestosDataSetTableAdapters.TIPODOCTableAdapter();
            this.UPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCUENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIOTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REMOVER = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tIPODOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repuestosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repuestosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mETODOSTOMARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mETODOSDARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mETODOSDARBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mETODOSTOMARBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOCUMENTO";
            // 
            // cmbDocumento
            // 
            this.cmbDocumento.DataSource = this.tIPODOCBindingSource;
            this.cmbDocumento.DisplayMember = "DESCRIPCION";
            this.cmbDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocumento.FormattingEnabled = true;
            this.cmbDocumento.Location = new System.Drawing.Point(111, 27);
            this.cmbDocumento.Name = "cmbDocumento";
            this.cmbDocumento.Size = new System.Drawing.Size(121, 21);
            this.cmbDocumento.TabIndex = 1;
            // 
            // tIPODOCBindingSource
            // 
            this.tIPODOCBindingSource.DataMember = "TIPODOC";
            this.tIPODOCBindingSource.DataSource = this.repuestosDataSetBindingSource;
            // 
            // repuestosDataSetBindingSource
            // 
            this.repuestosDataSetBindingSource.DataSource = this.repuestosDataSet;
            this.repuestosDataSetBindingSource.Position = 0;
            // 
            // repuestosDataSet
            // 
            this.repuestosDataSet.DataSetName = "repuestosDataSet";
            this.repuestosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CLIENTE";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(111, 62);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(121, 20);
            this.txtCliente.TabIndex = 3;
            // 
            // txtTracking
            // 
            this.txtTracking.Location = new System.Drawing.Point(345, 27);
            this.txtTracking.Name = "txtTracking";
            this.txtTracking.Size = new System.Drawing.Size(121, 20);
            this.txtTracking.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "TRACKING N°";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(605, 27);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(121, 20);
            this.txtFecha.TabIndex = 7;
            this.txtFecha.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "FECHA VENTA";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnBuscarItem
            // 
            this.btnBuscarItem.Image = global::VentaDeRepuestos.Properties.Resources.lupa1;
            this.btnBuscarItem.Location = new System.Drawing.Point(369, 105);
            this.btnBuscarItem.Name = "btnBuscarItem";
            this.btnBuscarItem.Size = new System.Drawing.Size(42, 38);
            this.btnBuscarItem.TabIndex = 12;
            this.btnBuscarItem.UseVisualStyleBackColor = true;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(131, 117);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(232, 20);
            this.txtItem.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "BUSCAR REPUESTO";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(605, 115);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(121, 20);
            this.txtDescuento.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(480, 120);
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
            this.PRECIO,
            this.PRECIOTOTAL,
            this.REMOVER});
            this.dgvItems.Location = new System.Drawing.Point(15, 154);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(752, 150);
            this.dgvItems.TabIndex = 15;
            this.dgvItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellContentClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 318);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(484, 96);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Enabled = false;
            this.txtMontoTotal.Location = new System.Drawing.Point(646, 379);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(121, 20);
            this.txtMontoTotal.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(521, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "MONTO TOTAL: $";
            // 
            // txtIva
            // 
            this.txtIva.Enabled = false;
            this.txtIva.Location = new System.Drawing.Point(646, 318);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(121, 20);
            this.txtIva.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(582, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "IVA: $";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(646, 349);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(121, 20);
            this.txtSubtotal.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(542, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "SUBTOTAL: $";
            // 
            // txtTomar
            // 
            this.txtTomar.Location = new System.Drawing.Point(81, 432);
            this.txtTomar.Name = "txtTomar";
            this.txtTomar.Size = new System.Drawing.Size(121, 20);
            this.txtTomar.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "TOMAR";
            // 
            // cmbMetodo1
            // 
            this.cmbMetodo1.DataSource = this.mETODOSTOMARBindingSource;
            this.cmbMetodo1.DisplayMember = "METODO";
            this.cmbMetodo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodo1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmbMetodo1.Location = new System.Drawing.Point(208, 432);
            this.cmbMetodo1.Name = "cmbMetodo1";
            this.cmbMetodo1.Size = new System.Drawing.Size(121, 21);
            this.cmbMetodo1.TabIndex = 25;
            // 
            // mETODOSTOMARBindingSource
            // 
            this.mETODOSTOMARBindingSource.DataMember = "METODOSTOMAR";
            this.mETODOSTOMARBindingSource.DataSource = this.repuestosDataSetBindingSource;
            // 
            // btnTomar
            // 
            this.btnTomar.Location = new System.Drawing.Point(339, 430);
            this.btnTomar.Name = "btnTomar";
            this.btnTomar.Size = new System.Drawing.Size(97, 23);
            this.btnTomar.TabIndex = 26;
            this.btnTomar.Text = "TOMAR PAGO";
            this.btnTomar.UseVisualStyleBackColor = true;
            // 
            // btnDar
            // 
            this.btnDar.Enabled = false;
            this.btnDar.Location = new System.Drawing.Point(339, 459);
            this.btnDar.Name = "btnDar";
            this.btnDar.Size = new System.Drawing.Size(97, 23);
            this.btnDar.TabIndex = 30;
            this.btnDar.Text = "DAR VUELTO";
            this.btnDar.UseVisualStyleBackColor = true;
            // 
            // cmbMetodo2
            // 
            this.cmbMetodo2.DataSource = this.mETODOSDARBindingSource;
            this.cmbMetodo2.DisplayMember = "METODO";
            this.cmbMetodo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodo2.FormattingEnabled = true;
            this.cmbMetodo2.Location = new System.Drawing.Point(208, 461);
            this.cmbMetodo2.Name = "cmbMetodo2";
            this.cmbMetodo2.Size = new System.Drawing.Size(121, 21);
            this.cmbMetodo2.TabIndex = 29;
            // 
            // mETODOSDARBindingSource
            // 
            this.mETODOSDARBindingSource.DataMember = "METODOSDAR";
            this.mETODOSDARBindingSource.DataSource = this.repuestosDataSetBindingSource;
            // 
            // txtDar
            // 
            this.txtDar.Location = new System.Drawing.Point(81, 461);
            this.txtDar.Name = "txtDar";
            this.txtDar.Size = new System.Drawing.Size(121, 20);
            this.txtDar.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 464);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "DAR";
            // 
            // txtConsolidado
            // 
            this.txtConsolidado.Enabled = false;
            this.txtConsolidado.Location = new System.Drawing.Point(646, 435);
            this.txtConsolidado.Name = "txtConsolidado";
            this.txtConsolidado.Size = new System.Drawing.Size(121, 20);
            this.txtConsolidado.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(533, 439);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "CONSOLIDADO";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(680, 532);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(97, 23);
            this.btnLimpiar.TabIndex = 33;
            this.btnLimpiar.Text = "LIMPIAR TODO";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            this.btnPagar.Enabled = false;
            this.btnPagar.Location = new System.Drawing.Point(577, 532);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(97, 23);
            this.btnPagar.TabIndex = 34;
            this.btnPagar.Text = "SOLO PAGAR";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // btnPagarImprimir
            // 
            this.btnPagarImprimir.Enabled = false;
            this.btnPagarImprimir.Location = new System.Drawing.Point(450, 532);
            this.btnPagarImprimir.Name = "btnPagarImprimir";
            this.btnPagarImprimir.Size = new System.Drawing.Size(121, 23);
            this.btnPagarImprimir.TabIndex = 35;
            this.btnPagarImprimir.Text = "PAGAR E IMPRIMIR";
            this.btnPagarImprimir.UseVisualStyleBackColor = true;
            // 
            // dgvPagos
            // 
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Location = new System.Drawing.Point(15, 502);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.Size = new System.Drawing.Size(429, 88);
            this.dgvPagos.TabIndex = 36;
            // 
            // btnClienteNuevo
            // 
            this.btnClienteNuevo.BackgroundImage = global::VentaDeRepuestos.Properties.Resources.plus;
            this.btnClienteNuevo.Location = new System.Drawing.Point(290, 64);
            this.btnClienteNuevo.Name = "btnClienteNuevo";
            this.btnClienteNuevo.Size = new System.Drawing.Size(30, 30);
            this.btnClienteNuevo.TabIndex = 9;
            this.btnClienteNuevo.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackgroundImage = global::VentaDeRepuestos.Properties.Resources.lupa1;
            this.btnBuscarCliente.Location = new System.Drawing.Point(250, 62);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(34, 32);
            this.btnBuscarCliente.TabIndex = 8;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // mETODOSDARTableAdapter
            // 
            this.mETODOSDARTableAdapter.ClearBeforeFill = true;
            // 
            // mETODOSDARBindingSource1
            // 
            this.mETODOSDARBindingSource1.DataMember = "METODOSDAR";
            this.mETODOSDARBindingSource1.DataSource = this.repuestosDataSetBindingSource;
            // 
            // mETODOSTOMARTableAdapter
            // 
            this.mETODOSTOMARTableAdapter.ClearBeforeFill = true;
            // 
            // mETODOSTOMARBindingSource1
            // 
            this.mETODOSTOMARBindingSource1.DataMember = "METODOSTOMAR";
            this.mETODOSTOMARBindingSource1.DataSource = this.repuestosDataSetBindingSource;
            // 
            // tIPODOCTableAdapter
            // 
            this.tIPODOCTableAdapter.ClearBeforeFill = true;
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
            // PRECIO
            // 
            this.PRECIO.Frozen = true;
            this.PRECIO.HeaderText = "PRECIO U";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            // 
            // PRECIOTOTAL
            // 
            this.PRECIOTOTAL.Frozen = true;
            this.PRECIOTOTAL.HeaderText = "PRECIO TOTAL";
            this.PRECIOTOTAL.Name = "PRECIOTOTAL";
            this.PRECIOTOTAL.ReadOnly = true;
            // 
            // REMOVER
            // 
            this.REMOVER.Frozen = true;
            this.REMOVER.HeaderText = "REMOVER";
            this.REMOVER.Name = "REMOVER";
            this.REMOVER.Text = "REMOVER";
            // 
            // PuntoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.dgvPagos);
            this.Controls.Add(this.btnPagarImprimir);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtConsolidado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnDar);
            this.Controls.Add(this.cmbMetodo2);
            this.Controls.Add(this.txtDar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnTomar);
            this.Controls.Add(this.cmbMetodo1);
            this.Controls.Add(this.txtTomar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.label8);
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
            this.Controls.Add(this.cmbDocumento);
            this.Controls.Add(this.label1);
            this.Name = "PuntoVenta";
            this.Text = "PuntoVenta";
            this.Load += new System.EventHandler(this.PuntoVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tIPODOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repuestosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repuestosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mETODOSTOMARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mETODOSDARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mETODOSDARBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mETODOSTOMARBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDocumento;
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
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTomar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnTomar;
        private System.Windows.Forms.Button btnDar;
        private System.Windows.Forms.ComboBox cmbMetodo2;
        private System.Windows.Forms.TextBox txtDar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtConsolidado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnPagarImprimir;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.BindingSource repuestosDataSetBindingSource;
        private repuestosDataSet repuestosDataSet;
        private System.Windows.Forms.BindingSource mETODOSDARBindingSource;
        private repuestosDataSetTableAdapters.METODOSDARTableAdapter mETODOSDARTableAdapter;
        private System.Windows.Forms.BindingSource mETODOSDARBindingSource1;
        private System.Windows.Forms.BindingSource mETODOSTOMARBindingSource;
        private repuestosDataSetTableAdapters.METODOSTOMARTableAdapter mETODOSTOMARTableAdapter;
        private System.Windows.Forms.BindingSource mETODOSTOMARBindingSource1;
        private System.Windows.Forms.BindingSource tIPODOCBindingSource;
        private repuestosDataSetTableAdapters.TIPODOCTableAdapter tIPODOCTableAdapter;
        public System.Windows.Forms.ComboBox cmbMetodo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCUENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIOTOTAL;
        private System.Windows.Forms.DataGridViewButtonColumn REMOVER;
    }
}