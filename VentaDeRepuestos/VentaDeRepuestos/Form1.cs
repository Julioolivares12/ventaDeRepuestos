using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaDeRepuestos.Helpers;

namespace VentaDeRepuestos
{
    public partial class Form1 : Form
    {
        public static Form1 form1;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1 getInstance()
        {
            if(form1 == null)
            {
                form1 = new Form1();
            }
            return form1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Image image = Image.FromFile("repuestoslogo.jpg");
            //pbLogo.Image = image;
           // pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PbLogo_Click(object sender, EventArgs e)
        {

        }

        private  void BtnLogin_Click(object sender, EventArgs e)
        {
            var pass = Encriptar.encriptarPassword(txtPassword.Text.Trim());
          
            var login = Consultas.Login(txtCorreo.Text.Trim(),pass);
            if(login != null)
            {
                this.Hide();
                new Menu(login.Perfil).Show();
            }
            else
            {
                MessageBox.Show("error correo o contraseña incorrectos");
            }
        }
    }
}
