using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaDeRepuestos.Modelos;

namespace VentaDeRepuestos.Administrador
{
    public partial class CrearModeloDeVehiculo : VentaDeRepuestos.formulariosBase.CrearModeloVehiculo
    {
        private static CrearModeloDeVehiculo crear;
        public static CrearModeloDeVehiculo newInstance()
        {
            if(crear == null)
            {
                crear = new CrearModeloDeVehiculo();
            }
            return crear;
        }
        string ID { get; set; }
        public CrearModeloDeVehiculo()
        {
            InitializeComponent();
        }

        public CrearModeloDeVehiculo(string id)
        {
            InitializeComponent();
            if(!String.IsNullOrEmpty(id) && !String.IsNullOrWhiteSpace(id))
            {

                ID = id;
                btnCrear.Text = "Actualizar";
                var mod = Consultas.getModeloDeVehiculoByID(id);
                txtDescripcion.Text = mod.DESCRIPCION;

            }

        }

        public override bool actualizar()
        {
            base.actualizar();
            var modeloVehiculo = new ModeloVehiculo();
            modeloVehiculo.DESCRIPCION = txtDescripcion.Text;
            var r = Consultas.actualizarModeloVehiculo(modeloVehiculo);
            if(r > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool insertar()
        {
            base.insertar();
            //var query = "INSERT INTO MODELOSVEHICULOS (ID_MODELOVEH,DESCRIPCION) VALUES (@ID_MODELO,@DESCRIPCION)";
            var modeloVehiculo = new ModeloVehiculo();
            modeloVehiculo.ID = Guid.NewGuid().ToString();
            modeloVehiculo.DESCRIPCION = txtDescripcion.Text;
            var r = Consultas.insertarModeloVehiculo(modeloVehiculo);

            if (r > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private  void BtnCrear_Click(object sender, EventArgs e)
        {
            if (ID != null )
            {
                actualizar();
            }
            else
            {
                var isInsertado = insertar();
                if (isInsertado)
                {
                    MessageBox.Show("insertado con exito");
                }
                else
                {
                    MessageBox.Show("ocurrio un error");
                }
            }
           
        }
    }
}
