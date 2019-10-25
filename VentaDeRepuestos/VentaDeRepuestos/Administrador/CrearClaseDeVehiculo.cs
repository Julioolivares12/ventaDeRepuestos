using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VentaDeRepuestos.Helpers;
using VentaDeRepuestos.Modelos;

namespace VentaDeRepuestos.Administrador
{
    public partial class CrearClaseDeVehiculo : VentaDeRepuestos.Administrador.CrearTipoVehiculo
    {
        public CrearClaseDeVehiculo()
        {
            InitializeComponent();
        }

        public CrearClaseDeVehiculo(string id)
        {
            if (!String.IsNullOrEmpty(id) && !String.IsNullOrWhiteSpace(id))
            {
                ID = id;
                btnCrear.Text = "Actualizar";
                var mod = Consultas.GetClaseDeVehiculo(id);
                txtDescripcion.Text = mod.Descripcion;
            }
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            if(ID!= null)
            {
                var mod = new ClaseDeVehiculo();
                mod.ID = ID;
                mod.Descripcion = txtDescripcion.Text;
                var rs = Consultas.ActualizarClaseVehiculo(mod);
                MostrarMensaje.mostarMensaje(rs,"actualizado con exito");
            }
            else
            {
                var mod = new ClaseDeVehiculo();
                mod.ID = Guid.NewGuid().ToString();
                mod.Descripcion = txtDescripcion.Text;
                var rs = Consultas.InsertarClaseVehiculo(mod);
                MostrarMensaje.mostarMensaje(rs,"creado con exito");
            }
        }
    }
}
