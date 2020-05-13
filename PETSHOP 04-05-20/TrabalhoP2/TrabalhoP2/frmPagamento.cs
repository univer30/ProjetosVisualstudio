using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoP2
{
    public partial class frmPagamento : Form
    {
        String cliente;
        Decimal total = 0;
        Decimal troco=0;
        Decimal dinheiro = 0;
        Decimal cartao = 0;
        Decimal cheque = 0;
        Decimal ticket= 0;
        Decimal descontos = 0;
        Decimal outros = 0;
        String dat;
        String hor;
       int idClient;
        Decimal total2;
        Boolean liberar;

        public void fechar()
        {
            btnalterar_Click(null, null);
        }


        public frmPagamento(String nome, Decimal valorTotal, int IdCliente, String data, String hora)
        {
            InitializeComponent();
            cliente = nome;
            total = valorTotal;
            idClient = IdCliente;
            dat = data;
            hor = hora;

        }

       

        public void setPagamento(Pagamento p)
        {

            txtCliente.Text = p.nomecliente;
            txtDinheiro.Text = p.dinheiro.ToString();
            txtCartao.Text = p.cartao.ToString();
            txtCheque.Text = p.cheque.ToString();
            txtTicket.Text = p.ticket.ToString();
            txtDescontos.Text = p.descontos.ToString();
            txtTroco.Text = p.troco.ToString();
            lblTotal.Text = p.Total.ToString();
            idClient = p.idCliente;
            dat = p.data;
            hor = p.hora;

        }

        public Pagamento getPagamento()
        {
            Pagamento pa = new Pagamento();
            pa.nomecliente = txtCliente.Text;
            pa.dinheiro = Convert.ToDecimal(txtDinheiro.Text);
            pa.cartao = Convert.ToDecimal(txtCartao.Text);
            pa.cheque = Convert.ToDecimal(txtCheque.Text);
            pa.ticket = Convert.ToDecimal(txtTicket.Text);
            pa.descontos = Convert.ToDecimal(txtDescontos.Text);
            pa.outros = Convert.ToDecimal(txtOutros.Text);
            pa.troco = Convert.ToDecimal(txtTroco.Text);
            pa.Total = Convert.ToDecimal(lblTotal.Text);
            pa.idCliente = idClient;
            pa.data = dat;
            pa.hora = hor;
            return pa;
        }
        private void frmPagamento_Load(object sender, EventArgs e)
        {
            txtCliente.Text = cliente;
            String t = Convert.ToString(total);
            lblTotal.Text = t;
            txtDinheiro.Text = "0,00";
            txtTroco.Text = "0,00";
            btnfinalizar.Enabled = false;
            txtDescontos.Enabled = false;

        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            
            try
            {
                DAOPagamento p = new DAOPagamento();
                p.inserir(getPagamento());
                MessageBox.Show("Pagamento efetuado com sucesso!");

                frmNotafiscal n = new frmNotafiscal(dinheiro, troco, cartao, ticket, cheque, descontos, outros);
                n.ShowDialog();
                Close();
               


            }
            catch
            {
                MessageBox.Show("Pagamento não realizado!");
            }

        }
        private void btnalterar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtDinheiro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtDescontos.Text = Convert.ToString(descontos);
                dinheiro = Convert.ToDecimal(txtDinheiro.Text);
                txtTroco.Text = Convert.ToString(troco);
                total = Convert.ToDecimal(lblTotal.Text);
                troco = dinheiro - total;

                if (dinheiro >= total)
                {
                    btnfinalizar.Enabled = true;
                    txtCartao.Enabled = false;
                    txtCheque.Enabled = false;
                    txtTicket.Enabled = false;
                    txtDescontos.Enabled = false;
                    txtOutros.Enabled = false;
                    lblSaldonegativo.Visible = false;
                    lblpgtAprovado.Visible = true;
                    txtTicket.Text = "0,00";
                    txtOutros.Text = "0,00";
                 
                }
                
            }

            catch
            {
                btnfinalizar.Enabled =false;
                txtCartao.Enabled = true;
                txtCheque.Enabled = true;
                txtTicket.Enabled = true;
                txtDescontos.Enabled = true;
                txtOutros.Enabled = true;
                    lblSaldonegativo.Visible = true;
                lblpgtAprovado.Visible = false;



            }
        }

        private void txtCartao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtDescontos.Text = Convert.ToString(descontos);
                txtTroco.Text = Convert.ToString(troco);
                cartao = Convert.ToDecimal(txtCartao.Text);
                troco = dinheiro - total+cartao;
              
                if (troco==0)
                {
                    lblSaldonegativo.Visible = false;
                    btnfinalizar.Enabled = true;
                    txtCartao.Enabled = true;
                    txtCheque.Enabled = false;
                    txtTicket.Enabled = false;
                    txtDescontos.Enabled = false;
                    txtOutros.Enabled = false;
                    txtDinheiro.Enabled = false;
                    lblSaldonegativo.Visible = false;
                    lblpgtAprovado.Visible = true;
                    txtDescontos.Text = "0,00";
                   
                }

                if (cartao >= total)
                {
                    txtDinheiro.Text = "0,00";
                    txtCheque.Text = "0,00";
                    txtTicket.Text = "0,00";
                    txtDescontos.Text = "0,00";
                    txtOutros.Text = "0,00";
                    txtTroco.Text = "0,00";
                  
                }

                if (cartao>= total)
                {
                    btnfinalizar.Enabled = true;
                txtCartao.Enabled = true;
                txtCheque.Enabled = false;
                txtTicket.Enabled = false;
                txtDescontos.Enabled = false;
                txtOutros.Enabled = false;
                txtDinheiro.Enabled = false;
                    lblSaldonegativo.Visible = false;
                    lblpgtAprovado.Visible = true;
                    
                }
            }
            catch
            {
                txtDinheiro.Enabled = true;
                btnfinalizar.Enabled =false;
                txtCartao.Enabled = true;
                txtCheque.Enabled = true;
                txtTicket.Enabled = true;
                txtDescontos.Enabled = true;
                txtOutros.Enabled = true;
                lblSaldonegativo.Visible = true;
                lblpgtAprovado.Visible = false;
               
            }
        }

        private void txtCheque_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtDescontos.Text = Convert.ToString(descontos);
                txtTroco.Text = Convert.ToString(troco);
                cheque = Convert.ToDecimal(txtCheque.Text);
                troco = cheque - total;
              

                if (troco == 0)
                {
                    lblSaldonegativo.Visible = false;
                    btnfinalizar.Enabled = true;
                    txtCartao.Enabled = true;
                    txtTicket.Enabled = false;
                    txtDescontos.Enabled = false;
                    txtOutros.Enabled = false;
                    txtDinheiro.Enabled = false;
                    lblSaldonegativo.Visible = false;
                    lblpgtAprovado.Visible = true;
                }
                if (cheque >= total)
                {
                    txtDinheiro.Text = "0,00";
                    txtCartao.Text = "0,00";
                    txtTicket.Text = "0,00";
                    txtDescontos.Text = "0,00";
                    txtOutros.Text = "0,00";
                  
                }
               
                if (cheque >= total)
                {
                    txtDinheiro.Enabled = false;
                    btnfinalizar.Enabled = true;
                    txtCartao.Enabled = false;
                    txtCheque.Enabled = true;
                    txtTicket.Enabled = false;
                    txtDescontos.Enabled = false;
                    txtOutros.Enabled = false;
                    lblSaldonegativo.Visible = false;
                    lblpgtAprovado.Visible = true;
                }
            }
            catch
            {
                txtDinheiro.Enabled = true;
                btnfinalizar.Enabled = false;
                txtCartao.Enabled = true;
                txtCheque.Enabled = true;
                txtTicket.Enabled = true;
                txtDescontos.Enabled = true;
                txtOutros.Enabled = true;
                lblSaldonegativo.Visible = true;
                lblpgtAprovado.Visible = false;
            }
        }

        private void txtTicket_TextChanged(object sender, EventArgs e)
        {
            try {
                txtDescontos.Text = Convert.ToString(descontos);
                txtTroco.Text = Convert.ToString(troco);
                txtDinheiro.Text = Convert.ToString(dinheiro);
                ticket = Convert.ToDecimal(txtTicket.Text);
                troco = ticket - total;
                
                troco = dinheiro - total + ticket;
                if (ticket >= total)
                {
                    txtDinheiro.Text = "0,00";
                    txtCartao.Text = "0,00";
                    txtCheque.Text = "0,00";
                    txtDescontos.Text = "0,00";
                    txtOutros.Text = "0,00";
                    txtTroco.Text = "0,00";
                }
                if (troco == 0)
                {
                    lblSaldonegativo.Visible = false;
                    btnfinalizar.Enabled = true;
                    txtCartao.Enabled = true;
                    txtCheque.Enabled = false;
                    txtDescontos.Enabled = false;
                    txtOutros.Enabled = false;
                    txtDinheiro.Enabled = false;
                    lblSaldonegativo.Visible = false;
                    lblpgtAprovado.Visible = true;
                }
              
                if (ticket >= total)
                {
                    txtDinheiro.Enabled = false;
                    btnfinalizar.Enabled = true;
                    txtCartao.Enabled = false;
                    txtCheque.Enabled = false;
                    txtTicket.Enabled = true;
                    txtDescontos.Enabled = false;
                    txtOutros.Enabled = false;
                lblSaldonegativo.Visible =false;
                    lblpgtAprovado.Visible = true;
                   
                }
            }
            catch
            {
                txtDinheiro.Enabled = true;
                btnfinalizar.Enabled = false;
                txtCartao.Enabled = true;
                txtCheque.Enabled = true;
                txtTicket.Enabled = true;
                txtDescontos.Enabled = true;
                txtOutros.Enabled = true;
                lblSaldonegativo.Visible = true;
                lblpgtAprovado.Visible = false;
             
            }

        }

        private void txtDescontos_TextChanged(object sender, EventArgs e)
        {
            
       
            try
            {
                descontos = Convert.ToDecimal(txtDescontos.Text);
               total2 = (total - descontos);

                lblTotal.Text = Convert.ToString(total2);
               

            }
            catch
            {
                txtDescontos.Text = "";
            }
            
           
          

          

            
        }

        private void txtOutros_TextChanged(object sender, EventArgs e)
        {
            try
            {
               
                txtTroco.Text = Convert.ToString(troco);
                outros  = Convert.ToDecimal(txtOutros.Text);
                ckDescontos.Enabled = false;
                ckDescontos.Checked = false;

                troco = outros - total;
                if (outros >= total)
                {
                    txtDinheiro.Text = "0,00";
                    txtCartao.Text = "0,00";
                    txtCheque.Text = "0,00";
                    txtTicket.Text = "0,00";
                    txtDescontos.Text = "0,00";
                    txtTroco.Text = "0,00";
                }
                if (troco == 0)
                {
                    lblSaldonegativo.Visible = false;
                    btnfinalizar.Enabled = true;
                    txtCartao.Enabled = true;
                    txtCheque.Enabled = false;
                    txtTicket.Enabled = false;
                    txtDescontos.Enabled = false;
                    txtDinheiro.Enabled = false;
                    lblSaldonegativo.Visible = false;
                    lblpgtAprovado.Visible = true;
                    ckDescontos.Enabled =false;
                }
                if (outros >= total)
                {
                    txtDinheiro.Enabled = false;
                    btnfinalizar.Enabled = true;
                    txtCartao.Enabled = false;
                    txtCheque.Enabled = false; 
                    txtTicket.Enabled = false;
                    txtDescontos.Enabled = false;
                    txtOutros.Enabled = true;
                    lblSaldonegativo.Visible = false;
                    lblpgtAprovado.Visible = true;
                    ckDescontos.Enabled = true;
                }
            }
            catch
            {
                txtDinheiro.Enabled = true;
                btnfinalizar.Enabled = false;
                txtCartao.Enabled = true;
                txtCheque.Enabled = true;
                txtTicket.Enabled = true;
                txtDescontos.Enabled = true;
                txtOutros.Enabled = true;
                lblSaldonegativo.Visible = true;
                lblpgtAprovado.Visible = false;
                ckDescontos.Enabled = true;
            }
        }

      

        private void txtDinheiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 44 && e.KeyChar != 08)
            {
                e.Handled = true;
           }
           
        }

        private void txtCartao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 44 && e.KeyChar != 08)
            {
                e.Handled = true;
            }

        }

        private void txtCheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 44 && e.KeyChar != 08)
            {
                e.Handled = true;
            }

        }

        private void txtTicket_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 44 && e.KeyChar != 08)
            {
                e.Handled = true;
            }

        }

        private void txtDescontos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 44 && e.KeyChar != 08)
            {
                e.Handled = true;
            }

        }

        private void txtOutros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 44 && e.KeyChar != 08)
            {
                e.Handled = true;
            }

        }

        private void ckDescontos_CheckedChanged(object sender, EventArgs e)
        {

            if (ckDescontos.BackColor == Color.Red)
            {
                ckDescontos.BackColor = Color.Green;
                txtDescontos.Enabled = false;
                txtCartao.Enabled = true;
                txtCheque.Enabled = true;
                txtTicket.Enabled = true;
                txtOutros.Enabled = true;
                txtDescontos.Text = "0,00";
                txtDinheiro.Enabled = true;
              
            }
            else
            {
                ckDescontos.BackColor = Color.Red;
                txtDescontos.Enabled = true;
                liberar = true;
                txtCartao.Enabled = false;
                txtCheque.Enabled = false;
                txtTicket.Enabled = false;
                txtOutros.Enabled = false;
                txtDescontos.Text = "0,00";
                txtCartao.Text = "0,00";
                txtCheque.Text = "0,00";
                txtTicket.Text = "0,00";
                txtOutros.Text = "0,00";
                txtDinheiro.Text = "0,00";
                label2.Visible = true;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
