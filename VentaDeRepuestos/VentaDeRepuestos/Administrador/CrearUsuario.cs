using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaDeRepuestos.formulariosBase;
using VentaDeRepuestos.Modelos;

namespace VentaDeRepuestos.Administrador
{
    public partial class CrearUsuario : CrearEmpleado
    {
        
        public CrearUsuario()
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
            user.ID_CARGO = Id_cargo;
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
            if (r > 0)
            {
                MessageBox.Show("agregado con exito");
                this.Close();
            }
            else
            {
                MessageBox.Show("ocurrio un error");
            }
        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {
            cargarCargos();
            cargarPerfiles();
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

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Id_cargo = cbCargo.SelectedValue.ToString();
        }

        private void CbPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            Id_pefil = cbPerfil.SelectedValue.ToString();
        }
    }
}
