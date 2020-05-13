using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoP2
{
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }
        public bool tem;
        Conexao conn = new Conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;


        private void setdadosFuncionario(Funcionario fu)
        {
            txtcodigo.Text = fu.idFuncionario.ToString();
            txtnome.Text = fu.nomeFuncionario;
            mskcpf.Text = fu.cpfFuncionario;
            txtendereco.Text = fu.endFuncionario;
            txtcidade.Text = fu.cidFuncionario;
            cmbestado.Text = (String)fu.estFuncionario;
            txtEmail.Text = fu.emailFuncionario;
            mskTelefone1.Text = fu.telefone1Funcionario;
            mskTelefone2.Text = fu.telefone2Funcionario;

        }


        private Funcionario getdadosFuncionario()
        {
            Funcionario fun = new Funcionario();
           
                fun.idFuncionario = Convert.ToInt32(txtcodigo.Text);
            fun.nomeFuncionario = txtnome.Text;
            fun.endFuncionario = txtendereco.Text;
            fun.cpfFuncionario = mskcpf.Text;
            fun.cidFuncionario = txtcidade.Text;
            fun.estFuncionario = (String)cmbestado.SelectedItem;
            fun.emailFuncionario = txtEmail.Text;
            fun.telefone1Funcionario = mskTelefone1.Text;
            fun.telefone2Funcionario = mskTelefone2.Text;
            return fun;
        }

        private void limpartela()
        {
            txtcodigo.Clear();
            txtnome.Clear();
            mskcpf.Clear();
            txtendereco.Clear();
            txtcidade.Clear();
            cmbestado.Text = "";
            txtEmail.Text = "";
            mskTelefone1.Clear();
            mskTelefone2.Clear();


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


        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            try
            {


                DAOFuncionario query = new DAOFuncionario();
                DAOLogin l = new DAOLogin();
                Login log = new Login();

                query.inserir(getdadosFuncionario());


                MessageBox.Show("Cadastro adicionado com sucesso!");
                limpartela();
                botaoAdicionar();


            }
            catch
            {
                MessageBox.Show("Espaco em branco!");
            }



        }




        private void btnconsultar_Click(object sender, EventArgs e)
        {
            frmlistafuncionario frm = new frmlistafuncionario();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                setdadosFuncionario(frm.GetFuncionario());
                botaoAlterarExcluir();

                btnadicionar.Enabled = false;

            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir o registro?", "Exclusão",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                    DialogResult.Yes)

                    new DAOFuncionario().excluir(getdadosFuncionario());

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
            new DAOFuncionario().alterar(getdadosFuncionario());
            limpartela();
            botaoAdicionar();
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            botaoAdicionar();
            txtnome.Select();
        }

        private void btnAltLogin_Click(object sender, EventArgs e)
        {

            frmConsultarlogin l = new frmConsultarlogin();
            l.ShowDialog();


            if (l.DialogResult == DialogResult.OK)
            {

            }
        }

        private void txtConfSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAlterarS_Click(object sender, EventArgs e)
        {

            try
            {


                DAOLogin l = new DAOLogin();
                MessageBox.Show("Alterardo com sucesso!");
                limpartela();

            }
            catch
            {
                MessageBox.Show("erro no banco!");

            }

        }




        private void mskcpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtnome_Enter(object sender, EventArgs e)
        {
            txtnome.BackColor = System.Drawing.Color.Cyan;
        }

        private void mskcpf_Enter(object sender, EventArgs e)
        {
            mskcpf.BackColor = System.Drawing.Color.Cyan;
        }

        private void txtendereco_Enter(object sender, EventArgs e)
        {
            txtendereco.BackColor = System.Drawing.Color.Cyan;
        }

        private void txtcidade_Enter(object sender, EventArgs e)
        {
            txtcidade.BackColor = System.Drawing.Color.Cyan;
        }

        private void cmbestado_Enter(object sender, EventArgs e)
        {
            cmbestado.BackColor = System.Drawing.Color.Cyan;
        }

        private void mskTelefone1_Enter(object sender, EventArgs e)
        {
            mskTelefone1.BackColor = System.Drawing.Color.Cyan;
        }

        private void mskTelefone2_Enter(object sender, EventArgs e)
        {
            mskTelefone2.BackColor = System.Drawing.Color.Cyan;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.BackColor = System.Drawing.Color.Cyan;
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

        private void cmbestado_Leave(object sender, EventArgs e)
        {
            cmbestado.BackColor = System.Drawing.Color.White;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            txtEmail.BackColor = System.Drawing.Color.White;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


}
