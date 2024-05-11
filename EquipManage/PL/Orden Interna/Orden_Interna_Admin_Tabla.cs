using EquipManage.BLL;
using EquipManage.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipManage.PL.Orden_Interna
{
    public partial class Orden_Interna_Admin_Tabla : Form
    {
        Orden_InternaDAL oOrden_InternaDAL;
        byte[] imagenByte;
        public Orden_Interna_Admin_Tabla()
        {
            oOrden_InternaDAL = new Orden_InternaDAL();

            InitializeComponent();
            LLenarGridIOT();
            LimpiarTxtT();
        }

        private void btn_Anterior_OIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Orden_Interna_Admin_Tabla_Load(object sender, EventArgs e)
        {

        }
        private Orden_InternaBLL RecolectarDatos()
        {
            Orden_InternaBLL objOrden_InternaBLL = new Orden_InternaBLL();
            int NoT = 1;
            int.TryParse(txt_No_OIT.Text, out NoT);
            objOrden_InternaBLL.NoIOT = NoT;

            objOrden_InternaBLL.NoIngresoT = txt_NoDeIngreso_OIT.Text;
            objOrden_InternaBLL.CertificadoInforme = txt_CertificadoInforme_OIT.Text;
            objOrden_InternaBLL.TipoServicio = txt_TipoServicio_OIT.Text;
            objOrden_InternaBLL.Equipo = txt_Equipo_OIT.Text;
            objOrden_InternaBLL.Marca_Modelo = txt_Marca_OIT.Text;
            objOrden_InternaBLL.CodFabricante = txt_CodF_OIT.Text;
            objOrden_InternaBLL.Serie = txt_Serie_OIT.Text;
            objOrden_InternaBLL.Identificador = txt_Identificacion_OIT.Text;
            objOrden_InternaBLL.Intervalo = txt_Intervalo_OIT.Text;
            objOrden_InternaBLL.Resolucion = txt_Resolucion_OIT.Text;
            objOrden_InternaBLL.GradoClaseEscala = txt_Grado_OIT.Text;
            objOrden_InternaBLL.AccesoriosOI = txt_Accesiorios_OIT.Text;
            objOrden_InternaBLL.ObservacionesOI = txt_Observaciones_OIT.Text;
            objOrden_InternaBLL.Material = txt_Material_OIT.Text;
            objOrden_InternaBLL.NoParteOI = txt_NoParte_OIT.Text;
            objOrden_InternaBLL.NoPlano = txt_NoPlano_OIT.Text;
            objOrden_InternaBLL.NoColas = txt_NoCotas_OIT.Text;
            objOrden_InternaBLL.NoPiezas = txt_NoPiezas_OIT.Text;

            return objOrden_InternaBLL;
        }

        public void LLenarGridIOT()
        {
            dgv_OI_Admin_Tabla.DataSource = oOrden_InternaDAL.MostrarOI_Tabla().Tables[0];
        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;
            dgv_OI_Admin_Tabla.ClearSelection();

            if (indice >= 0)
            {
                /*
                txt_IDE.Text = dgv_Empleado.Rows[indice].Cells[0].Value.ToString();
                txt_NombreE.Text = dgv_Empleado.Rows[indice].Cells[1].Value.ToString();
                txt__PApellido.Text = dgv_Empleado.Rows[indice].Cells[2].Value.ToString();
                txt__SApellido.Text = dgv_Empleado.Rows[indice].Cells[3].Value.ToString();
                txt_Correo.Text = dgv_Empleado.Rows[indice].Cells[4].Value.ToString();
                */


            }
            btn_Agregar_OITA.Enabled = false;
            btn_Borrar_OITA.Enabled = true;
            btn_Modificar_OITA.Enabled = true;
            btn_Cancelar_OITA.Enabled = true;
        }
        public void LimpiarTxtT()
        {
            txt_No_OIT.Text = "";
            txt_NoDeIngreso_OIT.Text = "";
            txt_CertificadoInforme_OIT.Text = "";
            txt_TipoServicio_OIT.Text = "";
            txt_Equipo_OIT.Text = "";
            txt_Marca_OIT.Text = "";
            txt_CodF_OIT.Text = "";
            txt_Serie_OIT.Text = "";
            txt_Identificacion_OIT.Text = "";
            txt_Intervalo_OIT.Text = "";
            txt_Resolucion_OIT.Text = "";
            txt_Grado_OIT.Text = "";
            txt_Accesiorios_OIT.Text = "";
            txt_Observaciones_OIT.Text = "";
            txt_Material_OIT.Text = "";
            txt_NoParte_OIT.Text = "";
            txt_NoPlano_OIT.Text = "";
            txt_NoCotas_OIT.Text = "";
            txt_NoPiezas_OIT.Text = "";


            btn_Agregar_OITA.Enabled = true;
            btn_Borrar_OITA.Enabled = false;
            btn_Modificar_OITA.Enabled = false;
            btn_Cancelar_OITA.Enabled = false;

        }

        private void btn_Agregar_OITA_Click(object sender, EventArgs e)
        {
            oOrden_InternaDAL.AgregarOI_Tabla(RecolectarDatos());
            LLenarGridIOT();
            LimpiarTxtT();
        }

        private void btn_Modificar_OITA_Click(object sender, EventArgs e)
        {
            oOrden_InternaDAL.ModificarOI_Tabla(RecolectarDatos());
            LLenarGridIOT();
            LimpiarTxtT();
        }

        private void btn_Borrar_OITA_Click(object sender, EventArgs e)
        {
            oOrden_InternaDAL.EliminarOI_Tabla(RecolectarDatos());
            LLenarGridIOT();
            LimpiarTxtT();
        }

        private void btn_Cancelar_OITA_Click(object sender, EventArgs e)
        {
            LimpiarTxtT();
        }
    }
}
