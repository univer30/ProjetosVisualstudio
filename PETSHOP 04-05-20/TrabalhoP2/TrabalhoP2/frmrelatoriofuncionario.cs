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
    public partial class frmrelatoriofuncionario : Form
    {
        public frmrelatoriofuncionario()
        {
            InitializeComponent();
        }

        private void frmrelatoriofuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'LojaDataSet5.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.FuncionarioTableAdapter.Fill(this.LojaDataSet5.Funcionario);

            this.reportViewer1.RefreshReport();
        }
    }
}
