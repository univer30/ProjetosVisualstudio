using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoP2
{
    public partial class frmcliente : Form
    {
        public frmcliente()
        {
            InitializeComponent();
            botaoAdicionar();
        }

        private void setdadosCliente(Cliente cli)
        {
            txtcodigo.Text = cli.idcliente.ToString();
            txtnome.Text = cli.nomecliente;
            mskcpf.Text = cli.cpfcliente;
            txtendereco.Text = cli.endcliente;
            txtcidade.Text = cli.cidcliente;
            cmbestado.Text = (String)cli.estcliente;

        }
        private Cliente getdadosCliente()
        {
            Cliente cli = new Cliente();
            if (!btnadicionar.Enabled)
            cli.idcliente = Convert.ToInt32(txtcodigo.Text);
            cli.nomecliente = txtnome.Text;
            cli.endcliente = txtendereco.Text;
            cli.cpfcliente = mskcpf.Text;
            cli.cidcliente = txtcidade.Text;
            cli.estcliente = (String)cmbestado.SelectedItem; ;
            return cli;
        }
        private void limpartela()
        {
            txtcodigo.Clear();
            txtnome.Clear();
            mskcpf.Clear();
            txtendereco.Clear();
            txtcidade.Clear();
            cmbestado.Text = "";
        }
        private void botaoAdicionar()
        {
            btnadicionar.Enabled = true;
            btnexcluir.Enabled = false;
            btnalterar.Enabled = false;
        }
        private void botaoAlterarExcluir()
        {
            btnadicionar.Enabled = false;
            btnexcluir.Enabled = true;
            btnalterar.Enabled = true;
        }
        
        private void btnadicionar_Click_1(object sender, EventArgs e)
        {
            try { 
            DAOCliente query = new DAOCliente();
            
                query.inserir(getdadosCliente());
                MessageBox.Show("Cadastro adicionado com sucesso!");
                limpartela();
                botaoAdicionar();
            }
            catch
            {
                MessageBox.Show("Preencha os campos!");
               
            }
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            consultacliente frm = new consultacliente();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                setdadosCliente(frm.GetCliente());
                botaoAlterarExcluir();
            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir o registro?", "Exclusão",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                    DialogResult.Yes)

                     new DAOCliente().excluir(getdadosCliente());
                     limpartela();
                     botaoAdicionar();
            }
            catch
            {
                MessageBox.Show("Registro excluido com sucesso!");
            }
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            new DAOCliente().alterar(getdadosCliente());
            limpartela();
            botaoAdicionar();
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void frmcliente_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void btnadicionar_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void frmcliente_Load(object sender, EventArgs e)
        {
            txtcodigo.Enabled = false;
            txtnome.Select();
        }

        private void txtnome_Enter(object sender, EventArgs e)
        {
            txtnome.BackColor = System.Drawing.Color.LightBlue;
        }

        private void mskcpf_Enter(object sender, EventArgs e)
        {
            mskcpf.BackColor = System.Drawing.Color.LightBlue;
        }

        private void txtendereco_Enter(object sender, EventArgs e)
        {
            txtendereco.BackColor = System.Drawing.Color.LightBlue;
        }

        private void txtcidade_Enter(object sender, EventArgs e)
        {
            txtcidade.BackColor = System.Drawing.Color.LightBlue;
        }

        private void cmbestado_Enter(object sender, EventArgs e)
        {
            cmbestado.BackColor = System.Drawing.Color.LightBlue;
        }

        private void cmbestado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                this.AcceptButton = btnadicionar;
            }
        }

        private void txtnome_Leave(object sender, EventArgs e)
        {
            txtnome.BackColor = System.Drawing.Color.White;
        }

        private void mskcpf_Leave(object sender, EventArgs e)
        {
            mskcpf.BackColor = System.Drawing.Color.White;
        }

        private void txtendereco_Leave(object sender, EventArgs e)
        {
            txtendereco.BackColor = System.Drawing.Color.White;
        }

        private void txtcidade_Leave(object sender, EventArgs e)
        {
            txtcidade.BackColor = System.Drawing.Color.White;
        }

        private void cmbestado_KeyUp(object sender, KeyEventArgs e)
        {
            cmbestado.BackColor = System.Drawing.Color.White;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
