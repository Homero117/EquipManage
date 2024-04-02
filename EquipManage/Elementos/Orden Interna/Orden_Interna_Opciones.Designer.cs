namespace EquipManage.Elementos
{
    partial class Orden_Interna_Opciones
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
            this.btn_AnadirDatos = new System.Windows.Forms.Button();
            this.btn_ModificarDatos = new System.Windows.Forms.Button();
            this.btn_BorrarRegistro = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AnadirDatos
            // 
            this.btn_AnadirDatos.Location = new System.Drawing.Point(208, 332);
            this.btn_AnadirDatos.Name = "btn_AnadirDatos";
            this.btn_AnadirDatos.Size = new System.Drawing.Size(246, 113);
            this.btn_AnadirDatos.TabIndex = 0;
            this.btn_AnadirDatos.Text = "Añadir Datos";
            this.btn_AnadirDatos.UseVisualStyleBackColor = true;
            // 
            // btn_ModificarDatos
            // 
            this.btn_ModificarDatos.Location = new System.Drawing.Point(523, 332);
            this.btn_ModificarDatos.Name = "btn_ModificarDatos";
            this.btn_ModificarDatos.Size = new System.Drawing.Size(255, 113);
            this.btn_ModificarDatos.TabIndex = 1;
            this.btn_ModificarDatos.Text = "Modificar Datos";
            this.btn_ModificarDatos.UseVisualStyleBackColor = true;
            // 
            // btn_BorrarRegistro
            // 
            this.btn_BorrarRegistro.Location = new System.Drawing.Point(853, 332);
            this.btn_BorrarRegistro.Name = "btn_BorrarRegistro";
            this.btn_BorrarRegistro.Size = new System.Drawing.Size(255, 113);
            this.btn_BorrarRegistro.TabIndex = 2;
            this.btn_BorrarRegistro.Text = "Borrar Registro";
            this.btn_BorrarRegistro.UseVisualStyleBackColor = true;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(1171, 332);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(215, 113);
            this.btn_Salir.TabIndex = 3;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            // 
            // Orden_Interna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1613, 1286);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_BorrarRegistro);
            this.Controls.Add(this.btn_ModificarDatos);
            this.Controls.Add(this.btn_AnadirDatos);
            this.Name = "Orden_Interna";
            this.Text = "Orden_Interna";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AnadirDatos;
        private System.Windows.Forms.Button btn_ModificarDatos;
        private System.Windows.Forms.Button btn_BorrarRegistro;
        private System.Windows.Forms.Button btn_Salir;
    }
}