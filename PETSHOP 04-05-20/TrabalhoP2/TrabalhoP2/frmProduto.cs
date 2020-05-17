using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoP2
{
    public partial class frmProduto : Form
    {
        Decimal saldo;
        public bool tem;
        Conexao conn = new Conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        Boolean aciona;
        int idporduto;
        int qtde;
        int qtde2;
        String data;
        String saida = "Vazio";
        int idcaixa;
        Decimal saldoapagar;
        Decimal precounitario;
        Decimal pagar;
        int qtdeproduto;
        String creditoDebito="Débito";
        Decimal   SaldoCaixa;
        


        int soma;
        public frmProduto(Boolean acionar)
        {
            InitializeComponent();
            aciona = acionar;
            botaoadicionar();
        }
        public Banco getDadosBanco()
        {
            Banco b = new Banco();
            b.id = idcaixa;
            b.saldo = pagar;
            return b;

        }
        

        void ConsultaBanco()
        {
            cmd.CommandText = @"select * from Banco";
            cmd.Parameters.Clear();
            cmd.Connection = conn.Abrir();
            try
            {
                cmd.Connection = conn.Abrir();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                 idcaixa = idcaixa = dr.GetInt32(0);
                   
                   saldo= saldo = dr.GetDecimal(5);
                    SaldoCaixa = saldo;
                 
                  
                }
                conn.fechar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro no select");
            }

        }

        public Caixa getdadoscaixa()
        {
            Caixa ca = new Caixa();
            ca.Data = data;
            ca.descricao = txtnome.Text;
            ca.Creditodebito = creditoDebito;
            ca.valor = soma;
            ca.SaldoConta = SaldoCaixa;
            ca.Subtotal = pagar;
            return ca;
        }

        void Consulta()
            {
                cmd.CommandText = @"select * from Produto  ";
                cmd.Parameters.Clear();
                cmd.Connection = conn.Abrir();
                try
                {
                    cmd.Connection = conn.Abrir();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();

                  idporduto= idporduto= dr.GetInt32(0);

                    qtdeproduto= qtdeproduto = dr.GetInt32(3);
                    }
                }
                catch
                {

                }

            }
        
                
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void setdadosProduto(Produto p)
        {
            txtcodigo.Text= p.idproduto.ToString();
            txtnome.Text = p.nomeproduto;
            txtpreço.Text = p.Precoproduto.ToString();
            txtqtde.Text = p.qtde.ToString();
            
            
        }
        private Produto getdadosProduto()
        {
           
                Produto p = new Produto();
                if (!btnadicionar.Enabled)
                p.idproduto = Convert.ToInt32(txtcodigo.Text);
                p.nomeproduto = txtnome.Text;
                p.Precoproduto = Convert.ToDecimal(txtpreço.Text);
                p.qtde = Convert.ToInt32(txtqtde.Text);
                return p;
            
        }
        private Produto getdadosProduto2()
        {

            Produto p = new Produto();
         
                p.idproduto = Convert.ToInt32(txtcodigo.Text);
            p.nomeproduto = txtnome.Text;
            p.Precoproduto = qtdeproduto;
            p.qtde = soma;
            return p;

        }
        private Estoque getdadosEstoque()
        {

            Estoque es = new Estoque();
            es.Data = data;
            es.Descricao = txtnome.Text;
            es.Unidade = Convert.ToInt32(txtqtde.Text);
            es.precoun = Convert.ToDecimal(txtpreço.Text);
            es.Entrada = data;
            es.Saida = saida;
            es.Estoqminimo = Convert.ToInt32(txtqtde.Text);
            return es;

        }

        private Estoque getdadosEstoque2()
        {
            Estoque es = new Estoque();
           
            es.Descricao = txtnome.Text;
            es.Unidade = soma;
            

            return es;
        }
            public void limpartela()
        {
            txtcodigo.Clear();
            txtnome.Clear();
            txtpreço.Clear();
        }
        private void botaoadicionar()
        {
            btnadicionar.Enabled = true;
            btnexcluir.Enabled = false;
            btnalterar.Enabled = false;
        }
        private void botaoalterarExcluir()
        {
            btnadicionar.Enabled = false;
            btnexcluir.Enabled = true;
            btnalterar.Enabled = true;
        }
        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {


            try
            {
                if (saldo >= pagar)
                {

                    qtde = Convert.ToInt32(txtqtde.Text);
                    precounitario = Convert.ToDecimal(txtpreço.Text);
                    saldoapagar = (qtde * precounitario);
                    pagar = (saldo - saldoapagar);
                    DAOCaixa c = new DAOCaixa();
                    DAOEstoque estoque = new DAOEstoque();
                    estoque.inserir(getdadosEstoque());

                    DAOProduto query = new DAOProduto();
                    query.inserir(getdadosProduto());
                    new DAOBanco().alterar(getDadosBanco());
                    c.inserir(getdadoscaixa());
                    MessageBox.Show("" + soma);
                    MessageBox.Show("Produto adicionado!");
                    limpartela();
                    botaoadicionar();

                }
                else
                {
                    MessageBox.Show("Saldo insuficiente do caixa!");
                }
            }
            catch
            {
                MessageBox.Show("Pagamento não efetuado");
            }
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
           frmlistaproduto frm = new frmlistaproduto();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                setdadosProduto(frm.GetProduto());
                botaoalterarExcluir();
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show(" Deseja excluir o registro? ","Exclusão",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) ==
                    DialogResult.Yes)
                    new DAOProduto().excluir(getdadosProduto());
                limpartela();
                botaoadicionar();

            }
            catch
            {
                MessageBox.Show("Registro excluído com sucesso!");
            }
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {

            if (aciona == false)
            {
                new DAOProduto().alterar(getdadosProduto());
                limpartela();
                botaoadicionar();
            }
            else
            {

                if (saldo >= pagar)
                {
                    Consulta();
                    qtde = Convert.ToInt32(txtqtde.Text);
                    precounitario = Convert.ToDecimal(txtpreço.Text);
                    saldoapagar = (qtde * precounitario);
                    qtdeproduto = (qtdeproduto + qtde);
                    pagar = (saldo - saldoapagar);

                    soma = (qtdeproduto + qtde);
                    DAOBanco b = new DAOBanco();
                    new DAOEstoque().alterar(getdadosEstoque2());
                    new DAOCaixa().inserir(getdadoscaixa());
                    b.alterar(getDadosBanco());

                    MessageBox.Show("Pagamento realizado");
                }
                else
                {
                   
                        MessageBox.Show("Saldo insufuciente no caixa");
                    
                }
            }
           
        }

        private void btnsair_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void frmProduto_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
          
            txtcodigo.Enabled = false;
            dateTimePicker1.Visible = false;
            data = dateTimePicker1.Value.ToString("dd/MM/yyyy");

            if (aciona)
            {
                btnadicionar.Enabled = false;
                btnexcluir.Enabled = false;
                txtcodigo.Enabled = false;
                txtnome.Enabled = false;
                txtpreço.Enabled = false;
            }
            ConsultaBanco();
           
          

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
