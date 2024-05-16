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

            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Principal_Ver principal_Ver = new Principal_Ver();
            principal_Ver.Show();
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
            dgv_OI_Ver.DataSource = oOrden_InternaDAL.MostrarOI_Todo().Tables[0];
        }
    }
}
