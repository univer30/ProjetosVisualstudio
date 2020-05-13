namespace TrabalhoP2
{
    partial class frmlistaproduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlistaproduto));
            this.label1 = new System.Windows.Forms.Label();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.dgvproduto = new System.Windows.Forms.DataGridView();
            this.lojaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaDataSet1 = new TrabalhoP2.LojaDataSet1();
            this.idproduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeproduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoproduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(5, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisar:";
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpesquisa.Location = new System.Drawing.Point(96, 418);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(433, 26);
            this.txtpesquisa.TabIndex = 1;
            this.txtpesquisa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvproduto
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvproduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvproduto.AutoGenerateColumns = false;
            this.dgvproduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproduto,
            this.nomeproduto,
            this.precoproduto,
            this.qtde});
            this.dgvproduto.DataSource = this.lojaDataSet1BindingSource;
            this.dgvproduto.Location = new System.Drawing.Point(0, 0);
            this.dgvproduto.Name = "dgvproduto";
            this.dgvproduto.Size = new System.Drawing.Size(544, 409);
            this.dgvproduto.TabIndex = 3;
            this.dgvproduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproduto_CellContentClick);
            this.dgvproduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproduto_CellContentClick);
            // 
            // lojaDataSet1BindingSource
            // 
            this.lojaDataSet1BindingSource.DataSource = this.lojaDataSet1;
            this.lojaDataSet1BindingSource.Position = 0;
            // 
            // lojaDataSet1
            // 
            this.lojaDataSet1.DataSetName = "LojaDataSet1";
            this.lojaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idproduto
            // 
            this.idproduto.DataPropertyName = "idproduto";
            this.idproduto.HeaderText = "Cod. Produto";
            this.idproduto.Name = "idproduto";
            // 
            // nomeproduto
            // 
            this.nomeproduto.DataPropertyName = "nomeproduto";
            this.nomeproduto.HeaderText = "Descrição";
            this.nomeproduto.Name = "nomeproduto";
            this.nomeproduto.Width = 180;
            // 
            // precoproduto
            // 
            this.precoproduto.DataPropertyName = "Precoproduto";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.precoproduto.DefaultCellStyle = dataGridViewCellStyle2;
            this.precoproduto.HeaderText = "Preço";
            this.precoproduto.Name = "precoproduto";
            // 
            // qtde
            // 
            this.qtde.DataPropertyName = "qtde";
            this.qtde.HeaderText = "Qtde";
            this.qtde.Name = "qtde";
            // 
            // frmlistaproduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(543, 453);
            this.Controls.Add(this.dgvproduto);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmlistaproduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.DataGridView dgvproduto;
        private System.Windows.Forms.BindingSource lojaDataSet1BindingSource;
        private LojaDataSet1 lojaDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtde;
    }
}