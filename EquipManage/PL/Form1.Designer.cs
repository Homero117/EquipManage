namespace EquipManage.PL
{
    partial class FormReportw
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROYECTO_INTEGRADOR_5DataSet2 = new EquipManage.PROYECTO_INTEGRADOR_5DataSet2();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.directoryEntry2 = new System.DirectoryServices.DirectoryEntry();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.equipoTableAdapter = new EquipManage.PROYECTO_INTEGRADOR_5DataSet2TableAdapters.EquipoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROYECTO_INTEGRADOR_5DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataMember = "Equipo";
            this.equipoBindingSource.DataSource = this.pROYECTO_INTEGRADOR_5DataSet2;
            // 
            // pROYECTO_INTEGRADOR_5DataSet2
            // 
            this.pROYECTO_INTEGRADOR_5DataSet2.DataSetName = "PROYECTO_INTEGRADOR_5DataSet2";
            this.pROYECTO_INTEGRADOR_5DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.equipoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EquipManage.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(2185, 1140);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // equipoTableAdapter
            // 
            this.equipoTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(2185, 1140);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReportw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReportw";
            this.Load += new System.EventHandler(this.FormReportw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROYECTO_INTEGRADOR_5DataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.DirectoryServices.DirectoryEntry directoryEntry2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PROYECTO_INTEGRADOR_5DataSet2 pROYECTO_INTEGRADOR_5DataSet2;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private PROYECTO_INTEGRADOR_5DataSet2TableAdapters.EquipoTableAdapter equipoTableAdapter;
    }
}