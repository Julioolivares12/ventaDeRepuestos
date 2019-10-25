using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentaDeRepuestos.Helpers
{
    class MostrarMensaje
    {
        public static void mostarMensaje(bool a,string m)
        {
            if (a)
                MessageBox.Show(m);
            else
                MessageBox.Show("ocurrio un error!");
        }
    }
}
