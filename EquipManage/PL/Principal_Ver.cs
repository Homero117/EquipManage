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
    public partial class Principal_Ver : Form
    {
        public Principal_Ver()
        {
            InitializeComponent();
        }

        private void lbl_MensagePrincipal_Click(object sender, EventArgs e)
        {

        }

        private void btn_EntregaDeEquipos_Click(object sender, EventArgs e)
        {
            Recepcion_Ver recepcion_Ver = new Recepcion_Ver();
            recepcion_Ver.Show();
            this.Close();
        }

        private void btn_OrdenInterna_Click(object sender, EventArgs e)
        {
            Orden_Interna_Ver orden_Interna_Ver = new Orden_Interna_Ver();
            orden_Interna_Ver.Show();
            this.Close();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
