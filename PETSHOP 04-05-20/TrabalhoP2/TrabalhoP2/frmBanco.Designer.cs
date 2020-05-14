namespace TrabalhoP2
{
    partial class frmBanco
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
            this.Banco = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDinheiro = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtCont = new System.Windows.Forms.TextBox();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbBanco = new System.Windows.Forms.ComboBox();
            this.txtConta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblConta = new System.Windows.Forms.Label();
            this.lblAgencia = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbBrasil = new System.Windows.Forms.PictureBox();
            this.pbsantander = new System.Windows.Forms.PictureBox();
            this.pbItau = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdDepositar = new System.Windows.Forms.RadioButton();
            this.rbConta = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBrasil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsantander)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Banco
            // 
            this.Banco.AutoSize = true;
            this.Banco.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Banco.ForeColor = System.Drawing.Color.Red;
            this.Banco.Location = new System.Drawing.Point(141, 21);
            this.Banco.Name = "Banco";
            this.Banco.Size = new System.Drawing.Size(93, 29);
            this.Banco.TabIndex = 0;
            this.Banco.Text = "Banco ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbConta);
            this.groupBox1.Controls.Add(this.rdDepositar);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtDinheiro);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.txtSaldo);
            this.groupBox1.Controls.Add(this.txtCont);
            this.groupBox1.Controls.Add(this.txtAgencia);
            this.groupBox1.Controls.Add(this.cbTipo);
            this.groupBox1.Controls.Add(this.cbBanco);
            this.groupBox1.Controls.Add(this.txtConta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 252);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.AutoSize = true;
            this.txtDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDinheiro.Location = new System.Drawing.Point(18, 132);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(58, 13);
            this.txtDinheiro.TabIndex = 12;
            this.txtDinheiro.Text = "Dinheiro:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(79, 130);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(121, 20);
            this.txtSaldo.TabIndex = 11;
            // 
            // txtCont
            // 
            this.txtCont.Location = new System.Drawing.Point(79, 104);
            this.txtCont.Name = "txtCont";
            this.txtCont.Size = new System.Drawing.Size(121, 20);
            this.txtCont.TabIndex = 10;
            // 
            // txtAgencia
            // 
            this.txtAgencia.Location = new System.Drawing.Point(79, 78);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(121, 20);
            this.txtAgencia.TabIndex = 9;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Conta-Corrente",
            "Conta-Poupança",
            "Conta-salário"});
            this.cbTipo.Location = new System.Drawing.Point(79, 51);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 8;
            // 
            // cbBanco
            // 
            this.cbBanco.FormattingEnabled = true;
            this.cbBanco.Items.AddRange(new object[] {
            "Santander",
            "BancoBrasil",
            "Caixa-Economica",
            "Itaú"});
            this.cbBanco.Location = new System.Drawing.Point(79, 22);
            this.cbBanco.Name = "cbBanco";
            this.cbBanco.Size = new System.Drawing.Size(121, 21);
            this.cbBanco.TabIndex = 5;
            this.cbBanco.SelectedIndexChanged += new System.EventHandler(this.cbBanco_SelectedIndexChanged);
            // 
            // txtConta
            // 
            this.txtConta.AutoSize = true;
            this.txtConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtConta.Location = new System.Drawing.Point(30, 104);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(44, 13);
            this.txtConta.TabIndex = 7;
            this.txtConta.Text = "Conta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Agência:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Banco:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblSaldo);
            this.groupBox2.Controls.Add(this.lblConta);
            this.groupBox2.Controls.Add(this.lblAgencia);
            this.groupBox2.Controls.Add(this.lblTipo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(250, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 157);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Saldo Conta";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(125, 126);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(40, 18);
            this.lblSaldo.TabIndex = 23;
            this.lblSaldo.Text = "0,00";
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConta.Location = new System.Drawing.Point(124, 95);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(50, 18);
            this.lblConta.TabIndex = 22;
            this.lblConta.Text = "nome";
            // 
            // lblAgencia
            // 
            this.lblAgencia.AutoSize = true;
            this.lblAgencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgencia.Location = new System.Drawing.Point(123, 66);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(50, 18);
            this.lblAgencia.TabIndex = 21;
            this.lblAgencia.Text = "nome";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(123, 37);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(50, 18);
            this.lblTipo.TabIndex = 20;
            this.lblTipo.Text = "nome";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tipo Conta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Saldo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Conta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Agencia:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TrabalhoP2.Properties.Resources.add_icon_icons_com_74429;
            this.pictureBox2.Location = new System.Drawing.Point(79, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbBrasil
            // 
            this.pbBrasil.Image = global::TrabalhoP2.Properties.Resources.bancoBrasil;
            this.pbBrasil.Location = new System.Drawing.Point(231, 14);
            this.pbBrasil.Name = "pbBrasil";
            this.pbBrasil.Size = new System.Drawing.Size(111, 50);
            this.pbBrasil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBrasil.TabIndex = 9;
            this.pbBrasil.TabStop = false;
            this.pbBrasil.Visible = false;
            // 
            // pbsantander
            // 
            this.pbsantander.Image = global::TrabalhoP2.Properties.Resources.santander;
            this.pbsantander.Location = new System.Drawing.Point(231, 14);
            this.pbsantander.Name = "pbsantander";
            this.pbsantander.Size = new System.Drawing.Size(77, 50);
            this.pbsantander.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbsantander.TabIndex = 8;
            this.pbsantander.TabStop = false;
            this.pbsantander.Visible = false;
            // 
            // pbItau
            // 
            this.pbItau.Image = global::TrabalhoP2.Properties.Resources.itau;
            this.pbItau.Location = new System.Drawing.Point(231, 14);
            this.pbItau.Name = "pbItau";
            this.pbItau.Size = new System.Drawing.Size(79, 50);
            this.pbItau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItau.TabIndex = 7;
            this.pbItau.TabStop = false;
            this.pbItau.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrabalhoP2.Properties.Resources.deposito;
            this.pictureBox1.Location = new System.Drawing.Point(145, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rdDepositar
            // 
            this.rdDepositar.AutoSize = true;
            this.rdDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDepositar.Location = new System.Drawing.Point(21, 215);
            this.rdDepositar.Name = "rdDepositar";
            this.rdDepositar.Size = new System.Drawing.Size(79, 17);
            this.rdDepositar.TabIndex = 10;
            this.rdDepositar.TabStop = true;
            this.rdDepositar.Text = "Depósitar";
            this.rdDepositar.UseVisualStyleBackColor = true;
            this.rdDepositar.CheckedChanged += new System.EventHandler(this.rdDepositar_CheckedChanged);
            // 
            // rbConta
            // 
            this.rbConta.AutoSize = true;
            this.rbConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbConta.Location = new System.Drawing.Point(115, 215);
            this.rbConta.Name = "rbConta";
            this.rbConta.Size = new System.Drawing.Size(87, 17);
            this.rbConta.TabIndex = 15;
            this.rbConta.TabStop = true;
            this.rbConta.Text = "Criar conta";
            this.rbConta.UseVisualStyleBackColor = true;
            this.rbConta.CheckedChanged += new System.EventHandler(this.rbConta_CheckedChanged);
            // 
            // frmBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 352);
            this.Controls.Add(this.pbBrasil);
            this.Controls.Add(this.pbsantander);
            this.Controls.Add(this.pbItau);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Banco);
            this.Name = "frmBanco";
            this.Text = "frmBanco";
            this.Load += new System.EventHandler(this.frmBanco_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBrasil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsantander)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Banco;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtConta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.ComboBox cbBanco;
        private System.Windows.Forms.Label txtDinheiro;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtCont;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.Label lblAgencia;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbItau;
        private System.Windows.Forms.PictureBox pbsantander;
        private System.Windows.Forms.PictureBox pbBrasil;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rbConta;
        private System.Windows.Forms.RadioButton rdDepositar;
    }
}