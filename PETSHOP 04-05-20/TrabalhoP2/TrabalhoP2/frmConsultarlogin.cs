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
    public partial class frmConsultarlogin : Form
    {
        public frmConsultarlogin()
        {
            InitializeComponent();
            DAOLogin query = new DAOLogin();
            dataGridView1.DataSource = query.listaTodosLogin();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        public Login GetLogin()
        {
           Login lo = new Login();
            lo.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            lo.usuario = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lo.senha = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            lo.bloq = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            return lo;
        }


        private void frmConsultarlogin_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           
            DAOLogin query = new DAOLogin();
            dataGridView1.DataSource = query.listaLogin(textBox1.Text);
        }
    }
}
