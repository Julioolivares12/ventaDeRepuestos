using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VentaDeRepuestos.Helpers;

namespace VentaDeRepuestos.Administrador
{
    public partial class MantenimientoPartesDeVehiculos : VentaDeRepuestos.formulariosBase.Mantenimientos
    {
        public MantenimientoPartesDeVehiculos()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            var crear = new CrearParteDeVehiculo();
            crear.ShowDialog();
            cargarDatos();

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var id = getID();
            var ac = new CrearParteDeVehiculo(id);
            ac.ShowDialog();
            cargarDatos();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var i = getID();
            var rs = Consultas.EliminarParteVehiculo(i);
            MostrarMensaje.mostarMensaje(rs,"eliminado con exito");
        }

        private void MantenimientoPartesDeVehiculos_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        public override void cargarDatos()
        {
            base.cargarDatos();
            gridDatos.DataSource = Consultas.GetParteVehiculos();
        }
    }
}
