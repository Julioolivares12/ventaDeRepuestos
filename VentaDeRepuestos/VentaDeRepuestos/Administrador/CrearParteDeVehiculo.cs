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
    public partial class CrearParteDeVehiculo : VentaDeRepuestos.Administrador.CrearTipoVehiculo
    {
        public CrearParteDeVehiculo()
        {
            InitializeComponent();
        }

        public CrearParteDeVehiculo(string id)
        {
            if(!String.IsNullOrEmpty(id) && !String.IsNullOrWhiteSpace(id))
            {
                ID = id;
                btnCrear.Text = "Actualizar";
                var mod = Consultas.GetParteVehiculo(id);
                txtDescripcion.Text = mod.Descripcion;
            }
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            if(ID != null)
            {
               
                var mod = new ParteVehiculo();
                mod.ID = ID;
                mod.Descripcion = txtDescripcion.Text;
                var rs = Consultas.ActualizarParteVehiculo(mod);
                MostrarMensaje.mostarMensaje(rs,Constantes.MENSAJEDEACTUALIZACION);
            }
            else
            {
                var mod = new ParteVehiculo();
                mod.ID = Guid.NewGuid().ToString();
                mod.Descripcion = txtDescripcion.Text;
                var rs = Consultas.InsertarParteVehiculo(mod);
                MostrarMensaje.mostarMensaje(rs,Constantes.MENSAJEDEEXITO);
            }
        }
    }
}
