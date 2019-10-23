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
        public CrearModeloDeVehiculo()
        {
            InitializeComponent();
        }

        public override bool insertar()
        {
            base.insertar();
            var query = "INSERT INTO MODELOSVEHICULOS (ID_MODELOVEH,DESCRIPCION) VALUES (@ID_MODELO,@DESCRIPCION)";
            var modeloVehiculo = new ClaseDeVehiculo();

            

            using (var cn = Conexion.conectar())
            {
                var r =  Consultas.ExecuteNonQuery(cn, query, CommandType.Text);
                if (r > 0)
                {
                    return true;
                }
                else return false;
            }
        }

        private  void BtnCrear_Click(object sender, EventArgs e)
        {
            var isInsertado = insertar();
            if (isInsertado)
            {
                MessageBox.Show("insertado con exito");
            }else
            {
                MessageBox.Show("ocurrio un error");
            }
        }
    }
}
