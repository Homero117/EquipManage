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
        public Orden_Interna_Ver()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Principal_Ver principal_Ver = new Principal_Ver();
            principal_Ver.Show();
            this.Close();
        }
    }
}
