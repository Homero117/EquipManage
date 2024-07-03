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
    public partial class FormReportw : Form
    {
        public FormReportw()
        {
            InitializeComponent();
        }

        private void FormReportw_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pROYECTO_INTEGRADOR_5DataSet2.Equipo' Puede moverla o quitarla según sea necesario.
            this.equipoTableAdapter.Fill(this.pROYECTO_INTEGRADOR_5DataSet2.Equipo);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
