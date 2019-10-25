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
            var crear = new CrearTipoVehiculo();
            crear.ShowDialog();
            cargarDatos();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var id = getID();
            var objt = new CrearTipoVehiculo(id);
            objt.ShowDialog();
            cargarDatos();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var id = getID();
            var r = Consultas.EliminarTipoVehiculo(id);
            if (r)
            {
                MessageBox.Show("eliminado con exito");
                cargarDatos();
            }
            else
            {
                MessageBox.Show("no se pudo eliminar");
            }
        }

        private void MantenimientoTiposVehiculos_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        public override void cargarDatos()
        {
            base.cargarDatos();
            gridDatos.DataSource = Consultas.GetTipoVehiculos();
        }
    }
}
