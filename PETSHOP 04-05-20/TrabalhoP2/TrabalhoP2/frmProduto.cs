using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public frmProduto()
        {
            InitializeComponent();
            botaoadicionar();
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
                DAOProduto query = new DAOProduto();
                query.inserir(getdadosProduto());
                MessageBox.Show("Produto adicionado!");
                limpartela();
                botaoadicionar();
            }
            catch
            {
                MessageBox.Show("Preencha os campos!");
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
            new DAOProduto().alterar(getdadosProduto());
            limpartela();
            botaoadicionar();
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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
