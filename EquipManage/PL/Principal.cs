using EquipManage.Elementos.Recepción_Entrega_de_Equipos_ITEMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipManage.Elementos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btn_EntregaDeEquipos_Click(object sender, EventArgs e)
        {
            Recepción_EntregaDeEquipos_ITEMS_Anadir recepción_EntregaDeEquipos_ITEMS = new Recepción_EntregaDeEquipos_ITEMS_Anadir();
            recepción_EntregaDeEquipos_ITEMS.Show();
            this.Close();

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_OrdenInterna_Click(object sender, EventArgs e)
        {
            Orden_Interna_Anadir orden_Interna = new Orden_Interna_Anadir();
            orden_Interna.Show();
            this.Close();
        }

        private void lbl_MensagePrincipal_Click(object sender, EventArgs e)
        {

        }
    }
}
