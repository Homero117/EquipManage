namespace EquipManage
{
    partial class login
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
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_CerrarElPrograma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(161, 338);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(86, 25);
            this.lbl_Usuario.TabIndex = 0;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(270, 335);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(400, 31);
            this.txt_Usuario.TabIndex = 1;
            // 
            // txt_Contrasena
            // 
            this.txt_Contrasena.Location = new System.Drawing.Point(270, 402);
            this.txt_Contrasena.Name = "txt_Contrasena";
            this.txt_Contrasena.PasswordChar = '*';
            this.txt_Contrasena.Size = new System.Drawing.Size(400, 31);
            this.txt_Contrasena.TabIndex = 2;
            this.txt_Contrasena.TextChanged += new System.EventHandler(this.txt_Contrasena_TextChanged);
            // 
            // lbl_Contrasena
            // 
            this.lbl_Contrasena.AutoSize = true;
            this.lbl_Contrasena.Location = new System.Drawing.Point(124, 405);
            this.lbl_Contrasena.Name = "lbl_Contrasena";
            this.lbl_Contrasena.Size = new System.Drawing.Size(123, 25);
            this.lbl_Contrasena.TabIndex = 3;
            this.lbl_Contrasena.Text = "Contraseña";
            // 
            // lbl_MensageDeBienvenida
            // 
            this.lbl_MensageDeBienvenida.AutoSize = true;
            this.lbl_MensageDeBienvenida.Location = new System.Drawing.Point(265, 604);
            this.lbl_MensageDeBienvenida.Name = "lbl_MensageDeBienvenida";
            this.lbl_MensageDeBienvenida.Size = new System.Drawing.Size(269, 25);
            this.lbl_MensageDeBienvenida.TabIndex = 4;
            this.lbl_MensageDeBienvenida.Text = "Inicie sesión para acceder.";
            this.lbl_MensageDeBienvenida.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Location = new System.Drawing.Point(124, 493);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(211, 68);
            this.btn_Ingresar.TabIndex = 5;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EquipManage.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(124, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(546, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn_CerrarElPrograma
            // 
            this.btn_CerrarElPrograma.Location = new System.Drawing.Point(406, 493);
            this.btn_CerrarElPrograma.Name = "btn_CerrarElPrograma";
            this.btn_CerrarElPrograma.Size = new System.Drawing.Size(264, 68);
            this.btn_CerrarElPrograma.TabIndex = 7;
            this.btn_CerrarElPrograma.Text = "Cerrar el programa";
            this.btn_CerrarElPrograma.UseVisualStyleBackColor = true;
            this.btn_CerrarElPrograma.Click += new System.EventHandler(this.btn_CerrarElPrograma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "¡Bienvenido! ";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(786, 705);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CerrarElPrograma);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.lbl_MensageDeBienvenida);
            this.Controls.Add(this.lbl_Contrasena);
            this.Controls.Add(this.txt_Contrasena);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.lbl_Usuario);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_Contrasena;
        private System.Windows.Forms.Label lbl_Contrasena;
        private System.Windows.Forms.Label lbl_MensageDeBienvenida;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_CerrarElPrograma;
        private System.Windows.Forms.Label label1;
    }
}

