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
using VentaDeRepuestos.Modelos;

namespace VentaDeRepuestos.Administrador
{
    public partial class ActualizarEmpleado : CrearEmpleado
    {
        string ID_USUARIO;
        public ActualizarEmpleado()
        {
            InitializeComponent();
        }

        public ActualizarEmpleado(string id)
        {
            InitializeComponent();
            if (id != null)
            {
                ID_USUARIO = id;
            }
        }

        private void ActualizarEmpleado_Load(object sender, EventArgs e)
        {
            carDatos();
            cargarCargos();
            cargarPerfiles();
        }

        public void carDatos()
        {
            var query = "SELECT U.ID_USUARIO U.PRIMERNOMBRE,U.SEGUNDONOMBRE,U.PRIMERAPELLIDO,U.SEGUNDOAPELLIDO,U.DIRECCION,U.TELEFONO" +
                ",U.FECHANAC,U.SEXO,U.ESTADO_CIVIL,U.EMAIL, P.NOMBRE AS PERFIL,C.NOMBRE AS CARGO FROM USUARIOS AS U INNER JOIN PERFIL AS P" +
                " ON U.ID_PERFIL = P.ID_PERFIL INNER JOIN CARGOS AS C ON U.ID_CARGO = C.ID_CARGO WHERE U.ID_USUARIO=@ID_USUARIO";
           // SqlParameter parameter = new SqlParameter("@ID_USUARIO",ID_USUARIO);

            var result = Consultas.getEmpleadoByID(query,ID_USUARIO);
           // var result = Consultas.ExecuteReader(query,CommandType.Text,parameter);
            if (result.Read())
            {
                var usuario = new Usuario();
                usuario.ID = result.GetString(0);
                usuario.PrimerNombre = result.GetString(1);
                usuario.SegundoNombre = result.GetString(2);
                usuario.PrimerApellido = result.GetString(3);
                usuario.SegundoApellido = result.GetString(4);
                usuario.Direccion = result.GetString(5);
                usuario.Telefono = result.GetString(6);
                usuario.FechaNac = result.GetString(7);
                usuario.Sexo = Convert.ToChar(result.GetString(8));
                usuario.EstadoCivil = Convert.ToChar(result.GetString(9));
                usuario.Email = result.GetString(10);
                usuario.ID_PERFIL = result.GetString(11);
                usuario.ID_CARGO = result.GetString(12);

                txtPrimerNombre.Text = usuario.PrimerNombre;
                txtSegundoNombre.Text = usuario.SegundoNombre;
                txtPrimerApellido.Text = usuario.PrimerApellido;
                txtSegundoApellido.Text = usuario.SegundoApellido;
                txtDireccion.Text = usuario.Direccion;
                txtTelefono.Text = usuario.Telefono;
                txtFechaNac.Text = usuario.FechaNac;
                txtSexoActual.Text = usuario.Sexo.ToString();
                txtEstadoActual.Text = usuario.EstadoCivil.ToString();
                txtPerfilActual.Text = usuario.ID_PERFIL;
                txtCargoActual.Text = usuario.ID_CARGO;

            }
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {

        }
    }
}
