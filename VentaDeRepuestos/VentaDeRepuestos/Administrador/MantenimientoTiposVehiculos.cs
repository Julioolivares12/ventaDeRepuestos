using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VentaDeRepuestos.Administrador
{
    public partial class MantenimientoTiposVehiculos : VentaDeRepuestos.formulariosBase.Mantenimientos
    {
        public MantenimientoTiposVehiculos()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void MantenimientoTiposVehiculos_Load(object sender, EventArgs e)
        {
            gridDatos.DataSource = Consultas.GetTipoVehiculos();
        }
    }
}
