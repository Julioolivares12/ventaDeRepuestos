using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VentaDeRepuestos.Modelos;

namespace VentaDeRepuestos.Administrador
{
    public partial class CrearTipoVehiculo : VentaDeRepuestos.formulariosBase.CrearModeloVehiculo
    {
        
        public CrearTipoVehiculo()
        {
            InitializeComponent();
        }
        public CrearTipoVehiculo(string id)
        {
            if(!String.IsNullOrEmpty(id) && !String.IsNullOrWhiteSpace(id))
            {
                ID = id;
                var mod = Consultas.GetTipoVehiculoByID(id);
                txtDescripcion.Text = mod.Descripcion;
                btnCrear.Text = "Actualizar";
            }
        }
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            if (ID!= null)
            {
                var mod = new TipoVehiculo();
                mod.ID = ID;
                mod.Descripcion = txtDescripcion.Text;
                var r = Consultas.ActualizarTipoVehiculo(mod);
                if (r)
                {
                    MessageBox.Show("Actualizado");
                }
                else
                {
                    MessageBox.Show("Ocurrio un error");
                }
            }
            else
            {
                var mod = new TipoVehiculo();
                mod.ID = Guid.NewGuid().ToString();
                mod.Descripcion = txtDescripcion.Text;
                var r = Consultas.InsertarTipoVehiculo(mod);

                if (r)
                {
                    MessageBox.Show("creado con exito");
                }
                else
                {
                    MessageBox.Show("ocurrio un error");
                }
            }
        }
    }
}
