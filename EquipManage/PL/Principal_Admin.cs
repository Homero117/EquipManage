using EquipManage.PL.Orden_Interna;
using EquipManage.PL.Recepción_Entrega_de_Equipos_ITEMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipManage.PL
{
    public partial class Principal_Admin : Form
    {
        public Principal_Admin()
        {
            InitializeComponent();
        }

        private void btn_EntregaDeEquipos_Click(object sender, EventArgs e)
        {
            FormReportw formReportw = new FormReportw();

            formReportw.Show();
        }

        private void btn_OrdenInterna_Click(object sender, EventArgs e)
        {
            Orden_Interna_Admin orden_Interna_Admin = new Orden_Interna_Admin();
            orden_Interna_Admin.Show(); 
            this.Close();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
