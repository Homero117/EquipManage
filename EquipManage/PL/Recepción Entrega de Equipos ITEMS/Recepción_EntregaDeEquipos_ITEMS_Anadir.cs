using EquipManage.BLL;
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

namespace EquipManage.Elementos.Recepción_Entrega_de_Equipos_ITEMS
{
    public partial class Recepción_EntregaDeEquipos_ITEMS_Anadir : Form
    {

        RecepcionDAL oRecepcionDAL;

        public Recepción_EntregaDeEquipos_ITEMS_Anadir()
        {
            oRecepcionDAL = new RecepcionDAL();
            InitializeComponent();
        }

        private void txt_Tel_Cel_R_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Recepción_EntregaDeEquipos_ITEMS_Anadir_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
      

            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private RecepcionBLL RecolectarDatos()
        {
            RecepcionBLL objRecepcionBLL = new RecepcionBLL();
            int No = 1;
            int.TryParse(txt_NoR.Text, out No);
            objRecepcionBLL.NoR = No;

            objRecepcionBLL.Empresa = txt_EmpresaR.Text;
            objRecepcionBLL.Tel_Cel = txt_Tel_Cel_R.Text;
            objRecepcionBLL.fecha = txt_Fecha_R.Text;
            objRecepcionBLL.contacto = txt_Contacto.Text;
            objRecepcionBLL.correo = txt_Correo.Text;
            objRecepcionBLL.servicio = txt_Servicio.Text;
            objRecepcionBLL.NoIngreso = txt_Numero_Ingreso.Text;
            objRecepcionBLL.Certificado = txt_Certificado_Informe.Text;
            objRecepcionBLL.TipoServicio = txt_Tipo_Servicio.Text;
            objRecepcionBLL.Equipo_ITEM = txt_Equipo.Text;
            objRecepcionBLL.Marca = txt_MarcaR.Text;
            objRecepcionBLL.Modelo = txt_ModeloR.Text;
            objRecepcionBLL.NoSerie = txt_No_Serie.Text;
            objRecepcionBLL.ID_Cliente = txt_IDCliente.Text;
            objRecepcionBLL.NoParte = txt_No_Partes.Text;
            objRecepcionBLL.Accesorios = txt_Accesorios.Text;
            objRecepcionBLL.ObservacionR = txt_Observaciones.Text;
            objRecepcionBLL.Observaciones_GeneralesR = txt_MensageObservacionesGenerales_R.Text;

            return objRecepcionBLL;
        }

        public void LLenarGridR()
        {
            dgv_R.DataSource = oRecepcionDAL.MostrarR().Tables[0];

        }
        public void LimpiarTxtT()
        {
            txt_NoR.Text = "";
            txt_EmpresaR.Text = "";
            txt_Tel_Cel_R.Text = "";
            txt_Fecha_R.Text = "";
            txt_Contacto.Text = "";
            txt_Correo.Text = "";
            txt_Servicio.Text = "";
            txt_Numero_Ingreso.Text = "";
            txt_Certificado_Informe.Text = "";
            txt_Tipo_Servicio.Text = "";
            txt_Equipo.Text = "";
            txt_MarcaR.Text = "";
            txt_ModeloR.Text = "";
            txt_No_Serie.Text = "";
            txt_IDCliente.Text = "";
            txt_No_Partes.Text = "";
            txt_Accesorios.Text = "";
            txt_Observaciones.Text = "";
            txt_MensageObservacionesGenerales_R.Text = "";




        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;
            dgv_R.ClearSelection();


            if (indice >= 0)
            {
                /*
                txt_IDE.Text = dgv_Empleado.Rows[indice].Cells[0].Value.ToString();
                txt_NombreE.Text = dgv_Empleado.Rows[indice].Cells[1].Value.ToString();
                txt__PApellido.Text = dgv_Empleado.Rows[indice].Cells[2].Value.ToString();
                txt__SApellido.Text = dgv_Empleado.Rows[indice].Cells[3].Value.ToString();
                txt_Correo.Text = dgv_Empleado.Rows[indice].Cells[4].Value.ToString();
                */
                txt_NoR.Text = dgv_R.Rows[indice].Cells[0].Value.ToString();
                txt_EmpresaR.Text = dgv_R.Rows[indice].Cells[1].Value.ToString();
                txt_Tel_Cel_R.Text = dgv_R.Rows[indice].Cells[2].Value.ToString();
                txt_Fecha_R.Text = dgv_R.Rows[indice].Cells[3].Value.ToString();
                txt_Contacto.Text = dgv_R.Rows[indice].Cells[4].Value.ToString();
                txt_Correo.Text = dgv_R.Rows[indice].Cells[5].Value.ToString();
                txt_Servicio.Text = dgv_R.Rows[indice].Cells[6].Value.ToString();
                txt_Numero_Ingreso.Text = dgv_R.Rows[indice].Cells[7].Value.ToString();
                txt_Certificado_Informe.Text = dgv_R.Rows[indice].Cells[8].Value.ToString();
                txt_Tipo_Servicio.Text = dgv_R.Rows[indice].Cells[9].Value.ToString();
                txt_Equipo.Text = dgv_R.Rows[indice].Cells[10].Value.ToString();
                txt_MarcaR.Text = dgv_R.Rows[indice].Cells[11].Value.ToString();
                txt_ModeloR.Text = dgv_R.Rows[indice].Cells[12].Value.ToString();
                txt_No_Serie.Text = dgv_R.Rows[indice].Cells[13].Value.ToString();
                txt_IDCliente.Text = dgv_R.Rows[indice].Cells[14].Value.ToString();
                txt_No_Partes.Text = dgv_R.Rows[indice].Cells[15].Value.ToString();
                txt_Accesorios.Text = dgv_R.Rows[indice].Cells[16].Value.ToString();
                txt_Observaciones.Text = dgv_R.Rows[indice].Cells[17].Value.ToString();
                txt_MensageObservacionesGenerales_R.Text = dgv_R.Rows[indice].Cells[10].Value.ToString();


            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            oRecepcionDAL.AgregarR(RecolectarDatos());
            LLenarGridR();
            LimpiarTxtT();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            oRecepcionDAL.ModificarR(RecolectarDatos());

            LLenarGridR();
            LimpiarTxtT();
        }

    }
}
