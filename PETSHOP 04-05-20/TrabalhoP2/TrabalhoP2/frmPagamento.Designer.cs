namespace TrabalhoP2
{
    partial class frmPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagamento));
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnfinalizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTroco = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtCartao = new System.Windows.Forms.TextBox();
            this.txtCheque = new System.Windows.Forms.TextBox();
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.txtDescontos = new System.Windows.Forms.TextBox();
            this.txtOutros = new System.Windows.Forms.TextBox();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.lblSaldonegativo = new System.Windows.Forms.Label();
            this.lblpgtAprovado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckDescontos = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(15, 25);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(501, 27);
            this.txtCliente.TabIndex = 28;
            // 
            // btnalterar
            // 
            this.btnalterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnalterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnalterar.FlatAppearance.BorderSize = 2;
            this.btnalterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnalterar.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnalterar.Location = new System.Drawing.Point(546, 442);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(102, 35);
            this.btnalterar.TabIndex = 42;
            this.btnalterar.Text = "Cancelar";
            this.btnalterar.UseVisualStyleBackColor = false;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.BackColor = System.Drawing.Color.Chartreuse;
            this.btnfinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfinalizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnfinalizar.FlatAppearance.BorderSize = 2;
            this.btnfinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfinalizar.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnfinalizar.Location = new System.Drawing.Point(438, 442);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(102, 35);
            this.btnfinalizar.TabIndex = 41;
            this.btnfinalizar.Text = "Finalizar";
            this.btnfinalizar.UseVisualStyleBackColor = false;
            this.btnfinalizar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 43;
            this.label1.Text = "Total R$:";
            // 
            // txtTroco
            // 
            this.txtTroco.AutoSize = true;
            this.txtTroco.Font = new System.Drawing.Font("Futura Bk BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.Location = new System.Drawing.Point(11, 13);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(54, 25);
            this.txtTroco.TabIndex = 44;
            this.txtTroco.Text = "0,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 45;
            this.label3.Text = "Troco R$:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(303, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 21);
            this.label4.TabIndex = 46;
            this.label4.Text = "Dinheiro R$:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(490, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 47;
            this.label6.Text = "Cartão:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(302, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 21);
            this.label7.TabIndex = 48;
            this.label7.Text = "Cheque:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(490, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 21);
            this.label8.TabIndex = 49;
            this.label8.Text = "Ticket:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(302, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 21);
            this.label9.TabIndex = 50;
            this.label9.Text = "Descontos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(489, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 21);
            this.label10.TabIndex = 51;
            this.label10.Text = "Outros:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(107, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 70);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 24);
            this.label11.TabIndex = 53;
            this.label11.Text = "Cliente:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrabalhoP2.Properties.Resources.bandeiras_de_cartao_mundipagg;
            this.pictureBox1.Location = new System.Drawing.Point(344, 483);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.txtTroco);
            this.groupBox2.Location = new System.Drawing.Point(57, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 53);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox9.Controls.Add(this.lblTotal);
            this.groupBox9.Location = new System.Drawing.Point(57, 399);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(173, 53);
            this.groupBox9.TabIndex = 57;
            this.groupBox9.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Futura Bk BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTotal.Location = new System.Drawing.Point(9, 13);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 25);
            this.lblTotal.TabIndex = 44;
            this.lblTotal.Text = "0,00";
            // 
            // txtCartao
            // 
            this.txtCartao.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartao.Location = new System.Drawing.Point(489, 169);
            this.txtCartao.Multiline = true;
            this.txtCartao.Name = "txtCartao";
            this.txtCartao.Size = new System.Drawing.Size(159, 50);
            this.txtCartao.TabIndex = 59;
            this.txtCartao.Text = "0,00";
            this.txtCartao.TextChanged += new System.EventHandler(this.txtCartao_TextChanged);
            this.txtCartao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCartao_KeyPress);
            // 
            // txtCheque
            // 
            this.txtCheque.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheque.Location = new System.Drawing.Point(301, 254);
            this.txtCheque.Multiline = true;
            this.txtCheque.Name = "txtCheque";
            this.txtCheque.Size = new System.Drawing.Size(159, 50);
            this.txtCheque.TabIndex = 60;
            this.txtCheque.Text = "0,00";
            this.txtCheque.TextChanged += new System.EventHandler(this.txtCheque_TextChanged);
            this.txtCheque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCheque_KeyPress);
            // 
            // txtTicket
            // 
            this.txtTicket.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicket.Location = new System.Drawing.Point(489, 254);
            this.txtTicket.Multiline = true;
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(159, 50);
            this.txtTicket.TabIndex = 61;
            this.txtTicket.Text = "0,00";
            this.txtTicket.TextChanged += new System.EventHandler(this.txtTicket_TextChanged);
            this.txtTicket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTicket_KeyPress);
            // 
            // txtDescontos
            // 
            this.txtDescontos.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescontos.Location = new System.Drawing.Point(301, 345);
            this.txtDescontos.Multiline = true;
            this.txtDescontos.Name = "txtDescontos";
            this.txtDescontos.Size = new System.Drawing.Size(159, 50);
            this.txtDescontos.TabIndex = 62;
            this.txtDescontos.Text = "0,00";
            this.txtDescontos.TextChanged += new System.EventHandler(this.txtDescontos_TextChanged);
            this.txtDescontos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescontos_KeyPress);
            // 
            // txtOutros
            // 
            this.txtOutros.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutros.Location = new System.Drawing.Point(489, 345);
            this.txtOutros.Multiline = true;
            this.txtOutros.Name = "txtOutros";
            this.txtOutros.Size = new System.Drawing.Size(159, 50);
            this.txtOutros.TabIndex = 63;
            this.txtOutros.Text = "0,00";
            this.txtOutros.TextChanged += new System.EventHandler(this.txtOutros_TextChanged);
            this.txtOutros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOutros_KeyPress);
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDinheiro.Location = new System.Drawing.Point(301, 169);
            this.txtDinheiro.Multiline = true;
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(159, 50);
            this.txtDinheiro.TabIndex = 58;
            this.txtDinheiro.Text = "0,00";
            this.txtDinheiro.TextChanged += new System.EventHandler(this.txtDinheiro_TextChanged);
            this.txtDinheiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDinheiro_KeyPress);
            // 
            // lblSaldonegativo
            // 
            this.lblSaldonegativo.AutoSize = true;
            this.lblSaldonegativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldonegativo.ForeColor = System.Drawing.Color.Red;
            this.lblSaldonegativo.Location = new System.Drawing.Point(67, 223);
            this.lblSaldonegativo.Name = "lblSaldonegativo";
            this.lblSaldonegativo.Size = new System.Drawing.Size(141, 18);
            this.lblSaldonegativo.TabIndex = 65;
            this.lblSaldonegativo.Text = "Saldo insuficiente";
            this.lblSaldonegativo.Visible = false;
            // 
            // lblpgtAprovado
            // 
            this.lblpgtAprovado.AutoSize = true;
            this.lblpgtAprovado.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpgtAprovado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblpgtAprovado.Location = new System.Drawing.Point(54, 223);
            this.lblpgtAprovado.Name = "lblpgtAprovado";
            this.lblpgtAprovado.Size = new System.Drawing.Size(165, 19);
            this.lblpgtAprovado.TabIndex = 66;
            this.lblpgtAprovado.Text = " Pagamento aprovado";
            this.lblpgtAprovado.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(55, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 28);
            this.label2.TabIndex = 67;
            this.label2.Text = "*Descontos são apenas para pagamento\r\n em dinheiro a vista.";
            this.label2.Visible = false;
            // 
            // ckDescontos
            // 
            this.ckDescontos.AutoSize = true;
            this.ckDescontos.Location = new System.Drawing.Point(70, 325);
            this.ckDescontos.Name = "ckDescontos";
            this.ckDescontos.Size = new System.Drawing.Size(15, 14);
            this.ckDescontos.TabIndex = 68;
            this.ckDescontos.UseVisualStyleBackColor = true;
            this.ckDescontos.CheckedChanged += new System.EventHandler(this.ckDescontos_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(86, 322);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 21);
            this.label12.TabIndex = 69;
            this.label12.Text = "Conceder descontos";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(46, 54);
            this.panel2.TabIndex = 71;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(41, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 54);
            this.panel1.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(225, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 22);
            this.label5.TabIndex = 34;
            this.label5.Text = "PAGAMENTO";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Location = new System.Drawing.Point(45, 557);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(630, 16);
            this.panel4.TabIndex = 73;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(0, 557);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(46, 16);
            this.panel3.TabIndex = 72;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(9, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(591, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // frmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(674, 573);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ckDescontos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblpgtAprovado);
            this.Controls.Add(this.lblSaldonegativo);
            this.Controls.Add(this.txtOutros);
            this.Controls.Add(this.txtDescontos);
            this.Controls.Add(this.txtTicket);
            this.Controls.Add(this.txtCheque);
            this.Controls.Add(this.txtCartao);
            this.Controls.Add(this.txtDinheiro);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.btnfinalizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento";
            this.Load += new System.EventHandler(this.frmPagamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnfinalizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtTroco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtCartao;
        private System.Windows.Forms.TextBox txtCheque;
        private System.Windows.Forms.TextBox txtTicket;
        private System.Windows.Forms.TextBox txtDescontos;
        private System.Windows.Forms.TextBox txtOutros;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.Label lblSaldonegativo;
        private System.Windows.Forms.Label lblpgtAprovado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckDescontos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}