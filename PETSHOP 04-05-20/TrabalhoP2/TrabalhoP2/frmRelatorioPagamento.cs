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
    public partial class frmRelatorioPagamento : Form
    {
        public frmRelatorioPagamento()
        {
            InitializeComponent();
        }

        private void frmRelatorioPagamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'LojaDataSet4.Pagamento'. Você pode movê-la ou removê-la conforme necessário.
            this.PagamentoTableAdapter.Fill(this.LojaDataSet4.Pagamento);

            this.reportViewer1.RefreshReport();
        }
    }
}
