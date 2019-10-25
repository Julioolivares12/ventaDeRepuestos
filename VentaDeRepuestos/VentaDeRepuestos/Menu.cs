using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaDeRepuestos.Administrador;

namespace VentaDeRepuestos
{
    public partial class Menu : Form
    {
        private int childFormNumber = 0;
        MantenimientoEmpleado empleados;
        PuntoVenta punto;

        public Menu()
        {
            InitializeComponent();
        }
        public Menu(string perfil)
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void EmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if(empleados == null)
            {
                empleados = new MantenimientoEmpleado();
                empleados.MdiParent = this;
                empleados.FormClosed += new FormClosedEventHandler(cerrarEmpleados);
                empleados.Show();
            }
            else
            {
                empleados.Activate();
            }
        }

        private void cerrarEmpleados(object sender, FormClosedEventArgs e)
        {
            empleados = null;
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void puntoDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            punto = new PuntoVenta();
            punto.MdiParent = this;
            punto.Show();
            punto.Activate();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
