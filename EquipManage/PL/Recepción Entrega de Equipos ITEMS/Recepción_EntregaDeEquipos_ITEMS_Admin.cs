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
    public partial class Recepción_EntregaDeEquipos_ITEMS_Admin : Form
    {
        public Recepción_EntregaDeEquipos_ITEMS_Admin()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Principal_Admin principal_Admin = new Principal_Admin();
            principal_Admin.Show();
            this.Close();
        }
    }
}
