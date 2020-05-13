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
    public partial class frmCadLogin : Form
    {
        String funcao = "";
        public frmCadLogin()
        {
            InitializeComponent();
        }


        public void setLogin(Login l)
        {
            txtId.Text = l.id.ToString();
            txtUsuario.Text = l.usuario;
            txtSenha.Text = l.senha;
            funcao = l.bloq;

        }


        public Login getLogin()
        {
            Login lo = new Login();
            lo.id = Convert.ToInt32(txtId.Text);
            lo.usuario = txtUsuario.Text;
            lo.senha = txtSenha.Text;
            lo.bloq = funcao;
            return lo;
        }

        void limpartela()
        {
            txtId.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
            txtCofSenha.Clear();
            rbAd.Checked = false;
            rbFun.Checked = false;
        }
        private void botaoAdicionar()
        {
            btnadicionar.Enabled = true;
            btnexcluir.Enabled = false;
            btnalterar.Enabled = false;
        }
        public void adicionar()
        {
            try
            { 
                DAOLogin l = new DAOLogin();
                l.inserir(getLogin());
                limpartela();
            }
            catch
            {
                MessageBox.Show("Dados em branco. Digite os dados");
            }

        }

        public void alterar()
        {
            try
            {
                DAOLogin l = new DAOLogin();
                l.alterar(getLogin());
                limpartela();
                btnpesqcliente.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Não foi possível alterar!");
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir o registro?", "Exclusão",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                        DialogResult.Yes)

                    new DAOLogin().excluir(getLogin());
                limpartela();
                limpartela();
                btnpesqcliente.Enabled = true;
                btnadicionar.Enabled = true;

                txtUsuario.Enabled = false;
                txtSenha.Enabled = false;
                txtCofSenha.Enabled = false;
                rbAd.Enabled = false;
                rbFun.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir!");
            }
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {

            if (txtSenha.Text == txtCofSenha.Text)
            {
                adicionar();
                btnConsutar.Enabled = true;

                txtUsuario.Enabled = false;
                txtSenha.Enabled = false;
                txtCofSenha.Enabled = false;
                rbAd.Enabled = true;
                rbFun.Enabled = true;

            }
            else
            {
                label9.Visible = true;
            }

        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == txtCofSenha.Text)
            {
                alterar();
                limpartela();
                btnadicionar.Enabled = true;
                txtUsuario.Enabled = false;
                txtSenha.Enabled = false;
                txtCofSenha.Enabled = false;
                rbAd.Enabled = false;
                rbFun.Enabled = false;

            }
            else
            {
                label9.Visible = true;
            }

        }

        private void frmCadLogin_Load(object sender, EventArgs e)
        {
            btnalterar.Enabled = false;
            btnexcluir.Enabled = false;
            txtId.Enabled = false;
            //bloqueia textbox
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
            txtCofSenha.Enabled = false;
            rbAd.Enabled = false;
            rbFun.Enabled = false;
            txtId.Enabled = false;
                
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            funcao = "gerente";
        }

        private void rbFun_CheckedChanged(object sender, EventArgs e)
        {
            funcao = "funcionario";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnpesqcliente_Click(object sender, EventArgs e)
        {
            frmlistafuncionario frm = new frmlistafuncionario();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                Funcionario cli = frm.GetFuncionario();
                txtId.Text = cli.idFuncionario.ToString();
                btnConsutar.Enabled = false;
                txtUsuario.Enabled = true;
                txtSenha.Enabled = true;
                txtCofSenha.Enabled = true;
                rbAd.Enabled = true;
                rbFun.Enabled = true;




            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            frmFuncionario f = new frmFuncionario();
            f.ShowDialog();
        }

        private void btnConsutar_Click(object sender, EventArgs e)
        {
          
            frmConsultarlogin frm = new frmConsultarlogin();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                    setLogin(frm.GetLogin());
                btnadicionar.Enabled = false;
                btnalterar.Enabled = true;
                btnexcluir.Enabled = true;
                rbAd.Enabled = true;
                rbFun.Enabled = true;
                label5.Text = funcao;
                txtUsuario.Enabled = true;
                txtSenha.Enabled = true;
                txtCofSenha.Enabled = true;
                rbAd.Enabled = true;
                rbFun.Enabled = true;

                if (funcao == "gerente    ") //nao alterar o espaço no if
                {
                    rbAd.Checked = true;


                }
                else
                {
                    rbFun.Checked = true;
                }
               
                    
                

            }
        }

        private void txtCofSenha_TextChanged(object sender, EventArgs e)
        {
            label9.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.BackColor = System.Drawing.Color.LightBlue;
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.BackColor = System.Drawing.Color.LightBlue;
        }

        private void txtCofSenha_Enter(object sender, EventArgs e)
        {
            txtCofSenha.BackColor = System.Drawing.Color.LightBlue;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            txtUsuario.BackColor = System.Drawing.Color.White;
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            txtSenha.BackColor = System.Drawing.Color.White;
        }

        private void txtCofSenha_Leave(object sender, EventArgs e)
        {
            txtCofSenha.BackColor = System.Drawing.Color.White;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }


