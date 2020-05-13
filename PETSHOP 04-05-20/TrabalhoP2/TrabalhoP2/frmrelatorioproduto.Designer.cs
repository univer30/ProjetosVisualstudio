namespace TrabalhoP2
{
    partial class frmrelatorioproduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrelatorioproduto));
            this.ProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LojaDataSet1 = new TrabalhoP2.LojaDataSet1();
            this.ProdutoTableAdapter = new TrabalhoP2.LojaDataSet1TableAdapters.ProdutoTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LojaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProdutoBindingSource
            // 
            this.ProdutoBindingSource.DataMember = "Produto";
            this.ProdutoBindingSource.DataSource = this.LojaDataSet1;
            // 
            // LojaDataSet1
            // 
            this.LojaDataSet1.DataSetName = "LojaDataSet1";
            this.LojaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProdutoTableAdapter
            // 
            this.ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "DataSetprodutos";
            reportDataSource1.Value = this.ProdutoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrabalhoP2.relatorioproduto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmrelatorioproduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmrelatorioproduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmrelatorioproduto";
            this.Load += new System.EventHandler(this.frmrelatorioproduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LojaDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ProdutoBindingSource;
        private LojaDataSet1 LojaDataSet1;
        private LojaDataSet1TableAdapters.ProdutoTableAdapter ProdutoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}