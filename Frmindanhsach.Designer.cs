namespace TTCSDL1
{
    partial class Frmindanhsach
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.TIMKIEM = new System.Windows.Forms.Button();
            this.CT_HOCPHANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new TTCSDL1.DataSet1();
            this.CT_HOCPHANTableAdapter = new TTCSDL1.DataSet1TableAdapters.CT_HOCPHANTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CT_HOCPHANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CT_HOCPHANBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TTCSDL1.Reportindanhsach.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(25, 67);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(858, 371);
            this.reportViewer1.TabIndex = 0;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(25, 23);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(100, 20);
            this.txttimkiem.TabIndex = 1;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // TIMKIEM
            // 
            this.TIMKIEM.Location = new System.Drawing.Point(163, 23);
            this.TIMKIEM.Name = "TIMKIEM";
            this.TIMKIEM.Size = new System.Drawing.Size(75, 23);
            this.TIMKIEM.TabIndex = 2;
            this.TIMKIEM.Text = "Tìm Kiếm";
            this.TIMKIEM.UseVisualStyleBackColor = true;
            // 
            // CT_HOCPHANBindingSource
            // 
            this.CT_HOCPHANBindingSource.DataMember = "CT_HOCPHAN";
            this.CT_HOCPHANBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CT_HOCPHANTableAdapter
            // 
            this.CT_HOCPHANTableAdapter.ClearBeforeFill = true;
            // 
            // Frmindanhsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.TIMKIEM);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frmindanhsach";
            this.Text = "Frmindanhsach";
            this.Load += new System.EventHandler(this.Frmindanhsach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CT_HOCPHANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CT_HOCPHANBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.CT_HOCPHANTableAdapter CT_HOCPHANTableAdapter;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button TIMKIEM;
    }
}