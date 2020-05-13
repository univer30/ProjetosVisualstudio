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
    public partial class frmlistafuncionario : Form
    {
        public frmlistafuncionario()
        {
            InitializeComponent();
            DAOFuncionario query = new DAOFuncionario();
            dgvFuncionario.DataSource = query.listaTodosFuncionarios();

        }

        public Funcionario GetFuncionario()
        {
            Funcionario f = new Funcionario();
            f.idFuncionario = Convert.ToInt32(dgvFuncionario.CurrentRow.Cells[0].Value);
           f.nomeFuncionario = dgvFuncionario.CurrentRow.Cells[1].Value.ToString();
            f.cpfFuncionario = dgvFuncionario.CurrentRow.Cells[2].Value.ToString();
            f.endFuncionario = dgvFuncionario.CurrentRow.Cells[3].Value.ToString();
            f.cidFuncionario = dgvFuncionario.CurrentRow.Cells[4].Value.ToString();
            f.estFuncionario = dgvFuncionario.CurrentRow.Cells[5].Value.ToString();
            f.emailFuncionario = dgvFuncionario.CurrentRow.Cells[6].Value.ToString();
            f.telefone1Funcionario = dgvFuncionario.CurrentRow.Cells[7].Value.ToString();
            f.telefone2Funcionario = dgvFuncionario.CurrentRow.Cells[8].Value.ToString();

            return f;

        }
        private void frmlistafuncionario_Load(object sender, EventArgs e)
        {

        }

        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DAOFuncionario query = new DAOFuncionario();
            dgvFuncionario.DataSource = query.listaFuncionarioPorNome(txtPesquisa.Text);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
