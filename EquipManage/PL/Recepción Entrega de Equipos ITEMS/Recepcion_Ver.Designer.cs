namespace EquipManage.PL.Recepción_Entrega_de_Equipos_ITEMS
{
    partial class Recepcion_Ver
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
            this.dgv_R = new System.Windows.Forms.DataGridView();
            this.Recepcion_Ver_Titulo = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_R)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_R
            // 
            this.dgv_R.AllowUserToAddRows = false;
            this.dgv_R.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_R.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_R.Location = new System.Drawing.Point(12, 149);
            this.dgv_R.Name = "dgv_R";
            this.dgv_R.RowHeadersWidth = 82;
            this.dgv_R.RowTemplate.Height = 33;
            this.dgv_R.Size = new System.Drawing.Size(2423, 1097);
            this.dgv_R.TabIndex = 0;
            // 
            // Recepcion_Ver_Titulo
            // 
            this.Recepcion_Ver_Titulo.AutoSize = true;
            this.Recepcion_Ver_Titulo.Location = new System.Drawing.Point(1022, 74);
            this.Recepcion_Ver_Titulo.Name = "Recepcion_Ver_Titulo";
            this.Recepcion_Ver_Titulo.Size = new System.Drawing.Size(392, 25);
            this.Recepcion_Ver_Titulo.TabIndex = 1;
            this.Recepcion_Ver_Titulo.Text = "Recepcion / Entrega de Equipo / ITEMS";
            this.Recepcion_Ver_Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(13, 74);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(168, 42);
            this.btnRegresar.TabIndex = 102;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Recepcion_Ver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(2447, 1258);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.Recepcion_Ver_Titulo);
            this.Controls.Add(this.dgv_R);
            this.Name = "Recepcion_Ver";
            this.Text = "Recepcion_Ver";
            this.Load += new System.EventHandler(this.Recepcion_Ver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_R)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_R;
        private System.Windows.Forms.Label Recepcion_Ver_Titulo;
        private System.Windows.Forms.Button btnRegresar;
    }
}