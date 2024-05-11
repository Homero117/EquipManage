namespace EquipManage.PL
{
    partial class Principal_Ver
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
            this.btn_Salir = new System.Windows.Forms.Button();
            this.lbl_MensagePrincipal = new System.Windows.Forms.Label();
            this.btn_OrdenInterna = new System.Windows.Forms.Button();
            this.btn_EntregaDeEquipos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(351, 393);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(189, 56);
            this.btn_Salir.TabIndex = 7;
            this.btn_Salir.Text = "Salir al login";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // lbl_MensagePrincipal
            // 
            this.lbl_MensagePrincipal.AutoSize = true;
            this.lbl_MensagePrincipal.Location = new System.Drawing.Point(24, 66);
            this.lbl_MensagePrincipal.Name = "lbl_MensagePrincipal";
            this.lbl_MensagePrincipal.Size = new System.Drawing.Size(781, 25);
            this.lbl_MensagePrincipal.TabIndex = 6;
            this.lbl_MensagePrincipal.Text = " ¿Deseas consultar la Recepción/Entrega de Equipos/Items o Órdenes Internas?";
            this.lbl_MensagePrincipal.Click += new System.EventHandler(this.lbl_MensagePrincipal_Click);
            // 
            // btn_OrdenInterna
            // 
            this.btn_OrdenInterna.Location = new System.Drawing.Point(543, 178);
            this.btn_OrdenInterna.Name = "btn_OrdenInterna";
            this.btn_OrdenInterna.Size = new System.Drawing.Size(264, 96);
            this.btn_OrdenInterna.TabIndex = 5;
            this.btn_OrdenInterna.Text = "Orden Interna";
            this.btn_OrdenInterna.UseVisualStyleBackColor = true;
            this.btn_OrdenInterna.Click += new System.EventHandler(this.btn_OrdenInterna_Click);
            // 
            // btn_EntregaDeEquipos
            // 
            this.btn_EntregaDeEquipos.Location = new System.Drawing.Point(40, 178);
            this.btn_EntregaDeEquipos.Name = "btn_EntregaDeEquipos";
            this.btn_EntregaDeEquipos.Size = new System.Drawing.Size(338, 96);
            this.btn_EntregaDeEquipos.TabIndex = 4;
            this.btn_EntregaDeEquipos.Text = "Recepción / Entrega de Equipos / ITEMS";
            this.btn_EntregaDeEquipos.UseVisualStyleBackColor = true;
            this.btn_EntregaDeEquipos.Click += new System.EventHandler(this.btn_EntregaDeEquipos_Click);
            // 
            // Principal_Ver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 488);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lbl_MensagePrincipal);
            this.Controls.Add(this.btn_OrdenInterna);
            this.Controls.Add(this.btn_EntregaDeEquipos);
            this.Name = "Principal_Ver";
            this.Text = "Principal_Ver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label lbl_MensagePrincipal;
        private System.Windows.Forms.Button btn_OrdenInterna;
        private System.Windows.Forms.Button btn_EntregaDeEquipos;
    }
}