namespace EquipManage.PL.Orden_Interna
{
    partial class Orden_Interna_Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_AgregarImagen = new System.Windows.Forms.Button();
            this.btn_Anterior_OI = new System.Windows.Forms.Button();
            this.txt_DiaParaLaEntrega_OI = new System.Windows.Forms.TextBox();
            this.lbl_DiasParaLaEntrega_OI = new System.Windows.Forms.Label();
            this.btn_Borrar_OI_Admin = new System.Windows.Forms.Button();
            this.btn_Modificar_OI_Admin = new System.Windows.Forms.Button();
            this.btn_Agregar_OI_Admin = new System.Windows.Forms.Button();
            this.dgv_OI_Admin = new System.Windows.Forms.DataGridView();
            this.btn_Siguiente_OI = new System.Windows.Forms.Button();
            this.txt_ObservaG = new System.Windows.Forms.TextBox();
            this.lbl_MensageObservacionesGenerales = new System.Windows.Forms.Label();
            this.txt_Atencion = new System.Windows.Forms.TextBox();
            this.lbl_Atencion = new System.Windows.Forms.Label();
            this.txt_DireccionClienteE = new System.Windows.Forms.TextBox();
            this.txt_NombreCliente = new System.Windows.Forms.TextBox();
            this.lbl_DireccionCliente = new System.Windows.Forms.Label();
            this.lbl_NombreCliente = new System.Windows.Forms.Label();
            this.lbl_MensageDatosCliente = new System.Windows.Forms.Label();
            this.txt_ElaboroOI = new System.Windows.Forms.TextBox();
            this.lbl_ElaboroOI = new System.Windows.Forms.Label();
            this.txt_Vendedor = new System.Windows.Forms.TextBox();
            this.lbl_Vendedor = new System.Windows.Forms.Label();
            this.txt_FechaDeTérminoDeServicio = new System.Windows.Forms.TextBox();
            this.lbl_FechaDeTérminoDeServicio = new System.Windows.Forms.Label();
            this.txt_FechaDeRecepción = new System.Windows.Forms.TextBox();
            this.lbl_FechaDeRecepción = new System.Windows.Forms.Label();
            this.txt_Magnitud = new System.Windows.Forms.TextBox();
            this.lbl_Magnitud = new System.Windows.Forms.Label();
            this.txt_FechaDeElaboracióndeOI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NoDeRegistroAsignado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NoDeOI = new System.Windows.Forms.TextBox();
            this.lbl_NodeOI = new System.Windows.Forms.Label();
            this.pic_Foto = new System.Windows.Forms.PictureBox();
            this.btn_Cancelar_IO_Admin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OI_Admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AgregarImagen
            // 
            this.btn_AgregarImagen.Location = new System.Drawing.Point(791, 428);
            this.btn_AgregarImagen.Name = "btn_AgregarImagen";
            this.btn_AgregarImagen.Size = new System.Drawing.Size(210, 44);
            this.btn_AgregarImagen.TabIndex = 83;
            this.btn_AgregarImagen.Text = "Agregar Imagen";
            this.btn_AgregarImagen.UseVisualStyleBackColor = true;
            this.btn_AgregarImagen.Click += new System.EventHandler(this.btn_AgregarImagen_Click);
            // 
            // btn_Anterior_OI
            // 
            this.btn_Anterior_OI.Location = new System.Drawing.Point(85, 18);
            this.btn_Anterior_OI.Name = "btn_Anterior_OI";
            this.btn_Anterior_OI.Size = new System.Drawing.Size(119, 55);
            this.btn_Anterior_OI.TabIndex = 81;
            this.btn_Anterior_OI.Text = "Regresar";
            this.btn_Anterior_OI.UseVisualStyleBackColor = true;
            this.btn_Anterior_OI.Click += new System.EventHandler(this.btn_Anterior_OI_Click);
            // 
            // txt_DiaParaLaEntrega_OI
            // 
            this.txt_DiaParaLaEntrega_OI.Location = new System.Drawing.Point(1214, 153);
            this.txt_DiaParaLaEntrega_OI.Name = "txt_DiaParaLaEntrega_OI";
            this.txt_DiaParaLaEntrega_OI.Size = new System.Drawing.Size(188, 31);
            this.txt_DiaParaLaEntrega_OI.TabIndex = 80;
            // 
            // lbl_DiasParaLaEntrega_OI
            // 
            this.lbl_DiasParaLaEntrega_OI.AutoSize = true;
            this.lbl_DiasParaLaEntrega_OI.Location = new System.Drawing.Point(917, 153);
            this.lbl_DiasParaLaEntrega_OI.Name = "lbl_DiasParaLaEntrega_OI";
            this.lbl_DiasParaLaEntrega_OI.Size = new System.Drawing.Size(300, 25);
            this.lbl_DiasParaLaEntrega_OI.TabIndex = 79;
            this.lbl_DiasParaLaEntrega_OI.Text = "Dias faltantes para la entrega:";
            this.lbl_DiasParaLaEntrega_OI.Click += new System.EventHandler(this.lbl_DiasParaLaEntrega_OI_Click);
            // 
            // btn_Borrar_OI_Admin
            // 
            this.btn_Borrar_OI_Admin.Location = new System.Drawing.Point(1368, 51);
            this.btn_Borrar_OI_Admin.Name = "btn_Borrar_OI_Admin";
            this.btn_Borrar_OI_Admin.Size = new System.Drawing.Size(123, 52);
            this.btn_Borrar_OI_Admin.TabIndex = 78;
            this.btn_Borrar_OI_Admin.Text = "Borrar";
            this.btn_Borrar_OI_Admin.UseVisualStyleBackColor = true;
            this.btn_Borrar_OI_Admin.Click += new System.EventHandler(this.btn_Borrar_OI_Admin_Click);
            // 
            // btn_Modificar_OI_Admin
            // 
            this.btn_Modificar_OI_Admin.Location = new System.Drawing.Point(1214, 51);
            this.btn_Modificar_OI_Admin.Name = "btn_Modificar_OI_Admin";
            this.btn_Modificar_OI_Admin.Size = new System.Drawing.Size(123, 52);
            this.btn_Modificar_OI_Admin.TabIndex = 77;
            this.btn_Modificar_OI_Admin.Text = "Modificar";
            this.btn_Modificar_OI_Admin.UseVisualStyleBackColor = true;
            this.btn_Modificar_OI_Admin.Click += new System.EventHandler(this.btn_Modificar_OI_Admin_Click);
            // 
            // btn_Agregar_OI_Admin
            // 
            this.btn_Agregar_OI_Admin.Location = new System.Drawing.Point(1051, 51);
            this.btn_Agregar_OI_Admin.Name = "btn_Agregar_OI_Admin";
            this.btn_Agregar_OI_Admin.Size = new System.Drawing.Size(123, 52);
            this.btn_Agregar_OI_Admin.TabIndex = 76;
            this.btn_Agregar_OI_Admin.Text = "Agregar";
            this.btn_Agregar_OI_Admin.UseVisualStyleBackColor = true;
            this.btn_Agregar_OI_Admin.Click += new System.EventHandler(this.btn_Agregar_OI_Admin_Click);
            // 
            // dgv_OI_Admin
            // 
            this.dgv_OI_Admin.AllowUserToAddRows = false;
            this.dgv_OI_Admin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_OI_Admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OI_Admin.Location = new System.Drawing.Point(72, 859);
            this.dgv_OI_Admin.Name = "dgv_OI_Admin";
            this.dgv_OI_Admin.RowHeadersWidth = 82;
            this.dgv_OI_Admin.RowTemplate.Height = 33;
            this.dgv_OI_Admin.Size = new System.Drawing.Size(1421, 378);
            this.dgv_OI_Admin.TabIndex = 75;
            this.dgv_OI_Admin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_OI_Admin_CellContentClick);
            this.dgv_OI_Admin.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seleccionar);
            // 
            // btn_Siguiente_OI
            // 
            this.btn_Siguiente_OI.Location = new System.Drawing.Point(1513, 1170);
            this.btn_Siguiente_OI.Name = "btn_Siguiente_OI";
            this.btn_Siguiente_OI.Size = new System.Drawing.Size(121, 67);
            this.btn_Siguiente_OI.TabIndex = 74;
            this.btn_Siguiente_OI.Text = "Siguiente";
            this.btn_Siguiente_OI.UseVisualStyleBackColor = true;
            this.btn_Siguiente_OI.Click += new System.EventHandler(this.btn_Siguiente_OI_Click);
            // 
            // txt_ObservaG
            // 
            this.txt_ObservaG.Location = new System.Drawing.Point(100, 792);
            this.txt_ObservaG.Name = "txt_ObservaG";
            this.txt_ObservaG.Size = new System.Drawing.Size(1415, 31);
            this.txt_ObservaG.TabIndex = 73;
            // 
            // lbl_MensageObservacionesGenerales
            // 
            this.lbl_MensageObservacionesGenerales.AutoSize = true;
            this.lbl_MensageObservacionesGenerales.Location = new System.Drawing.Point(673, 744);
            this.lbl_MensageObservacionesGenerales.Name = "lbl_MensageObservacionesGenerales";
            this.lbl_MensageObservacionesGenerales.Size = new System.Drawing.Size(267, 25);
            this.lbl_MensageObservacionesGenerales.TabIndex = 72;
            this.lbl_MensageObservacionesGenerales.Text = "Observaciones Generales:";
            // 
            // txt_Atencion
            // 
            this.txt_Atencion.Location = new System.Drawing.Point(187, 670);
            this.txt_Atencion.Name = "txt_Atencion";
            this.txt_Atencion.Size = new System.Drawing.Size(1331, 31);
            this.txt_Atencion.TabIndex = 64;
            // 
            // lbl_Atencion
            // 
            this.lbl_Atencion.AutoSize = true;
            this.lbl_Atencion.Location = new System.Drawing.Point(85, 670);
            this.lbl_Atencion.Name = "lbl_Atencion";
            this.lbl_Atencion.Size = new System.Drawing.Size(102, 25);
            this.lbl_Atencion.TabIndex = 63;
            this.lbl_Atencion.Text = "Atención:";
            // 
            // txt_DireccionClienteE
            // 
            this.txt_DireccionClienteE.Location = new System.Drawing.Point(193, 618);
            this.txt_DireccionClienteE.Name = "txt_DireccionClienteE";
            this.txt_DireccionClienteE.Size = new System.Drawing.Size(1322, 31);
            this.txt_DireccionClienteE.TabIndex = 62;
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.Location = new System.Drawing.Point(184, 578);
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.Size = new System.Drawing.Size(1331, 31);
            this.txt_NombreCliente.TabIndex = 61;
            // 
            // lbl_DireccionCliente
            // 
            this.lbl_DireccionCliente.AutoSize = true;
            this.lbl_DireccionCliente.Location = new System.Drawing.Point(85, 621);
            this.lbl_DireccionCliente.Name = "lbl_DireccionCliente";
            this.lbl_DireccionCliente.Size = new System.Drawing.Size(108, 25);
            this.lbl_DireccionCliente.TabIndex = 60;
            this.lbl_DireccionCliente.Text = "Dirección:";
            // 
            // lbl_NombreCliente
            // 
            this.lbl_NombreCliente.AutoSize = true;
            this.lbl_NombreCliente.Location = new System.Drawing.Point(85, 578);
            this.lbl_NombreCliente.Name = "lbl_NombreCliente";
            this.lbl_NombreCliente.Size = new System.Drawing.Size(93, 25);
            this.lbl_NombreCliente.TabIndex = 59;
            this.lbl_NombreCliente.Text = "Nombre:";
            // 
            // lbl_MensageDatosCliente
            // 
            this.lbl_MensageDatosCliente.AutoSize = true;
            this.lbl_MensageDatosCliente.Location = new System.Drawing.Point(556, 512);
            this.lbl_MensageDatosCliente.Name = "lbl_MensageDatosCliente";
            this.lbl_MensageDatosCliente.Size = new System.Drawing.Size(471, 25);
            this.lbl_MensageDatosCliente.TabIndex = 58;
            this.lbl_MensageDatosCliente.Text = "Datos del cliente para emitir Certificado/Informe:";
            // 
            // txt_ElaboroOI
            // 
            this.txt_ElaboroOI.Location = new System.Drawing.Point(200, 447);
            this.txt_ElaboroOI.Name = "txt_ElaboroOI";
            this.txt_ElaboroOI.Size = new System.Drawing.Size(459, 31);
            this.txt_ElaboroOI.TabIndex = 57;
            // 
            // lbl_ElaboroOI
            // 
            this.lbl_ElaboroOI.AutoSize = true;
            this.lbl_ElaboroOI.Location = new System.Drawing.Point(80, 447);
            this.lbl_ElaboroOI.Name = "lbl_ElaboroOI";
            this.lbl_ElaboroOI.Size = new System.Drawing.Size(119, 25);
            this.lbl_ElaboroOI.TabIndex = 56;
            this.lbl_ElaboroOI.Text = "Elaboró OI:";
            // 
            // txt_Vendedor
            // 
            this.txt_Vendedor.Location = new System.Drawing.Point(193, 403);
            this.txt_Vendedor.Name = "txt_Vendedor";
            this.txt_Vendedor.Size = new System.Drawing.Size(466, 31);
            this.txt_Vendedor.TabIndex = 55;
            // 
            // lbl_Vendedor
            // 
            this.lbl_Vendedor.AutoSize = true;
            this.lbl_Vendedor.Location = new System.Drawing.Point(80, 403);
            this.lbl_Vendedor.Name = "lbl_Vendedor";
            this.lbl_Vendedor.Size = new System.Drawing.Size(111, 25);
            this.lbl_Vendedor.TabIndex = 54;
            this.lbl_Vendedor.Text = "Vendedor:";
            // 
            // txt_FechaDeTérminoDeServicio
            // 
            this.txt_FechaDeTérminoDeServicio.Location = new System.Drawing.Point(386, 352);
            this.txt_FechaDeTérminoDeServicio.Name = "txt_FechaDeTérminoDeServicio";
            this.txt_FechaDeTérminoDeServicio.Size = new System.Drawing.Size(273, 31);
            this.txt_FechaDeTérminoDeServicio.TabIndex = 53;
            // 
            // lbl_FechaDeTérminoDeServicio
            // 
            this.lbl_FechaDeTérminoDeServicio.AutoSize = true;
            this.lbl_FechaDeTérminoDeServicio.Location = new System.Drawing.Point(85, 352);
            this.lbl_FechaDeTérminoDeServicio.Name = "lbl_FechaDeTérminoDeServicio";
            this.lbl_FechaDeTérminoDeServicio.Size = new System.Drawing.Size(295, 25);
            this.lbl_FechaDeTérminoDeServicio.TabIndex = 52;
            this.lbl_FechaDeTérminoDeServicio.Text = "Fecha de término de servicio:";
            // 
            // txt_FechaDeRecepción
            // 
            this.txt_FechaDeRecepción.Location = new System.Drawing.Point(308, 302);
            this.txt_FechaDeRecepción.Name = "txt_FechaDeRecepción";
            this.txt_FechaDeRecepción.Size = new System.Drawing.Size(273, 31);
            this.txt_FechaDeRecepción.TabIndex = 51;
            // 
            // lbl_FechaDeRecepción
            // 
            this.lbl_FechaDeRecepción.AutoSize = true;
            this.lbl_FechaDeRecepción.Location = new System.Drawing.Point(85, 302);
            this.lbl_FechaDeRecepción.Name = "lbl_FechaDeRecepción";
            this.lbl_FechaDeRecepción.Size = new System.Drawing.Size(216, 25);
            this.lbl_FechaDeRecepción.TabIndex = 50;
            this.lbl_FechaDeRecepción.Text = "Fecha de Recepción:";
            // 
            // txt_Magnitud
            // 
            this.txt_Magnitud.Location = new System.Drawing.Point(193, 252);
            this.txt_Magnitud.Name = "txt_Magnitud";
            this.txt_Magnitud.Size = new System.Drawing.Size(388, 31);
            this.txt_Magnitud.TabIndex = 49;
            // 
            // lbl_Magnitud
            // 
            this.lbl_Magnitud.AutoSize = true;
            this.lbl_Magnitud.Location = new System.Drawing.Point(80, 252);
            this.lbl_Magnitud.Name = "lbl_Magnitud";
            this.lbl_Magnitud.Size = new System.Drawing.Size(107, 25);
            this.lbl_Magnitud.TabIndex = 48;
            this.lbl_Magnitud.Text = "Magnitud:";
            // 
            // txt_FechaDeElaboracióndeOI
            // 
            this.txt_FechaDeElaboracióndeOI.Location = new System.Drawing.Point(386, 200);
            this.txt_FechaDeElaboracióndeOI.Name = "txt_FechaDeElaboracióndeOI";
            this.txt_FechaDeElaboracióndeOI.Size = new System.Drawing.Size(454, 31);
            this.txt_FechaDeElaboracióndeOI.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Fecha de elaboración de OI:";
            // 
            // txt_NoDeRegistroAsignado
            // 
            this.txt_NoDeRegistroAsignado.Location = new System.Drawing.Point(395, 140);
            this.txt_NoDeRegistroAsignado.Name = "txt_NoDeRegistroAsignado";
            this.txt_NoDeRegistroAsignado.Size = new System.Drawing.Size(445, 31);
            this.txt_NoDeRegistroAsignado.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "No. de registro(s) asignado(s):";
            // 
            // txt_NoDeOI
            // 
            this.txt_NoDeOI.Location = new System.Drawing.Point(222, 85);
            this.txt_NoDeOI.Name = "txt_NoDeOI";
            this.txt_NoDeOI.Size = new System.Drawing.Size(343, 31);
            this.txt_NoDeOI.TabIndex = 43;
            // 
            // lbl_NodeOI
            // 
            this.lbl_NodeOI.AutoSize = true;
            this.lbl_NodeOI.Location = new System.Drawing.Point(80, 92);
            this.lbl_NodeOI.Name = "lbl_NodeOI";
            this.lbl_NodeOI.Size = new System.Drawing.Size(108, 25);
            this.lbl_NodeOI.TabIndex = 42;
            this.lbl_NodeOI.Text = "No. de OI:";
            // 
            // pic_Foto
            // 
            this.pic_Foto.Location = new System.Drawing.Point(1007, 226);
            this.pic_Foto.Name = "pic_Foto";
            this.pic_Foto.Size = new System.Drawing.Size(484, 246);
            this.pic_Foto.TabIndex = 82;
            this.pic_Foto.TabStop = false;
            // 
            // btn_Cancelar_IO_Admin
            // 
            this.btn_Cancelar_IO_Admin.Location = new System.Drawing.Point(1513, 51);
            this.btn_Cancelar_IO_Admin.Name = "btn_Cancelar_IO_Admin";
            this.btn_Cancelar_IO_Admin.Size = new System.Drawing.Size(123, 52);
            this.btn_Cancelar_IO_Admin.TabIndex = 84;
            this.btn_Cancelar_IO_Admin.Text = "Cancelar";
            this.btn_Cancelar_IO_Admin.UseVisualStyleBackColor = true;
            this.btn_Cancelar_IO_Admin.Click += new System.EventHandler(this.btn_Cancelar_IO_Admin_Click);
            // 
            // Orden_Interna_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1706, 1559);
            this.Controls.Add(this.btn_Cancelar_IO_Admin);
            this.Controls.Add(this.btn_AgregarImagen);
            this.Controls.Add(this.pic_Foto);
            this.Controls.Add(this.btn_Anterior_OI);
            this.Controls.Add(this.txt_DiaParaLaEntrega_OI);
            this.Controls.Add(this.lbl_DiasParaLaEntrega_OI);
            this.Controls.Add(this.btn_Borrar_OI_Admin);
            this.Controls.Add(this.btn_Modificar_OI_Admin);
            this.Controls.Add(this.btn_Agregar_OI_Admin);
            this.Controls.Add(this.dgv_OI_Admin);
            this.Controls.Add(this.btn_Siguiente_OI);
            this.Controls.Add(this.txt_ObservaG);
            this.Controls.Add(this.lbl_MensageObservacionesGenerales);
            this.Controls.Add(this.txt_Atencion);
            this.Controls.Add(this.lbl_Atencion);
            this.Controls.Add(this.txt_DireccionClienteE);
            this.Controls.Add(this.txt_NombreCliente);
            this.Controls.Add(this.lbl_DireccionCliente);
            this.Controls.Add(this.lbl_NombreCliente);
            this.Controls.Add(this.lbl_MensageDatosCliente);
            this.Controls.Add(this.txt_ElaboroOI);
            this.Controls.Add(this.lbl_ElaboroOI);
            this.Controls.Add(this.txt_Vendedor);
            this.Controls.Add(this.lbl_Vendedor);
            this.Controls.Add(this.txt_FechaDeTérminoDeServicio);
            this.Controls.Add(this.lbl_FechaDeTérminoDeServicio);
            this.Controls.Add(this.txt_FechaDeRecepción);
            this.Controls.Add(this.lbl_FechaDeRecepción);
            this.Controls.Add(this.txt_Magnitud);
            this.Controls.Add(this.lbl_Magnitud);
            this.Controls.Add(this.txt_FechaDeElaboracióndeOI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_NoDeRegistroAsignado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NoDeOI);
            this.Controls.Add(this.lbl_NodeOI);
            this.Name = "Orden_Interna_Admin";
            this.Text = "Orden_Interna_Admin";
            this.Load += new System.EventHandler(this.Orden_Interna_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OI_Admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AgregarImagen;
        private System.Windows.Forms.PictureBox pic_Foto;
        private System.Windows.Forms.Button btn_Anterior_OI;
        private System.Windows.Forms.TextBox txt_DiaParaLaEntrega_OI;
        private System.Windows.Forms.Label lbl_DiasParaLaEntrega_OI;
        private System.Windows.Forms.Button btn_Borrar_OI_Admin;
        private System.Windows.Forms.Button btn_Modificar_OI_Admin;
        private System.Windows.Forms.Button btn_Agregar_OI_Admin;
        private System.Windows.Forms.DataGridView dgv_OI_Admin;
        private System.Windows.Forms.Button btn_Siguiente_OI;
        private System.Windows.Forms.TextBox txt_ObservaG;
        private System.Windows.Forms.Label lbl_MensageObservacionesGenerales;
        private System.Windows.Forms.TextBox txt_Atencion;
        private System.Windows.Forms.Label lbl_Atencion;
        private System.Windows.Forms.TextBox txt_DireccionClienteE;
        private System.Windows.Forms.TextBox txt_NombreCliente;
        private System.Windows.Forms.Label lbl_DireccionCliente;
        private System.Windows.Forms.Label lbl_NombreCliente;
        private System.Windows.Forms.Label lbl_MensageDatosCliente;
        private System.Windows.Forms.TextBox txt_ElaboroOI;
        private System.Windows.Forms.Label lbl_ElaboroOI;
        private System.Windows.Forms.TextBox txt_Vendedor;
        private System.Windows.Forms.Label lbl_Vendedor;
        private System.Windows.Forms.TextBox txt_FechaDeTérminoDeServicio;
        private System.Windows.Forms.Label lbl_FechaDeTérminoDeServicio;
        private System.Windows.Forms.TextBox txt_FechaDeRecepción;
        private System.Windows.Forms.Label lbl_FechaDeRecepción;
        private System.Windows.Forms.TextBox txt_Magnitud;
        private System.Windows.Forms.Label lbl_Magnitud;
        private System.Windows.Forms.TextBox txt_FechaDeElaboracióndeOI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NoDeRegistroAsignado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NoDeOI;
        private System.Windows.Forms.Label lbl_NodeOI;
        private System.Windows.Forms.Button btn_Cancelar_IO_Admin;
    }
}