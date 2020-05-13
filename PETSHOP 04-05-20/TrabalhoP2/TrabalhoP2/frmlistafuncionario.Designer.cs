namespace TrabalhoP2
{
    partial class frmlistafuncionario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlistafuncionario));
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.IdFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone1Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone2Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFuncionario
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFuncionario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFuncionario,
            this.nomeFuncionario,
            this.cpfFuncionario,
            this.endFuncionario,
            this.cidFuncionario,
            this.estFuncionario,
            this.emailFuncionario,
            this.telefone1Funcionario,
            this.telefone2Funcionario});
            this.dgvFuncionario.Location = new System.Drawing.Point(-2, -3);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.Size = new System.Drawing.Size(747, 315);
            this.dgvFuncionario.TabIndex = 0;
            this.dgvFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_CellContentClick);
            // 
            // IdFuncionario
            // 
            this.IdFuncionario.DataPropertyName = "IdFuncionario";
            this.IdFuncionario.HeaderText = "Id";
            this.IdFuncionario.Name = "IdFuncionario";
            this.IdFuncionario.Width = 20;
            // 
            // nomeFuncionario
            // 
            this.nomeFuncionario.DataPropertyName = "nomeFuncionario";
            this.nomeFuncionario.HeaderText = "Nome";
            this.nomeFuncionario.Name = "nomeFuncionario";
            this.nomeFuncionario.Width = 180;
            // 
            // cpfFuncionario
            // 
            this.cpfFuncionario.DataPropertyName = "cpfFuncionario";
            this.cpfFuncionario.HeaderText = "CPF";
            this.cpfFuncionario.Name = "cpfFuncionario";
            // 
            // endFuncionario
            // 
            this.endFuncionario.DataPropertyName = "endFuncionario";
            this.endFuncionario.HeaderText = "End";
            this.endFuncionario.Name = "endFuncionario";
            // 
            // cidFuncionario
            // 
            this.cidFuncionario.DataPropertyName = "cidFuncionario";
            this.cidFuncionario.HeaderText = "Cidade";
            this.cidFuncionario.Name = "cidFuncionario";
            // 
            // estFuncionario
            // 
            this.estFuncionario.DataPropertyName = "estFuncionario";
            this.estFuncionario.HeaderText = "Estado";
            this.estFuncionario.Name = "estFuncionario";
            // 
            // emailFuncionario
            // 
            this.emailFuncionario.DataPropertyName = "emailFuncionario";
            this.emailFuncionario.HeaderText = "Email";
            this.emailFuncionario.Name = "emailFuncionario";
            // 
            // telefone1Funcionario
            // 
            this.telefone1Funcionario.DataPropertyName = "telefone1Funcionario";
            this.telefone1Funcionario.HeaderText = "Telefone1";
            this.telefone1Funcionario.Name = "telefone1Funcionario";
            // 
            // telefone2Funcionario
            // 
            this.telefone2Funcionario.DataPropertyName = "telefone2Funcionario";
            this.telefone2Funcionario.HeaderText = "Telefone 2";
            this.telefone2Funcionario.Name = "telefone2Funcionario";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(128, 329);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(476, 27);
            this.txtPesquisa.TabIndex = 1;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(33, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisar:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(698, 328);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 31);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // frmlistafuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(741, 372);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.dgvFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmlistafuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmlistafuncionario";
            this.Load += new System.EventHandler(this.frmlistafuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn endFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn estFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone1Funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone2Funcionario;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}