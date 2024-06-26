using EquipManage.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipManage.PL.Orden_Interna
{
    public partial class Orden_Interna_Ver : Form
    {
        Orden_InternaDAL oOrden_InternaDAL;

        public Orden_Interna_Ver()
        {
            oOrden_InternaDAL = new Orden_InternaDAL();
            LLenarGridIOT(); 
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Orden_Interna_Admin orden_Interna_Admin = new Orden_Interna_Admin();
            orden_Interna_Admin.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Orden_Interna_Ver_Load(object sender, EventArgs e)
        {

        }
        public void LLenarGridIOT()
        {
            dgv_OI_Ver.DataSource = oOrden_InternaDAL.Mostrarodo().Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv_OI_Ver.DataSource = oOrden_InternaDAL.Mostrarodo().Tables[0];
        }
    }
}
