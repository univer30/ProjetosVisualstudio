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
    public partial class frmlistaproduto : Form
    {
        public frmlistaproduto()
        {
            InitializeComponent();
            DAOProduto query = new DAOProduto();
            dgvproduto.DataSource = query.listaProdutos();

        }
        private void dgvproduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }


        public Produto GetProduto()
        {
            Produto p = new Produto();
            p.idproduto = Convert.ToInt32(dgvproduto.CurrentRow.Cells[0].Value);
            p.nomeproduto = dgvproduto.CurrentRow.Cells[1].Value.ToString();
            p.Precoproduto = Convert.ToDecimal(dgvproduto.CurrentRow.Cells[2].Value.ToString());
            p.qtde = Convert.ToInt32(dgvproduto.CurrentRow.Cells[3].Value.ToString());
            return p;

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DAOProduto query = new DAOProduto();
            dgvproduto.DataSource = query.listaProdutoPorNome(txtpesquisa.Text);
        }

    }
}
