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
    public partial class consultacliente : Form
    {
        public consultacliente()
        {
            InitializeComponent();
            DAOCliente query = new DAOCliente();
            dataGridView1.DataSource = query.listaTodosClientes();

        }
           
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public  Cliente GetCliente()
        {
            Cliente c = new Cliente();
            c.idcliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            c.nomecliente = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            c.cpfcliente = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            c.endcliente = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            c.cidcliente = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            c.estcliente = (String)dataGridView1.CurrentRow.Cells[5].Value;

            return c;
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            DAOCliente query = new DAOCliente();
            dataGridView1.DataSource = query.listaClientesPorNome(txtpesquisa.Text);
        }
    }
}
