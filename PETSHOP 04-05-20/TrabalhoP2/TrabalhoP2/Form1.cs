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
    public partial class frmCaixa : Form
    {
        public bool tem;
        Conexao conn = new Conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        String data;
        String descricao= "Produto";
        String creditoDebito= "Credito";
        Decimal valor=0;
        Decimal saldoCaixa=0;
        Decimal subtotal=0;
        Decimal SaldoBanco;
        Decimal Somar;
        Decimal Somar2;



        public frmCaixa(Decimal ValorTotal)
        {
            InitializeComponent();
            DAOCaixa query = new DAOCaixa();
            dataGridView1.DataSource = query.listaCaixa();
            saldoCaixa = ValorTotal;


        }

        void somaVaunit()
        {

            cmd.CommandText = @"select sum(Valor) from Caixa ";
            cmd.Parameters.Clear();
            cmd.Connection = conn.Abrir();
           
                cmd.Connection = conn.Abrir();
                dr = cmd.ExecuteReader();

            dr.Read();
           Somar= Somar2= dr.GetDecimal(0);
            lblBruta.Text = Convert.ToString(Somar);
            conn.fechar();
    
        }
        void Consulta()
        {
            cmd.CommandText = @"select * from Banco ";
            cmd.Parameters.Clear();
            cmd.Connection = conn.Abrir();
            try
            {
                cmd.Connection = conn.Abrir();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();


                    SaldoBanco = dr.GetDecimal(5);



                }
                conn.fechar();
            }
            catch
            {

            }

        }


       public void setDdaoscaixa(Caixa c)
        {
            data = c.Data;
            descricao = c.descricao;
           creditoDebito = c.Creditodebito;
            valor = c.valor;
            saldoCaixa = c.SaldoConta;
            subtotal = c.Subtotal;

        }

        public Caixa getdadoscaixa()
        {
            Caixa ca =new  Caixa();
            ca.Data = data;
            ca.descricao = descricao;
            ca.Creditodebito = creditoDebito;
            ca.valor = valor;
            ca.SaldoConta = saldoCaixa;
            ca.Subtotal = subtotal;
            return ca;
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCaixa_Load(object sender, EventArgs e)
        {
            txtDataini.Select();
            data = dataTime.Value.ToString("dd/MM/yyyy");
            lblsaldo.Text = ""+saldoCaixa;
            Consulta();
            lblsaldo.Text = Convert.ToString(SaldoBanco);
            somaVaunit();
         






        }

        private void txtDataini_Enter(object sender, EventArgs e)
        {
            txtDataini.BackColor = System.Drawing.Color.LightBlue;

        }

        private void txtDataini_Leave(object sender, EventArgs e)
        {
            txtDataini.BackColor = System.Drawing.Color.White;
           
        }

        private void txtDatafim_Enter(object sender, EventArgs e)
        {
            txtDatafim.BackColor = System.Drawing.Color.LightBlue;
        }

        private void txtDatafim_Leave(object sender, EventArgs e)
        {
            txtDatafim.BackColor = System.Drawing.Color.White;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DAOCaixa query = new DAOCaixa();
            dataGridView1.DataSource = query.listaCaixa();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmBanco frm = new frmBanco();
            frm.ShowDialog();
        }
    }
}
