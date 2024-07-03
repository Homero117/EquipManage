using EquipManage.Elementos;
using EquipManage.PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipManage
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            string Usuario = txt_Usuario.Text;
            string Contrasenia = txt_Contrasena.Text;
            
            if (Usuario == "Admin" && Contrasenia == "123")
            {
                Principal_Admin principal_Admin = new Principal_Admin();
                principal_Admin.Show();

                txt_Usuario.Text = "";
                txt_Contrasena.Text = "";

            }
            else
            {
                MessageBox.Show("⚠️ Nombre de usuario o contraseña incorrectos. Por favor, inténtelo de nuevo. ⚠️");
            }
        }

        private void btn_CerrarElPrograma_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void txt_Contrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
