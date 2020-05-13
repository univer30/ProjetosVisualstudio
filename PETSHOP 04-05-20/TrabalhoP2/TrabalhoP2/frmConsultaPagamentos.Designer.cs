namespace TrabalhoP2
{
    partial class frmConsultaPagamentos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dinheiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.troco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.nomeCliente,
            this.dinheiro,
            this.cartao,
            this.cheque,
            this.ticket,
            this.descontos,
            this.outros,
            this.troco,
            this.total,
            this.data,
            this.hora});
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(609, 345);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "idCliente";
            this.idCliente.HeaderText = "idCliente";
            this.idCliente.Name = "idCliente";
            // 
            // nomeCliente
            // 
            this.nomeCliente.DataPropertyName = "nomeCliente";
            this.nomeCliente.HeaderText = "Cliente";
            this.nomeCliente.Name = "nomeCliente";
            // 
            // dinheiro
            // 
            this.dinheiro.DataPropertyName = "dinheiro";
            this.dinheiro.HeaderText = "Dinheiro";
            this.dinheiro.Name = "dinheiro";
            // 
            // cartao
            // 
            this.cartao.DataPropertyName = "cartao";
            this.cartao.HeaderText = "Cartão";
            this.cartao.Name = "cartao";
            // 
            // cheque
            // 
            this.cheque.DataPropertyName = "cheque";
            this.cheque.HeaderText = "Cheque";
            this.cheque.Name = "cheque";
            // 
            // ticket
            // 
            this.ticket.DataPropertyName = "ticket";
            this.ticket.HeaderText = "Ticket";
            this.ticket.Name = "ticket";
            // 
            // descontos
            // 
            this.descontos.DataPropertyName = "descontos";
            this.descontos.HeaderText = "Descontos";
            this.descontos.Name = "descontos";
            // 
            // outros
            // 
            this.outros.DataPropertyName = "outros";
            this.outros.HeaderText = "Outros";
            this.outros.Name = "outros";
            // 
            // troco
            // 
            this.troco.DataPropertyName = "troco";
            this.troco.HeaderText = "Troco";
            this.troco.Name = "troco";
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            // 
            // hora
            // 
            this.hora.DataPropertyName = "hora";
            this.hora.HeaderText = "Hora";
            this.hora.Name = "hora";
            // 
            // frmConsultaPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 349);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmConsultaPagamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPagamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dinheiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheque;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontos;
        private System.Windows.Forms.DataGridViewTextBoxColumn outros;
        private System.Windows.Forms.DataGridViewTextBoxColumn troco;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
    }
}