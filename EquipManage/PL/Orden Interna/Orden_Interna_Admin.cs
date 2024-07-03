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
        byte[]  imagenByte;

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
            int NRA = 1;
            int.TryParse(txt_NoDeRegistroAsignado.Text, out NRA);
            oOrden_InternaBLL.NoRegistro_Asisgnado = NRA;
            oOrden_InternaBLL.FechaElaboracionIO = txt_FechaDeElaboracióndeOI.Text; 

            int diasParaLaEntrega = 1;
            int.TryParse(txt_DiaParaLaEntrega_OI.Text, out diasParaLaEntrega);
            oOrden_InternaBLL.DiasParaLaEntrega = diasParaLaEntrega;

            oOrden_InternaBLL.Magnitud = txt_Magnitud.Text;
            oOrden_InternaBLL.Fecha_Recepcion = txt_FechaDeRecepción.Text;
            oOrden_InternaBLL.Fecha_Termino_Servicio = txt_FechaDeTérminoDeServicio.Text;
                        
            oOrden_InternaBLL.fotoEquipo = imagenByte;
            oOrden_InternaBLL.NombreClienteE = txt_NombreCliente.Text;
            oOrden_InternaBLL.DireccionClienteE = txt_DireccionClienteE.Text;
            oOrden_InternaBLL.AtencionClienteE = txt_Atencion.Text;

            int NoT = 1;
            int.TryParse(txt_No_OIT.Text, out NoT);
            oOrden_InternaBLL.NoIOT = NoT;
            int NIDT = 1;
            int.TryParse(lbl_NoDeIngreso_OIT.Text, out NIDT);
            oOrden_InternaBLL.NoIngresoT = NIDT;
            oOrden_InternaBLL.CertificadoInforme = txt_CertificadoInforme_OIT.Text;
            oOrden_InternaBLL.TipoServicio = txt_TipoServicio_OIT.Text;
            oOrden_InternaBLL.Equipo = txt_Equipo_OIT.Text;
            oOrden_InternaBLL.Marca_Modelo = txt_Marca_OIT.Text;
            oOrden_InternaBLL.CodFabricante = txt_CodF_OIT.Text;
            oOrden_InternaBLL.Serie = txt_Serie_OIT.Text;
            oOrden_InternaBLL.Identificador = txt_Identificacion_OIT.Text;
            oOrden_InternaBLL.Intervalo = txt_Intervalo_OIT.Text;
            oOrden_InternaBLL.Resolucion = txt_Resolucion_OIT.Text;
            oOrden_InternaBLL.GradoClaseEscala = txt_Grado_OIT.Text;
            oOrden_InternaBLL.AccesoriosOI = txt_Accesiorios_OIT.Text;
            oOrden_InternaBLL.ObservacionesOI = txt_Observaciones_OIT.Text;
            oOrden_InternaBLL.Material = txt_Material_OIT.Text;
            oOrden_InternaBLL.NoParteOI = txt_NoParte_OIT.Text;
            oOrden_InternaBLL.NoPlano = txt_NoPlano_OIT.Text;
            oOrden_InternaBLL.NoColas = txt_NoCotas_OIT.Text;
            oOrden_InternaBLL.NoPiezas = txt_NoPiezas_OIT.Text;

            return oOrden_InternaBLL;


        }

        public void LLenarGridOI() { 
        dgv_OI_Admin.DataSource = oOrden_InternaDAL.MostrarEquipo().Tables[0];
        }

        public void LimpiarTxt()
        {
            txt_NoDeOI.Text = "";
            txt_NoDeRegistroAsignado.Text = "";
            txt_FechaDeElaboracióndeOI.Text = "";
            txt_Magnitud.Text = "";
            txt_FechaDeRecepción.Text = "";
            txt_FechaDeTérminoDeServicio.Text = "";
                      

            txt_NombreCliente.Text = "";
            txt_DireccionClienteE.Text = "";
            txt_Atencion.Text = "";
            txt_DiaParaLaEntrega_OI.Text = "";

            //Equipo
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
        {              /*
            int indice = e.RowIndex;
            dgv_OI_Admin.ClearSelection();


            if (indice >= 0)
            {
                
                txt_IDE.Text = dgv_Empleado.Rows[indice].Cells[0].Value.ToString();
                txt_NombreE.Text = dgv_Empleado.Rows[indice].Cells[1].Value.ToString();
                txt__PApellido.Text = dgv_Empleado.Rows[indice].Cells[2].Value.ToString();
                txt__SApellido.Text = dgv_Empleado.Rows[indice].Cells[3].Value.ToString();
                txt_Correo.Text = dgv_Empleado.Rows[indice].Cells[4].Value.ToString();

                txt_NoDeOI.Text = dgv_OI_Admin.Rows[indice].Cells[0].Value.ToString();
                txt_NoDeRegistroAsignado.Text = dgv_OI_Admin.Rows[indice].Cells[1].Value.ToString();
                txt_FechaDeElaboracióndeOI.Text = dgv_OI_Admin.Rows[indice].Cells[2].Value.ToString();
                txt_Magnitud.Text = dgv_OI_Admin.Rows[indice].Cells[3].Value.ToString();
                txt_FechaDeRecepción.Text = dgv_OI_Admin.Rows[indice].Cells[4].Value.ToString();
                txt_FechaDeTérminoDeServicio.Text = dgv_OI_Admin.Rows[indice].Cells[5].Value.ToString();
 
                txt_NombreCliente.Text = dgv_OI_Admin.Rows[indice].Cells[8].Value.ToString();
                txt_DireccionClienteE.Text = dgv_OI_Admin.Rows[indice].Cells[9].Value.ToString();
                txt_Atencion.Text = dgv_OI_Admin.Rows[indice].Cells[10].Value.ToString();
                txt_DiaParaLaEntrega_OI.Text = dgv_OI_Admin.Rows[indice].Cells[12].Value.ToString();


                txt_No_OIT.Text = dgv_OI_Admin.Rows[indice].Cells[0].Value.ToString();
                txt_NoDeIngreso_OIT.Text = dgv_OI_Admin.Rows[indice].Cells[0].Value.ToString();
                txt_CertificadoInforme_OIT.Text = dgv_OI_Admin.Rows[indice].Cells[0].Value.ToString();
                txt_TipoServicio_OIT.Text = dgv_OI_Admin.Rows[indice].Cells[0].Value.ToString();
                txt_Equipo_OIT.Text = dgv_OI_Admin.Rows[indice].Cells[0].Value.ToString();
                txt_Marca_OIT.Text = dgv_OI_Admin.Rows[indice].Cells[0].Value.ToString();
                txt_CodF_OIT.Text = dgv_OI_Admin.Rows[indice].Cells[0].Value.ToString();
                txt_Serie_OIT.Text = dgv_OI_Admin.Rows[indice].Cells[0].Value.ToString();
                txt_Identificacion_OIT.Text = dgv_OI_Admin.Rows[indice].Cells[0].Value.ToString();
                txt_Intervalo_OIT.Text = dgv_OI_Admin.Rows[indice].Cells[0].Value.ToString();
                txt_Resolucion_OIT.Text = dgv_OI_Admin.Rows[indice].Cells[0].Value.ToString();
                txt_Grado_OIT.Text = dgv_OI_Admin.Rows[indice].Cells[0].Value.ToString();
                txt_Accesiorios_OIT.Text = dgv_OI_Admin.Rows[indice].Cells[0].Value.ToString();
                txt_Observaciones_OIT.Text = dgv_OI_Admin.Rows[indice].Cells[0].Value.ToString();
                txt_Material_OIT.Text = dgv_OI_Admin.Rows[indice].Cells[0].Value.ToString();
                txt_NoParte_OIT.Text = dgv_OI_Admin.Rows[indice].Cells[0].Value.ToString();
                txt_NoPlano_OIT.Text = dgv_OI_Admin.Rows[indice].Cells[0].Value.ToString();
                txt_NoCotas_OIT.Text = dgv_OI_Admin.Rows[indice].Cells[0].Value.ToString();
                txt_NoPiezas_OIT.Text = dgv_OI_Admin.Rows[indice].Cells[0].Value.ToString();

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
              

            }
            */
        }

        private void btn_Agregar_OI_Admin_Click(object sender, EventArgs e)
        {
            oOrden_InternaDAL.AgregarOIClente(RecolectarDatos());
            oOrden_InternaDAL.AgregarEquipo(RecolectarDatos());
            dgv_OI_Admin.DataSource = oOrden_InternaDAL.MostrarEquipo().Tables[0];

            //LimpiarTxt();
        }

        private void btn_Modificar_OI_Admin_Click(object sender, EventArgs e)
        {
           
            oOrden_InternaDAL.ModificarEquipo(RecolectarDatos());
            // oOrden_InternaDAL.ModificarIO(RecolectarDatos());

            dgv_OI_Admin.DataSource = oOrden_InternaDAL.MostrarEquipo().Tables[0];

        }

        private void btn_Borrar_OI_Admin_Click(object sender, EventArgs e)
        {
            oOrden_InternaDAL.EliminarEquipo(RecolectarDatos());
                        dgv_OI_Admin.DataSource = oOrden_InternaDAL.MostrarEquipo().Tables[0];

        }

        private void txt_CertificadoInforme_OIT_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarCliente_Click(object sender, EventArgs e)
        {
            oOrden_InternaDAL.AgregarOIClente(RecolectarDatos());
            dgv_OI_Admin.DataSource = oOrden_InternaDAL.MostrarCliente().Tables[0];

        }

        private void AgregarInfo_Click(object sender, EventArgs e)
        {
            oOrden_InternaDAL.AgregarOrden_Interna(RecolectarDatos());
            dgv_OI_Admin.DataSource = oOrden_InternaDAL.MostrarOrden().Tables[0];
        }

        private void VerOrden_Click(object sender, EventArgs e)
        {
            dgv_OI_Admin.DataSource = oOrden_InternaDAL.MostrarOrden().Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgv_OI_Admin.DataSource = oOrden_InternaDAL.MostrarCliente().Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgv_OI_Admin.DataSource = oOrden_InternaDAL.MostrarEquipo().Tables[0];
        }

        private void AFoto_Click(object sender, EventArgs e)
        {
            oOrden_InternaDAL.AgregarFoto(RecolectarDatos());
            dgv_OI_Admin.DataSource = oOrden_InternaDAL.MostrarFoto().Tables[0];

        }

        private void pic_Foto_Click(object sender, EventArgs e)
        {

        }

        private void MCliente_Click(object sender, EventArgs e)
        {
            oOrden_InternaDAL.ModificarCliente(RecolectarDatos());
            dgv_OI_Admin.DataSource = oOrden_InternaDAL.MostrarCliente().Tables[0];
        }

        private void BorrarCliente_Click(object sender, EventArgs e)
        {
            oOrden_InternaDAL.EliminarCliente(RecolectarDatos());
            dgv_OI_Admin.DataSource = oOrden_InternaDAL.MostrarCliente().Tables[0];
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            oOrden_InternaDAL.EliminarOrden(RecolectarDatos());
            dgv_OI_Admin.DataSource = oOrden_InternaDAL.MostrarOrden().Tables[0];

        }

        private void button5_Click(object sender, EventArgs e)
        {
            oOrden_InternaDAL.ModificarOrden(RecolectarDatos());
            dgv_OI_Admin.DataSource = oOrden_InternaDAL.MostrarOrden().Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void reporte_Click(object sender, EventArgs e)
        {
            FormReportw formReportw = new FormReportw(); 

            formReportw.Show();
            
        }

        private void EliminarFoto_Click(object sender, EventArgs e)
        {
            oOrden_InternaDAL.EliminarFoto(RecolectarDatos());
            dgv_OI_Admin.DataSource = oOrden_InternaDAL.MostrarFoto().Tables[0];
        }

        private void DFoto_Click(object sender, EventArgs e)
        {
            dgv_OI_Admin.DataSource = oOrden_InternaDAL.MostrarFoto().Tables[0];

        }
    }
}
