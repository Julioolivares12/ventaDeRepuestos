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
    public partial class Mantenimientos : Form
    {
        public Mantenimientos()
        {
            InitializeComponent();
        }

        public virtual void cargarDatos()
        {

        }
        public virtual bool insertar()
        {
            return false;
        }
        public virtual bool actualizar()
        {
            return false;
        }
        public virtual bool eliminar()
        {
            return false;
        }

        public virtual string getID()
        {
            try
            {
                return gridDatos.Rows[gridDatos.CurrentRow.Index].Cells[0].Value.ToString();
            }
            catch
            {
                return null;
            }
        }
    }
}
