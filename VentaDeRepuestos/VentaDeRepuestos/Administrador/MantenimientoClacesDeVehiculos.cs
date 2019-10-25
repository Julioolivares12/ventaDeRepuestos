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
    public partial class MantenimientoClacesDeVehiculos : VentaDeRepuestos.formulariosBase.Mantenimientos
    {
        public MantenimientoClacesDeVehiculos()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            var Crear = new CrearClaseDeVehiculo();
            Crear.ShowDialog();
            cargarDatos();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var i = getID();
            var cr = new CrearClaseDeVehiculo(i);
            cr.ShowDialog();
            cargarDatos();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var i = getID();
            var rs = Consultas.EliminarClaseVehiculo(i);
            MostrarMensaje.mostarMensaje(rs,"eliminado con exito");
            cargarDatos();
        }

        private void MantenimientoClacesDeVehiculos_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        public override void cargarDatos()
        {
            base.cargarDatos();
            gridDatos.DataSource = Consultas.getClasesDeVehiculos();
        }
    }
}
