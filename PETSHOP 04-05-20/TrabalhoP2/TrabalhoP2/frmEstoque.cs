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
  
    
   
    public partial class frmEstoque : Form
    {
        String data;
        Decimal caixaValor;
        public bool tem;
        Conexao conn = new Conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public frmEstoque()
        {
            InitializeComponent();
            DAOEstoque query = new DAOEstoque();
            dataGridView1.DataSource = query.listaEstoque();
        }
        Boolean acionar = false;
        Boolean datainicio=false;
        Boolean datasaida = false;
       
            private void button1_Click(object sender, EventArgs e)
        {
            frmProduto p = new frmProduto(false);
            p.ShowDialog();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            acionar = true;
            frmProduto frm = new frmProduto(acionar);
            frm.ShowDialog();
          
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
           
            data = dateTimePicker1.Value.ToString("dd/MM/yyyy");
        }

        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
            mskDataini.BackColor = System.Drawing.Color.LightBlue;
        }

        private void mskDatafim_Enter(object sender, EventArgs e)
        {
            mskDatafim.BackColor = System.Drawing.Color.LightBlue;
        }

        private void mskDataini_Leave(object sender, EventArgs e)
        {
            mskDataini.BackColor = System.Drawing.Color.White;
        }

        private void mskDatafim_Leave(object sender, EventArgs e)
        {
            mskDatafim.BackColor = System.Drawing.Color.White;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DAOEstoque query = new DAOEstoque();
            dataGridView1.DataSource = query.listaEstoque();
        }

        private void mskDataini_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            datainicio = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DAOEstoque query = new DAOEstoque();
            dataGridView1.DataSource = query.listaEstoquePorDataSaida(mskDatafim.Text);


        }

        private void mskDatafim_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            datasaida = true;
        }

        private void cmdMes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DAOEstoque query = new DAOEstoque();
            dataGridView1.DataSource = query.listaEstoquePorDataEntrada(mskDataini.Text);

        }
    }
}
