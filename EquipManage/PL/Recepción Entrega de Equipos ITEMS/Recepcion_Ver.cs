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
        public Recepcion_Ver()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Principal_Ver principal_Ver = new Principal_Ver();
            principal_Ver.Show();
            this.Close();
        }
    }
}
