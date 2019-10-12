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
using VentaDeRepuestos.Modelos;

namespace VentaDeRepuestos.Administrador
{
    public partial class CrearEmpleado2 : Form
    {
        char s;
        char est;
        private string id_cargo;
        private string id_pefil;

        public string Id_cargo { get => id_cargo; set => id_cargo = value; }
        public string Id_pefil { get => id_pefil; set => id_pefil = value; }

        public CrearEmpleado2()
        {
            InitializeComponent();
        }

        private async void BtnCrear_Click(object sender, EventArgs e)
        {
            var pNombre = txtPrimerNombre.Text.Trim();
            var sNombre = txtSegundoNombre.Text.Trim();
            var pApellido = txtPrimerApellido.Text.Trim();
            var sApellido = txtSegundoApellido.Text.Trim();
            var direccion = txtDireccion.Text;
            var telefono = txtTelefono.Text.Trim();
            var fechaNac = txtFechaNac.Text.Trim();
            var correo = txtEmail.Text.Trim();


            var user = new Usuario();
            user.ID_CARGO = id_cargo;
            user.ID_PERFIL = Id_pefil;
            user.PrimerNombre = pNombre;
            user.SegundoNombre = sNombre;
            user.PrimerApellido = pApellido;
            user.SegundoApellido = sApellido;
            user.Direccion = direccion;
            user.Telefono = telefono;
            user.FechaNac = fechaNac;
            user.Email = correo;
            var r = await Consultas.crearEpleadoAsync(user); 
            if(r > 0)
            {
                MessageBox.Show("agregado con exito");
                this.Close();
            }
            else
            {
                MessageBox.Show("ocurrio un error");
            }
        }

        private void CbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = cbSexo.SelectedIndex;
            s = Convert.ToChar(cbSexo.Items[i].ToString());
        }

        private void CbEstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = cbEstadoCivil.SelectedIndex;
            est = Convert.ToChar(cbEstadoCivil.Items[i].ToString());
        }

        private void CbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            

             Id_cargo = cbCargo.SelectedValue.ToString();

        }

        private void CbPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            Id_pefil = cbPerfil.SelectedValue.ToString();
        }

        private void CrearEmpleado_Load(object sender, EventArgs e)
        {
            cargarPerfiles();
            cargarCargos();
        }

        public virtual  void cargarPerfiles()
        {
            
            cbPerfil.ValueMember = "ID_PERFIL";
            cbPerfil.DisplayMember = "NOMBRE";
            cbPerfil.DataSource = Consultas.getPerfiles();

        }
        public virtual void cargarCargos()
        {
            
            cbCargo.ValueMember = "ID_CARGO";
            cbCargo.DisplayMember = "NOMBRE";
            cbCargo.DataSource = Consultas.getCargos();
        }
    }
}
