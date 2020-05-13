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
    public partial class frmListaAnimal : Form
    {
        public frmListaAnimal()
        {
            InitializeComponent();
            DAOAnimal query = new DAOAnimal();
            dataGridView1.DataSource = query.listaAnimal();
        }
        public Animal getAnimalLista()
        {
           Animal a = new Animal();
            a.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            a.nome = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            a.raca = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            a.cor = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            a.Cliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
            return a;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
                DAOAnimal dao = new DAOAnimal();
                dao.listaAnimalPorNome(textBox1.Text);
           
           
        }
    }
}
