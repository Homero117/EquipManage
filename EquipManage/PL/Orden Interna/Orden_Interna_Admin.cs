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
using EquipManage.BLL;
using EquipManage.DAL;

namespace EquipManage.PL.Orden_Interna
{
    public partial class Orden_Interna_Admin : Form
    {
        Orden_InternaDAL oOrden_InternaDAL;
        byte[] imagenByte;

        public Orden_Interna_Admin()
        {
            oOrden_InternaDAL = new Orden_InternaDAL();
            InitializeComponent();
            LLenarGridOI();
            LimpiarTxt();
        }

        private void btn_Anterior_OI_Click(object sender, EventArgs e)
        {
            Principal_Admin principal_Admin = new Principal_Admin();
            principal_Admin.Show();
            this.Close();
        }

        private void btn_Siguiente_OI_Click(object sender, EventArgs e)
        {
            Orden_Interna_Admin_Tabla orden_Interna_Admin_Tabla = new Orden_Interna_Admin_Tabla();
            orden_Interna_Admin_Tabla.Show();
        }

        private void Orden_Interna_Admin_Load(object sender, EventArgs e)
        {

        }

        private void btn_AgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog seleccionarimagen = new OpenFileDialog();

            seleccionarimagen.Title = "Seleccionar imagen";

            if (seleccionarimagen.ShowDialog() == DialogResult.OK)
            {
                pic_Foto.Image = Image.FromStream(seleccionarimagen.OpenFile());

                MemoryStream memory = new MemoryStream();

                pic_Foto.Image.Save(memory, System.Drawing.Imaging.ImageFormat.Png);


                imagenByte = memory.ToArray();
            }
        }

        private Orden_InternaBLL RecolectarDatos()
        {
            Orden_InternaBLL oOrden_InternaBLL = new Orden_InternaBLL();

            int NoIO = 1;
            int.TryParse(txt_NoDeOI.Text, out NoIO);

            oOrden_InternaBLL.NoIO = NoIO;
            oOrden_InternaBLL.NoRegistro_Asisgnado = txt_NoDeRegistroAsignado.Text;
            oOrden_InternaBLL.FechaElaboracionIO = txt_FechaDeElaboracióndeOI.Text; 

            int diasParaLaEntrega = 1;
            int.TryParse(txt_DiaParaLaEntrega_OI.Text, out diasParaLaEntrega);
            oOrden_InternaBLL.DiasParaLaEntrega = diasParaLaEntrega;

            oOrden_InternaBLL.Magnitud = txt_Magnitud.Text;
            oOrden_InternaBLL.Fecha_Recepcion = txt_FechaDeRecepción.Text;
            oOrden_InternaBLL.Fecha_Termino_Servicio = txt_FechaDeTérminoDeServicio.Text;
            oOrden_InternaBLL.Vendedor = txt_Vendedor.Text;
            oOrden_InternaBLL.ElaboroIO = txt_ElaboroOI.Text;
            oOrden_InternaBLL.fotoEquipo = imagenByte;
            oOrden_InternaBLL.NombreClienteE = txt_NombreCliente.Text;
            oOrden_InternaBLL.DireccionClienteE = txt_DireccionClienteE.Text;
            oOrden_InternaBLL.AtencionClienteE = txt_Atencion.Text;
            oOrden_InternaBLL.Observaciones_GeneralesOI = txt_ObservaG.Text;

            return oOrden_InternaBLL;


        }

        public void LLenarGridOI() { 
        dgv_OI_Admin.DataSource = oOrden_InternaDAL.MostrarAOI().Tables[0];
        }

        public void LimpiarTxt()
        {
            txt_NoDeOI.Text = "";
            txt_NoDeRegistroAsignado.Text = "";
            txt_FechaDeElaboracióndeOI.Text = "";
            txt_Magnitud.Text = "";
            txt_FechaDeRecepción.Text = "";
            txt_FechaDeTérminoDeServicio.Text = "";
            txt_Vendedor.Text = "";
            txt_ElaboroOI.Text = "";
            imagenByte = null;
            txt_NombreCliente.Text = "";
            txt_DireccionClienteE.Text = "";
            txt_Atencion.Text = "";
            txt_ObservaG.Text = "";
            txt_DiaParaLaEntrega_OI.Text = "";

            btn_Agregar_OI_Admin.Enabled = true;
            btn_Borrar_OI_Admin.Enabled = false;
            btn_Modificar_OI_Admin.Enabled = false;
            btn_Cancelar_IO_Admin.Enabled = false;


        }

        private void lbl_DiasParaLaEntrega_OI_Click(object sender, EventArgs e)
        {

        }

        private void dgv_OI_Admin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Cancelar_IO_Admin_Click(object sender, EventArgs e)
        {
            LimpiarTxt();
        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;
            dgv_OI_Admin.ClearSelection();


            if (indice >= 0)
            {
                /*
                txt_IDE.Text = dgv_Empleado.Rows[indice].Cells[0].Value.ToString();
                txt_NombreE.Text = dgv_Empleado.Rows[indice].Cells[1].Value.ToString();
                txt__PApellido.Text = dgv_Empleado.Rows[indice].Cells[2].Value.ToString();
                txt__SApellido.Text = dgv_Empleado.Rows[indice].Cells[3].Value.ToString();
                txt_Correo.Text = dgv_Empleado.Rows[indice].Cells[4].Value.ToString();
                */
                txt_NoDeOI.Text = dgv_OI_Admin.Rows[indice].Cells[0].Value.ToString();
                txt_NoDeRegistroAsignado.Text = dgv_OI_Admin.Rows[indice].Cells[1].Value.ToString();
                txt_FechaDeElaboracióndeOI.Text = dgv_OI_Admin.Rows[indice].Cells[2].Value.ToString();
                txt_Magnitud.Text = dgv_OI_Admin.Rows[indice].Cells[3].Value.ToString();
                txt_FechaDeRecepción.Text = dgv_OI_Admin.Rows[indice].Cells[4].Value.ToString();
                txt_FechaDeTérminoDeServicio.Text = dgv_OI_Admin.Rows[indice].Cells[5].Value.ToString();
                txt_Vendedor.Text = dgv_OI_Admin.Rows[indice].Cells[6].Value.ToString();
                txt_ElaboroOI.Text = dgv_OI_Admin.Rows[indice].Cells[7].Value.ToString();
                txt_NombreCliente.Text = dgv_OI_Admin.Rows[indice].Cells[8].Value.ToString();
                txt_DireccionClienteE.Text = dgv_OI_Admin.Rows[indice].Cells[9].Value.ToString();
                txt_Atencion.Text = dgv_OI_Admin.Rows[indice].Cells[10].Value.ToString();
                txt_ObservaG.Text = dgv_OI_Admin.Rows[indice].Cells[11].Value.ToString();
                txt_DiaParaLaEntrega_OI.Text = dgv_OI_Admin.Rows[indice].Cells[12].Value.ToString();


                object imagenCelda = dgv_OI_Admin.Rows[indice].Cells[5].Value;
                if (imagenCelda != null && imagenCelda != DBNull.Value)
                {
                    byte[] imageData = (byte[])imagenCelda;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pic_Foto.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pic_Foto.Image = null;
                }

                btn_Agregar_OI_Admin.Enabled = false;
                btn_Borrar_OI_Admin.Enabled = true;
                btn_Cancelar_IO_Admin.Enabled = true;
                btn_Modificar_OI_Admin.Enabled = true;
            }
        }

        private void btn_Agregar_OI_Admin_Click(object sender, EventArgs e)
        {
            oOrden_InternaDAL.AgregarOI(RecolectarDatos());
            LLenarGridOI();
            LimpiarTxt();
        }

        private void btn_Modificar_OI_Admin_Click(object sender, EventArgs e)
        {
            oOrden_InternaDAL.ModificarOI(RecolectarDatos());
            LLenarGridOI();
            LimpiarTxt();
        }

        private void btn_Borrar_OI_Admin_Click(object sender, EventArgs e)
        {
            oOrden_InternaDAL.EliminarOI(RecolectarDatos());
            LLenarGridOI();
            LimpiarTxt();
        }
    }
}
