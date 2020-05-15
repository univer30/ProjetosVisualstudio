using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoP2
{
    public partial class frmBanco : Form
    {
        public bool tem;
        Conexao conn = new Conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        String BancoN;
        String tipoConta;
        String agencia;
        String conta;
        Decimal Saldo;
        String b;
        int id;
        int i;
        public frmBanco()
        {
            InitializeComponent();
        }

        void acionarPoupanca()
        {
            try {
                DAOBanco query = new DAOBanco();
                query.alterar(getDadosBanco2());
                MessageBox.Show("Depositado com sucesso");
                txtSaldo.Clear();
            }
            catch
            {
                MessageBox.Show("Erro no banco!");
            }
}
        void criarNovaConta()
        {

            if (cbBanco.Text == "" || cbTipo.Text == "" ||
                txtAgencia.Text == "" || txtCont.Text == "" || txtSaldo.Text == "")
            {
                MessageBox.Show("Ddados em branco!");
            }
            else
            {
                inseirBanco();
                cbBanco.Text = "";
                cbTipo.Text = "";
                txtAgencia.Clear();
                txtCont.Clear();
                txtSaldo.Clear();
            }

        }

        public void setDdaosBanco(Banco ba)
        {
            cbBanco.Text = ba.BancoN;
            cbTipo.Text = ba.tipoconta;
            txtAgencia.Text = ba.agencia;
            txtCont.Text = ba.conta;
            txtSaldo.Text = ba.saldo.ToString(); 

        }
        public Banco getDadosBanco()
        {
            Banco b = new Banco();
            b.BancoN = cbBanco.Text;
            b.tipoconta = cbTipo.Text;
            b.agencia = txtAgencia.Text;
            b.conta = txtCont.Text;
            b.saldo = Convert.ToDecimal(txtSaldo.Text);
            return b;

        }
        public Banco getDadosBanco2()
        {
            Banco b = new Banco();
            b.id = id;
            b.saldo = Convert.ToDecimal(txtSaldo.Text);
            return b;

        }
        void Consulta()
        {
            cmd.CommandText = @"select * from Banco  ";
            cmd.Parameters.Clear();
            cmd.Connection = conn.Abrir();
            try
            {
                cmd.Connection = conn.Abrir();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                   id= i = dr.GetInt32(0);
                 b = BancoN = dr.GetString(1);
                 lblTipo.Text = tipoConta = dr.GetString(2);
                 lblAgencia.Text = agencia = dr.GetString(3);
                 lblConta.Text =    conta = dr.GetString(4);
                 Saldo = dr.GetDecimal(5);
                 lblSaldo.Text = Convert.ToString(Saldo);


                }
                conn.fechar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro no select");
            }

        }

        void inseirBanco()
        {
            DAOBanco query = new DAOBanco();
            query.inserir(getDadosBanco());
            MessageBox.Show("Depósitado com sucessso!");
        }

        private void frmBanco_Load(object sender, EventArgs e)
        {
            cbBanco.Enabled = false;
            cbTipo.Enabled = false;
            txtAgencia.Enabled = false;
            txtCont.Enabled = false;
            txtSaldo.Enabled = false;
            Consulta();


            if (b=="Santander  ") {
                pbsantander.Visible = true;
            }
            if (b == "BancoBrasil")
            {
                pbBrasil.Visible = true;
            }
            //Mantenha os espaço 
            if (b == "Itaú       " )
            {
                pbItau.Visible = true;
            }
            if (b == "CEF        ")
            {
                pbItau.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            criarNovaConta();
        }

        private void cbBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBanco.Text == "Itaú")
            {
                pbItau.Visible = true;
                pbBrasil.Visible = false;
                pbsantander.Visible = false;
                pbcef.Visible = false;
            }

            if (cbBanco.Text == "Santander")
            {
                pbItau.Visible = false;
                pbBrasil.Visible = false;
                pbsantander.Visible = true;
                pbcef.Visible = false;
            }

            if (cbBanco.Text == "BancoBrasil")
            {
                pbItau.Visible = false;
                pbBrasil.Visible = true;
                pbsantander.Visible = false;
                pbcef.Visible = false;
            }
            if (cbBanco.Text == "CEF")
            {
                pbItau.Visible = false;
                pbBrasil.Visible = false;
                pbsantander.Visible = false;
                pbcef.Visible = true;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtSaldo.Text=="")
            {
                MessageBox.Show("Dados em branco!" +
                    " digite os dados!");
            }
            else
            {
                acionarPoupanca();
            }
            
        }

        private void rdDepositar_CheckedChanged(object sender, EventArgs e)
        {
            
            txtSaldo.Enabled = true;
            cbBanco.Enabled = false;
            cbTipo.Enabled = false;
            txtAgencia.Enabled = false;
            txtCont.Enabled =false;
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = true;


        }

        private void rbConta_CheckedChanged(object sender, EventArgs e)
        {
            cbBanco.Enabled = true;
            cbTipo.Enabled = true;
            txtAgencia.Enabled = true;
            txtCont.Enabled = true;
            txtSaldo.Enabled = true;
            pictureBox2.Enabled = false;
            pictureBox1.Enabled = true;
        }

        private void txtAgencia_Enter(object sender, EventArgs e)
        {
            txtAgencia.BackColor = System.Drawing.Color.LightBlue;
        }

       

        private void txtCont_Enter(object sender, EventArgs e)
        {
            txtCont.BackColor = System.Drawing.Color.LightBlue;
        }

       

        private void txtSaldo_Enter(object sender, EventArgs e)
        {
            txtSaldo.BackColor = System.Drawing.Color.LightBlue;
        }

        private void txtAgencia_Leave(object sender, EventArgs e)
        {
            txtAgencia.BackColor = System.Drawing.Color.White;
        }

        private void txtCont_Leave(object sender, EventArgs e)
        {
            txtCont.BackColor = System.Drawing.Color.White;
        }

        private void txtSaldo_Leave(object sender, EventArgs e)
        {
            txtSaldo.BackColor = System.Drawing.Color.White;
        }
    }
}
