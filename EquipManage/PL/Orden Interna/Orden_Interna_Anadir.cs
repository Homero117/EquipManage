using EquipManage.DAL;
using EquipManage.Elementos.Orden_Interna;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EquipManage.BLL;
using System.IO;

namespace EquipManage.Elementos
{
    public partial class Orden_Interna_Anadir : Form
    {
        Orden_InternaDAL oOrden_InternaDAL;
        byte[] imagenByte;
        public Orden_Interna_Anadir()
        {
            oOrden_InternaDAL = new Orden_InternaDAL();

            InitializeComponent();
            LLenarGridOI();
            LimpiarTxt();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Orden_Interna_Anadir_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_MensageDatosCliente_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_2(object sender, EventArgs e)
        {

        }

        private void btn_Siguiente_OI_Click(object sender, EventArgs e)
        {
            Orden_Interna_Anadir_Tabla orden_Interna_Anadir_Tabla = new Orden_Interna_Anadir_Tabla();
            orden_Interna_Anadir_Tabla.Show();
        }

        private void btn_Anterior_OI_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();

            this.Close();
        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;
            dgv_IO.ClearSelection();


            if (indice >= 0)
            {
                /*
                txt_IDE.Text = dgv_Empleado.Rows[indice].Cells[0].Value.ToString();
                txt_NombreE.Text = dgv_Empleado.Rows[indice].Cells[1].Value.ToString();
                txt__PApellido.Text = dgv_Empleado.Rows[indice].Cells[2].Value.ToString();
                txt__SApellido.Text = dgv_Empleado.Rows[indice].Cells[3].Value.ToString();
                txt_Correo.Text = dgv_Empleado.Rows[indice].Cells[4].Value.ToString();
                */
                txt_NoDeOI.Text = dgv_IO.Rows[indice].Cells[0].Value.ToString();
                txt_NoDeRegistroAsignado.Text = dgv_IO.Rows[indice].Cells[1].Value.ToString();
                txt_FechaDeElaboracióndeOI.Text = dgv_IO.Rows[indice].Cells[2].Value.ToString();
                txt_Magnitud.Text = dgv_IO.Rows[indice].Cells[3].Value.ToString();
                txt_FechaDeRecepción.Text = dgv_IO.Rows[indice].Cells[4].Value.ToString();
                txt_FechaDeTérminoDeServicio.Text = dgv_IO.Rows[indice].Cells[5].Value.ToString();
                txt_Vendedor.Text = dgv_IO.Rows[indice].Cells[6].Value.ToString();
                txt_ElaboroOI.Text = dgv_IO.Rows[indice].Cells[7].Value.ToString();
                txt_NombreCliente.Text = dgv_IO.Rows[indice].Cells[8].Value.ToString();
                txt_DireccionClienteE.Text = dgv_IO.Rows[indice].Cells[9].Value.ToString();
                txt_Atencion.Text = dgv_IO.Rows[indice].Cells[10].Value.ToString();
                txt_ObservaG.Text = dgv_IO.Rows[indice].Cells[11].Value.ToString();
                txt_DiaParaLaEntrega_OI.Text = dgv_IO.Rows[indice].Cells[12].Value.ToString();

                object imagenCelda = dgv_IO.Rows[indice].Cells[13].Value;
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
            }





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
            dgv_IO.DataSource = oOrden_InternaDAL.MostrarAOI().Tables[0];

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

            btn_Agregar_OI.Enabled = true;
            btn_Modificar_OI.Enabled = false;


        }

        private void btn_Agregar_OI_Click(object sender, EventArgs e)
        {
            oOrden_InternaDAL.AgregarOI(RecolectarDatos());
            LLenarGridOI();
            LimpiarTxt();
        }

        private void btn_Modificar_OI_Click(object sender, EventArgs e)
        {
            oOrden_InternaDAL.ModificarOI(RecolectarDatos());
            LLenarGridOI();
            LimpiarTxt();
        }
    }
}
