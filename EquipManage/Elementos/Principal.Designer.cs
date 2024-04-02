namespace EquipManage.Elementos
{
    partial class Principal
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
            this.btn_EntregaDeEquipos = new System.Windows.Forms.Button();
            this.btn_OrdenInterna = new System.Windows.Forms.Button();
            this.lbl_MensagePrincipal = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_EntregaDeEquipos
            // 
            this.btn_EntregaDeEquipos.Location = new System.Drawing.Point(915, 314);
            this.btn_EntregaDeEquipos.Name = "btn_EntregaDeEquipos";
            this.btn_EntregaDeEquipos.Size = new System.Drawing.Size(338, 96);
            this.btn_EntregaDeEquipos.TabIndex = 0;
            this.btn_EntregaDeEquipos.Text = "Recepción / Entrega de Equipos / ITEMS";
            this.btn_EntregaDeEquipos.UseVisualStyleBackColor = true;
            // 
            // btn_OrdenInterna
            // 
            this.btn_OrdenInterna.Location = new System.Drawing.Point(298, 314);
            this.btn_OrdenInterna.Name = "btn_OrdenInterna";
            this.btn_OrdenInterna.Size = new System.Drawing.Size(264, 96);
            this.btn_OrdenInterna.TabIndex = 1;
            this.btn_OrdenInterna.Text = "Orden Interna";
            this.btn_OrdenInterna.UseVisualStyleBackColor = true;
            // 
            // lbl_MensagePrincipal
            // 
            this.lbl_MensagePrincipal.AutoSize = true;
            this.lbl_MensagePrincipal.Location = new System.Drawing.Point(320, 141);
            this.lbl_MensagePrincipal.Name = "lbl_MensagePrincipal";
            this.lbl_MensagePrincipal.Size = new System.Drawing.Size(902, 25);
            this.lbl_MensagePrincipal.TabIndex = 2;
            this.lbl_MensagePrincipal.Text = " ¿Deseas gestionar la Recepción/Entrega de Equipos/Items o trabajar con Órdenes I" +
    "nternas?";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(676, 530);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(132, 73);
            this.btn_Salir.TabIndex = 3;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1614, 748);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lbl_MensagePrincipal);
            this.Controls.Add(this.btn_OrdenInterna);
            this.Controls.Add(this.btn_EntregaDeEquipos);
            this.Name = "Principal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_EntregaDeEquipos;
        private System.Windows.Forms.Button btn_OrdenInterna;
        private System.Windows.Forms.Label lbl_MensagePrincipal;
        private System.Windows.Forms.Button btn_Salir;
    }
}