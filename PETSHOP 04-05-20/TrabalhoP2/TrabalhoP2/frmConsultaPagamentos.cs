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
    public partial class frmConsultaPagamentos : Form
    {
        public frmConsultaPagamentos()
        {
            InitializeComponent();
            DAOPagamento query = new DAOPagamento();
            dataGridView1.DataSource = query.listaPagamento();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //frmConsultaPagamentos frm = new frmConsultaPagamentos();
           // frm.ShowDialog();
        }
    }
}
