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
    public partial class CrearModeloVehiculo : Form
    {
        public CrearModeloVehiculo()
        {
            InitializeComponent();
        }
        public virtual bool insertar()
        {
            return false;
        }

        public virtual bool actualizar()
        {
            return false;
        }

        public virtual void cargarDatos()
        {

        }
    }
}
