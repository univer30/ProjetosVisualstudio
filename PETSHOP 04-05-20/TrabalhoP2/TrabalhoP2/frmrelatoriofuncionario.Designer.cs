namespace TrabalhoP2
{
    partial class frmrelatoriofuncionario
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
            this.LojaDataSet5 = new TrabalhoP2.LojaDataSet5();
            this.FuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FuncionarioTableAdapter = new TrabalhoP2.LojaDataSet5TableAdapters.FuncionarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LojaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuncionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet6";
            reportDataSource1.Value = this.FuncionarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrabalhoP2.RelatorioFuncionario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(625, 380);
            this.reportViewer1.TabIndex = 0;
            // 
            // LojaDataSet5
            // 
            this.LojaDataSet5.DataSetName = "LojaDataSet5";
            this.LojaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FuncionarioBindingSource
            // 
            this.FuncionarioBindingSource.DataMember = "Funcionario";
            this.FuncionarioBindingSource.DataSource = this.LojaDataSet5;
            // 
            // FuncionarioTableAdapter
            // 
            this.FuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // frmrelatoriofuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 376);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmrelatoriofuncionario";
            this.Text = "Relatporio funcioários";
            this.Load += new System.EventHandler(this.frmrelatoriofuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LojaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuncionarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FuncionarioBindingSource;
        private LojaDataSet5 LojaDataSet5;
        private LojaDataSet5TableAdapters.FuncionarioTableAdapter FuncionarioTableAdapter;
    }
}