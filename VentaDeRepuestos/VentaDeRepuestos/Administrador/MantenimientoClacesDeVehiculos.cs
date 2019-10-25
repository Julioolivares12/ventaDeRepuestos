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

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var i = getID();
            var rs = Consultas.EliminarClaseVehiculo(i);
            MostrarMensaje.mostarMensaje(rs,"eliminado con exito");
        }

        private void MantenimientoClacesDeVehiculos_Load(object sender, EventArgs e)
        {

        }
    }
}
