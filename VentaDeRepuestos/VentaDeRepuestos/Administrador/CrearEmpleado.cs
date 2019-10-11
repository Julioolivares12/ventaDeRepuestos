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

namespace VentaDeRepuestos.Administrador
{
    public partial class CrearEmpleado : Form
    {
        char s;
        char est;
        string id_cargo;
        string id_pefil;
        public CrearEmpleado()
        {
            InitializeComponent();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {

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

        }

        private void CbPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CrearEmpleado_Load(object sender, EventArgs e)
        {
            //cargarPerfiles();
            cargarCargos();
        }

        private async void cargarPerfiles()
        {
            var dt = new DataTable();
            using (var reader = await Consultas.getPerfilesAsync())
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    dt.Load(reader);
                    cbPerfil.DataSource = dt;
                    cbPerfil.ValueMember = "ID_PERFIL";
                    cbPerfil.DisplayMember = "NOMBRE";

                }
            }
        }
        private async void cargarCargos()
        {
            cbCargo.DataSource = Consultas.getCargos();
            cbCargo.ValueMember = "ID_CARGO";
            cbCargo.DisplayMember = "NOMBRE";
        }
    }
}
