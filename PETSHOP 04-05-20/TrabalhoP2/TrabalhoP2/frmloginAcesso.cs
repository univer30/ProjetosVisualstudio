using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoP2
{
    public partial class LoginAcesso : Form
    {
        public LoginAcesso()
        {
            InitializeComponent();
           
        }
        Conexao conn = new Conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        String dados;
        int Id;
        String valor;

        private void setLogin(Login l)
        {
            txtUsuario.Text = l.usuario;
            txtSenha.Text = l.senha;

        }
        private Login getLogin()
        {

            Login l = new Login();
            l.usuario = txtUsuario.Text;
           l.senha = txtSenha.Text;
            return l;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Consulta no banco e retorna o nome do usuário como string
            cmd.CommandText = @"select * from Login where usuario = @usuario";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            cmd.Connection = conn.Abrir();

            try
            {

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {

            
                dr.Read();
                lbldados.Text = dr.GetString(1);
                // dados = lbldados.Text;
                Id = dr.GetInt32(0);
                    valor = Convert.ToString(Id);

                    conn.fechar();
                }
                else
                {
                   
                }

            }
            catch (SqlException)
            {
            }

    DAOLogin alterar = new DAOLogin();
            DAOLogin lo = new DAOLogin();
           

          
            //Consulta o login
            lo.Login(getLogin());

            if (lo.tem)
            {
                String id = Convert.ToString(Id);
               
                if ( id=="8")
                {
                   
                        alterar.alterarBloq(8,"funcionario"); 
                }

                if ( id=="9")
                {
                    alterar.alterarBloq(8, "");
                   
                }
                
               
                this.Hide();
                Form f = new frmPrincipal(valor);
                f.Closed += (s, arg) => this.Close();
                f.Show();

            }
            else
            {
                MessageBox.Show("Acesso negado!");
                conn.fechar();
            }

           
           
        }

    
        

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginAcesso_Load(object sender, EventArgs e)
        {
            txtUsuario.Text="";
            txtSenha.Text="";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnAcessar;
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Escape)
            {
                if (MessageBox.Show(" Deseja mesmo sair? ", 
                    "Mensagem do sistema ",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.BackColor = System.Drawing.Color.LightBlue;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            txtUsuario.BackColor = System.Drawing.Color.White;
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.BackColor = System.Drawing.Color.LightBlue;
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            txtSenha.BackColor = System.Drawing.Color.White;
        }
    }
}
