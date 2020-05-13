namespace TrabalhoP2
{
    partial class frmRelatorioPagamento
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
            this.LojaDataSet4 = new TrabalhoP2.LojaDataSet4();
            this.PagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PagamentoTableAdapter = new TrabalhoP2.LojaDataSet4TableAdapters.PagamentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LojaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet4";
            reportDataSource1.Value = this.PagamentoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrabalhoP2.RelatorioPgto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(629, 451);
            this.reportViewer1.TabIndex = 0;
            // 
            // LojaDataSet4
            // 
            this.LojaDataSet4.DataSetName = "LojaDataSet4";
            this.LojaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PagamentoBindingSource
            // 
            this.PagamentoBindingSource.DataMember = "Pagamento";
            this.PagamentoBindingSource.DataSource = this.LojaDataSet4;
            // 
            // PagamentoTableAdapter
            // 
            this.PagamentoTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelatorioPagamento";
            this.Text = "Relatório pagamento";
            this.Load += new System.EventHandler(this.frmRelatorioPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LojaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagamentoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PagamentoBindingSource;
        private LojaDataSet4 LojaDataSet4;
        private LojaDataSet4TableAdapters.PagamentoTableAdapter PagamentoTableAdapter;
    }
}