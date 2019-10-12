using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentaDeRepuestos.formulariosBase
{
    public partial class CrearEmpleado : Form
    {
        public char s;
        public char est;
        private string id_cargo;
        private string id_pefil;

        public string Id_cargo { get => id_cargo; set => id_cargo = value; }
        public string Id_pefil { get => id_pefil; set => id_pefil = value; }
        public CrearEmpleado()
        {
            InitializeComponent();
        }

        public virtual void cargarPerfiles()
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
