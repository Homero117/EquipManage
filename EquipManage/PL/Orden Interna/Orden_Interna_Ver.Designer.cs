namespace EquipManage.PL.Orden_Interna
{
    partial class Orden_Interna_Ver
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
            this.OrdenesInternas_Ver = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdenesInternas_Ver
            // 
            this.OrdenesInternas_Ver.AutoSize = true;
            this.OrdenesInternas_Ver.Location = new System.Drawing.Point(1148, 89);
            this.OrdenesInternas_Ver.Name = "OrdenesInternas_Ver";
            this.OrdenesInternas_Ver.Size = new System.Drawing.Size(177, 25);
            this.OrdenesInternas_Ver.TabIndex = 1;
            this.OrdenesInternas_Ver.Text = "Ordenes Internas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(2423, 1097);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(14, 72);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(168, 42);
            this.btnRegresar.TabIndex = 102;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Orden_Interna_Ver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(2449, 1279);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.OrdenesInternas_Ver);
            this.Name = "Orden_Interna_Ver";
            this.Text = "Orden_Interna_Ver";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrdenesInternas_Ver;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRegresar;
    }
}