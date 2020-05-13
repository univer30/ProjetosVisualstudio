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
    public partial class frmlistaconsumo : Form
    {
        public frmlistaconsumo()
        {
            InitializeComponent();
            DAOConsumoCliente query = new DAOConsumoCliente();
            dataGridView1.DataSource = query.listaConsumoClientes();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              this.DialogResult = DialogResult.OK;
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            DAOConsumoCliente cons = new DAOConsumoCliente();
            dataGridView1.DataSource = cons.listaConsumoProduto(txtpesquisa.Text);
        }
        public ConsumoCliente GetConsumo()
            {
                ConsumoCliente cons = new ConsumoCliente();
                cons.id_consumo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                cons.precoproduto = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value);
                cons.Precototal = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value);
                cons.nomeproduto = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                cons.cliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
                cons.produto =Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);
            return cons;
            }
    }
}
