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
            var crear = CrearModeloDeVehiculo.newInstance();
            crear.ShowDialog();
            cargarDatos();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var id = getID();
            var crear =new CrearModeloDeVehiculo(id);

            crear.ShowDialog();
            cargarDatos();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var i = getID();
            var r = Consultas.eliminarModeloVehiculo(i);
            if(r)
            {
                MessageBox.Show("elininado con exito");
                cargarDatos();
            }
            else
            {
                MessageBox.Show("fallo al eliminar");
            }
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
