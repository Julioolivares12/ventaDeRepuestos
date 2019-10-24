using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaDeRepuestos.formulariosBase;

namespace VentaDeRepuestos.Administrador
{
    public partial class MantenimientoEmpleado : Mantenimientos
    {
        public MantenimientoEmpleado()
        {
            InitializeComponent();
        }

        private void MantenimientoEmpleado_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            var nuevoEmpleado = new CrearUsuario();
            nuevoEmpleado.ShowDialog();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var id = getID();
            ActualizarEmpleado actualizarEmpleado = new ActualizarEmpleado(id);
            actualizarEmpleado.ShowDialog();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var idActual = getID();
            if(idActual != null)
            {
                var query = "DELETE * FROM USUARIOS WHERE ID_USUARIO = @ID_USUARIO";
                var con =  Conexion.conectar();
                SqlParameter parameter = new SqlParameter("@ID_USUARIO",idActual); 
                var result = Consultas.ExecuteNonQuery(con,query,CommandType.Text,parameter);
                if(result > 0)
                {
                    MessageBox.Show("eliminado con exito");
                    cargarDatos();
                }
            }
            else
            {
                MessageBox.Show("selecciona una fila para poder eliminar");
            }
        }

        public override void cargarDatos()
        {
            base.cargarDatos();
            var datos = Consultas.getEmpleados();
            gridDatos.DataSource = datos;
        }
    }
}
