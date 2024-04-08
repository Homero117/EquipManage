namespace EquipManage
{
    partial class From1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Contrasena = new System.Windows.Forms.TextBox();
            this.lbl_Contrasena = new System.Windows.Forms.Label();
            this.lbl_MensageDeBienvenida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(615, 326);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(86, 25);
            this.lbl_Usuario.TabIndex = 0;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(724, 326);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(285, 31);
            this.txt_Usuario.TabIndex = 1;
            // 
            // txt_Contrasena
            // 
            this.txt_Contrasena.Location = new System.Drawing.Point(724, 393);
            this.txt_Contrasena.Name = "txt_Contrasena";
            this.txt_Contrasena.Size = new System.Drawing.Size(285, 31);
            this.txt_Contrasena.TabIndex = 2;
            // 
            // lbl_Contrasena
            // 
            this.lbl_Contrasena.AutoSize = true;
            this.lbl_Contrasena.Location = new System.Drawing.Point(578, 393);
            this.lbl_Contrasena.Name = "lbl_Contrasena";
            this.lbl_Contrasena.Size = new System.Drawing.Size(123, 25);
            this.lbl_Contrasena.TabIndex = 3;
            this.lbl_Contrasena.Text = "Contraseña";
            // 
            // lbl_MensageDeBienvenida
            // 
            this.lbl_MensageDeBienvenida.AutoSize = true;
            this.lbl_MensageDeBienvenida.Location = new System.Drawing.Point(479, 604);
            this.lbl_MensageDeBienvenida.Name = "lbl_MensageDeBienvenida";
            this.lbl_MensageDeBienvenida.Size = new System.Drawing.Size(650, 25);
            this.lbl_MensageDeBienvenida.TabIndex = 4;
            this.lbl_MensageDeBienvenida.Text = "¡Bienvenido a EquipManage! Por favor, inicia sesión para acceder.";
            this.lbl_MensageDeBienvenida.Click += new System.EventHandler(this.label1_Click);
            // 
            // From1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1647, 705);
            this.Controls.Add(this.lbl_MensageDeBienvenida);
            this.Controls.Add(this.lbl_Contrasena);
            this.Controls.Add(this.txt_Contrasena);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.lbl_Usuario);
            this.Name = "From1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_Contrasena;
        private System.Windows.Forms.Label lbl_Contrasena;
        private System.Windows.Forms.Label lbl_MensageDeBienvenida;
    }
}

