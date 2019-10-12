using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentaDeRepuestos.Administrador
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            CrearUsuario crearEmpleado = new CrearUsuario();
            crearEmpleado.Show();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = Consultas.getEmpleados();
        }
    }
}
