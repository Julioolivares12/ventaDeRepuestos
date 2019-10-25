using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentaDeRepuestos.Administrador
{
    public partial class PuntoVenta : Form
    {
        public PuntoVenta()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PuntoVenta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'repuestosDataSet.TIPODOC' table. You can move, or remove it, as needed.
            this.tIPODOCTableAdapter.Fill(this.repuestosDataSet.TIPODOC);
            // TODO: This line of code loads data into the 'repuestosDataSet.METODOSTOMAR' table. You can move, or remove it, as needed.
            this.mETODOSTOMARTableAdapter.Fill(this.repuestosDataSet.METODOSTOMAR);
            // TODO: This line of code loads data into the 'repuestosDataSet.METODOSDAR' table. You can move, or remove it, as needed.
            this.mETODOSDARTableAdapter.Fill(this.repuestosDataSet.METODOSDAR);
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtConsolidado.Text = "0.00";

        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
