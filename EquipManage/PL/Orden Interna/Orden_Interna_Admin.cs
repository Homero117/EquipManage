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
            Orden_InternaBLL objOrden_InternaBLL = new Orden_InternaBLL();

            int NoIO = 1;
            int.TryParse(txt_NoDeOI.Text, out NoIO);

            objOrden_InternaBLL.NoIO = NoIO;
            objOrden_InternaBLL.NoRegistro_Asisgnado = txt_NoDeRegistroAsignado.Text;
            objOrden_InternaBLL.FechaElaboracionIO = txt_FechaDeElaboracióndeOI.Text; 

            int diasParaLaEntrega = 1;
            int.TryParse(txt_DiaParaLaEntrega_OI.Text, out diasParaLaEntrega);
            objOrden_InternaBLL.DiasParaLaEntrega = diasParaLaEntrega;

            objOrden_InternaBLL.Magnitud = txt_Magnitud.Text;
            objOrden_InternaBLL.Fecha_Recepcion = txt_FechaDeRecepción.Text;
            objOrden_InternaBLL.Fecha_Termino_Servicio = txt_FechaDeTérminoDeServicio.Text;
            objOrden_InternaBLL.Vendedor = txt_Vendedor.Text;
            objOrden_InternaBLL.ElaboroIO = txt_ElaboroOI.Text;
            objOrden_InternaBLL.fotoEquipo = imagenByte;
            objOrden_InternaBLL.NombreClienteE = txt_NombreCliente.Text;
            objOrden_InternaBLL.DireccionClienteE = txt_DireccionClienteE.Text;
            objOrden_InternaBLL.AtencionClienteE = txt_Atencion.Text;
            objOrden_InternaBLL.Observaciones_GeneralesOI = txt_ObservaG.Text;

            return objOrden_InternaBLL;


        }

        public void LLenarGridOI()
        {
            dgv_OI_Admin.DataSource = oOrden_InternaDAL.MostrarOI().Tables[0];

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
