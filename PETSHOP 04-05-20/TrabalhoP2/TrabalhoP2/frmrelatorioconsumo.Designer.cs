namespace TrabalhoP2
{
    partial class frmrelatorioconsumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrelatorioconsumo));
            this.ConsumoClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LojaDataSet3 = new TrabalhoP2.LojaDataSet3();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ConsumoClienteTableAdapter = new TrabalhoP2.LojaDataSet3TableAdapters.ConsumoClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ConsumoClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LojaDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsumoClienteBindingSource
            // 
            this.ConsumoClienteBindingSource.DataMember = "ConsumoCliente";
            this.ConsumoClienteBindingSource.DataSource = this.LojaDataSet3;
            // 
            // LojaDataSet3
            // 
            this.LojaDataSet3.DataSetName = "LojaDataSet3";
            this.LojaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "DataSet3";
            reportDataSource1.Value = this.ConsumoClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrabalhoP2.relatorioconsumo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(786, 494);
            this.reportViewer1.TabIndex = 0;
            // 
            // ConsumoClienteTableAdapter
            // 
            this.ConsumoClienteTableAdapter.ClearBeforeFill = true;
            // 
            // frmrelatorioconsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 494);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmrelatorioconsumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmrelatorioconsumo";
            this.Load += new System.EventHandler(this.frmrelatorioconsumo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsumoClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LojaDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ConsumoClienteBindingSource;
        private LojaDataSet3 LojaDataSet3;
        private LojaDataSet3TableAdapters.ConsumoClienteTableAdapter ConsumoClienteTableAdapter;
    }
}