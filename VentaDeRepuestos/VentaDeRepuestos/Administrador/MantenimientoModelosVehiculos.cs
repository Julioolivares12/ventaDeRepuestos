using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VentaDeRepuestos.Administrador
{
    public partial class MantenimientoModelosVehiculos : VentaDeRepuestos.formulariosBase.Mantenimientos
    {
        public MantenimientoModelosVehiculos()
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

        private void MantenimientoModelosVehiculos_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        public override void cargarDatos()
        {
            base.cargarDatos();
            gridDatos.DataSource = Consultas.getModelosVehiculos();
        }
    }
}
