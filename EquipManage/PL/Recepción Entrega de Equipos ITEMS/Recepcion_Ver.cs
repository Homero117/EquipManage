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

namespace EquipManage.PL.Recepción_Entrega_de_Equipos_ITEMS
{
    public partial class Recepcion_Ver : Form
    {
        RecepcionDAL oRecepcionDAL;
        public Recepcion_Ver()
        {
            oRecepcionDAL = new RecepcionDAL();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

        }

        private void Recepcion_Ver_Load(object sender, EventArgs e)
        {

        }

        public void LLenarGridR()
        {
            dgv_R.DataSource = oRecepcionDAL.MostrarR().Tables[0];

        }
    }
}
