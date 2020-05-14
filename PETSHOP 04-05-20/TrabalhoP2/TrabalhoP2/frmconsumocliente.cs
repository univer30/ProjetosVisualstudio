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
    public partial class frmconsumocliente : Form
    {
        public bool tem;
        Conexao conn = new Conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        int id;
        int i;
        decimal valorunit = 0;
        decimal soma = 0;
        decimal sub = 0;
        String subtr = "";
        String num = "";
        int num2;
        String data;
        String hora;
        String creditodebito = "crédito";
        Decimal Subtotal = 0;
        Decimal saldoconta = 0;
        Decimal total;
       

        public frmconsumocliente()
        {
            InitializeComponent();
            botaoAdicionar();

           total  = Convert.ToDecimal(lblTotal.Text);

       

            frmCaixa c = new frmCaixa(total);

        }
        
      
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           


            consultacliente frm = new consultacliente();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                Cliente cli = frm.GetCliente();
                txtcodcliente.Text = cli.idcliente.ToString();
                txtnome.Text = cli.nomecliente.ToString();
                txtcodcliente.Enabled = true;
            }
        }
        private void setdadosConsumo(ConsumoCliente cons)
        {
            txtId.Text = cons.id_consumo.ToString();
            txtcodcliente.Text = cons.cliente.ToString();
            txtcodproduto.Text = cons.produto.ToString();
            txtprecounitario.Text = cons.precoproduto.ToString();
            lblTotal.Text = cons.Precototal.ToString();
            rtbdescricao.Text = cons.nomeproduto.ToString();
        }
        private ConsumoCliente getdadosConsumo()
        {
            ConsumoCliente cons = new ConsumoCliente();

            cons.precoproduto = Convert.ToDecimal(txtprecounitario.Text);
            cons.Precototal = Convert.ToDecimal(lblTotal.Text);
            cons.nomeproduto = rtbdescricao.Text;
            cons.cliente = Convert.ToInt32(txtcodcliente.Text);
            cons.produto = Convert.ToInt32(txtcodproduto.Text);

            return cons;

        }
        public Caixa getdadoscaixa()
        { Caixa c = new Caixa();
            c.Data = data;
            c.descricao = rtbdescricao.Text;
            c.valor = Convert.ToDecimal(txtprecounitario.Text);
            c.Creditodebito = creditodebito;
            c.Subtotal = Subtotal;


            return c;
        }

        private Lista getLista()
        {
            Lista l = new Lista();

            l.p_descricao = rtbdescricao.Text;
            l.Id_produto = Convert.ToInt32(txtcodproduto.Text);
            l.p_valorUnit = Convert.ToDecimal(txtprecounitario.Text);
            l.p_total = Convert.ToDecimal(lblTotal.Text);
            l.Id_Cliente = Convert.ToInt32(txtcodcliente.Text);
            l.hora = hora;
            l.data = data;
            return l;
        }

        void Consulta()
        {
            cmd.CommandText = @"select * from Caixa  ";
            cmd.Parameters.Clear();
            cmd.Connection = conn.Abrir();
            try
            {
                cmd.Connection = conn.Abrir();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {

                    dr.Read();
                    id = i = dr.GetInt32(0);
                   
                   
                }
                conn.fechar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro no select");
            }

        }

        private void liberar()
        {
            txtcodproduto.Enabled = true;
            rtbdescricao.Enabled = true;
            txtprecounitario.Enabled = true;
            btnAdicionarL.Enabled = true;
            btnExcluirL.Enabled = true;



        }
        private void limpartela()
        {

            txtnome.Clear();
            txtcodproduto.Clear();
            txtprecounitario.Clear();
            lblTotal.Text = " 0,00 ";
            rtbdescricao.Clear();
            txtId.Clear();
            txtcodcliente.Clear();
            listView2.Items.Clear();
        }
        private void botaoAdicionar()
        {
            
            btnexcluir.Enabled = false;
            btnalterar.Enabled = false;
        }
        private void botaoAlterarExcluir()
        {
          
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



                DAOConsumoCliente query = new DAOConsumoCliente();
                query.inserir(getdadosConsumo());
                limpartela();
                botaoAdicionar();
                txtcodcliente.Clear();
                listView2.Items.Clear();
                txtcodproduto.Enabled = false;
                rtbdescricao.Enabled = false;
                txtprecounitario.Enabled = false;
                btnAdicionarL.Enabled = false;
                btnExcluirL.Enabled = false;
                txtcodcliente.Enabled = false;
                txtId.Enabled = false;
                frmNotafiscal n = new frmNotafiscal(0,0,0,0,0,0,0);
                n.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Ddaos em branco!");
            }
          
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            frmlistaconsumo frm = new frmlistaconsumo();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                setdadosConsumo(frm.GetConsumo());
                botaoAlterarExcluir();
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir o registro?", "Exclusão",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                    DialogResult.Yes)
                    new DAOConsumoCliente().excluir(getdadosConsumo());
                limpartela();
                botaoAdicionar();
            }

            catch
            {
                MessageBox.Show("Registro não excluído!");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void btnsair_Click_1(object sender, EventArgs e)
        {
            Close();
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            frmlistaproduto frm = new frmlistaproduto();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                Produto p = frm.GetProduto();
                txtcodproduto.Text = p.idproduto.ToString();
                rtbdescricao.Text = p.nomeproduto.ToString();
                txtprecounitario.Text = p.Precoproduto.ToString();

            }
        }

        private void btnalterar_Click_1(object sender, EventArgs e)
        {
            try
            {


                new DAOConsumoCliente().alterar(getdadosConsumo());
                limpartela();
                botaoAdicionar();
            }
            catch
            {
                MessageBox.Show("Dados não alterados!");
            }
        }

        private void frmconsumocliente_Load(object sender, EventArgs e)
        {

            txtcodproduto.Enabled = false;
            rtbdescricao.Enabled = false;
            txtprecounitario.Enabled = false;
            btnAdicionarL.Enabled = false;
            btnExcluirL.Enabled = false;
            txtcodcliente.Enabled = false;
            txtId.Enabled = false;
            button1.Enabled = false;
            Consulta();
            MessageBox.Show("" + id);
        }

        private void frmconsumocliente_Paint(object sender, PaintEventArgs e)
        {

            

        }

        private void btnAdicionarL_Click(object sender, EventArgs e)
        {
             data =dtpHora.Value.ToString("dd/MM/yyyy");
             hora = dtpHora.Value.ToString("HH:mm");
            ListViewItem lvwItem = listView2.Items.Add(txtcodproduto.Text);
            lvwItem.SubItems.Add(rtbdescricao.Text);
            lvwItem.SubItems.Add(txtprecounitario.Text);
            valorunit = Convert.ToDecimal(txtprecounitario.Text);
            soma = soma + valorunit;
            lblTotal.Text = Convert.ToString(soma);
            DAOConsumoCliente c = new DAOConsumoCliente();
            c.inserirLista(getLista());
            button1.Enabled = true;

            //dados para o controle de caixa
            DAOCaixa frm = new DAOCaixa();
            frm.inserir(getdadoscaixa());
       
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            
            DAOConsumoCliente c = new DAOConsumoCliente();
            num2 = Convert.ToInt32(num);

                for (int i = listView2.Items.Count - 1; i >= 0; i--)
                {
                    if (listView2.Items[i].Selected)
                    {

                        listView2.Items[i].Remove();
                        sub = Convert.ToDecimal(subtr);
                        decimal result = soma = soma - sub;
                        lblTotal.Text = Convert.ToString(result);

                        if (num2 > 0)
                        {
                            c.excluirLista(num2);

                        }
                        else
                        {
                            MessageBox.Show("Não excuído");
                        }

                    }
                }
            }
            catch
            {
                MessageBox.Show("Selecione na lista");
            }

            
            }
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (listView2.SelectedItems.Count > 0)
            {
                subtr = listView2.SelectedItems[0].SubItems[2].Text;
                num = listView2.SelectedItems[0].SubItems[0].Text;
                
            }
        }

        private void txtcodcliente_TextChanged(object sender, EventArgs e)
        {
            
                liberar();
        }

        private void dtpHora_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           

            int IdCliente = Convert.ToInt32(txtcodcliente.Text);
            frmPagamento p = new frmPagamento(txtnome.Text,soma, IdCliente, data, hora,id);
            p.ShowDialog();
         

        }

        private void btnNovavenda_Click(object sender, EventArgs e)
        {
            limpartela();
            txtcodproduto.Enabled = false;
            rtbdescricao.Enabled = false;
            txtprecounitario.Enabled = false;
            btnAdicionarL.Enabled = false;
            btnExcluirL.Enabled = false;
            txtcodcliente.Enabled = false;
            txtId.Enabled = false;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            int IdCliente = Convert.ToInt32(txtcodcliente.Text);
            frmPagamento p = new frmPagamento(txtnome.Text, soma, IdCliente, data, hora, id);
            p.ShowDialog();
        }

        private void txtcodcliente_Enter(object sender, EventArgs e)
        {
            txtcodcliente.BackColor = System.Drawing.Color.LightBlue;
        }

        private void txtcodproduto_Enter(object sender, EventArgs e)
        {
            txtcodproduto.BackColor = System.Drawing.Color.LightBlue;
        }

        private void txtcodcliente_Leave(object sender, EventArgs e)
        {
            txtcodcliente.BackColor = System.Drawing.Color.White;
        }

        private void txtcodproduto_Leave(object sender, EventArgs e)
        {
            txtcodproduto.BackColor = System.Drawing.Color.White;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
 
    }


