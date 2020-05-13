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
    public partial class frmrelatorioproduto : Form
    {
        public frmrelatorioproduto()
        {
            InitializeComponent();
        }

        private void frmrelatorioproduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'LojaDataSet1.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.ProdutoTableAdapter.Fill(this.LojaDataSet1.Produto);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
