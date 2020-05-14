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
    public partial class frmPrincipal : Form
    {
        int Id;
       
        public frmPrincipal(String valor)
        {
            InitializeComponent();
            Id = Convert.ToInt32(valor);
          
        }

        public frmPrincipal()
        {
        }

        public bool tem;
        Conexao conn = new Conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcliente frm = new frmcliente();
            frm.ShowDialog();
        }
        public void banco(int id){
           
            cmd.CommandText = @"select * from Funcionario where IdFuncionario = @IdFuncionario ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@IdFuncionario", id);
            cmd.Connection = conn.Abrir();
            try
            {
                cmd.Connection = conn.Abrir();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();

                    String mesagem = dr.GetString(1);
                    lblNome.Text = " Olá, " + mesagem;

                }
                conn.fechar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro no select");
            }


        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto frm = new frmProduto();
            frm.ShowDialog();
        }

        private void consumoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmconsumocliente frm = new frmconsumocliente();
            frm.ShowDialog();
        }


        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
           
                
                if (DialogResult.Yes != MessageBox.Show("Tem certeza que deseja sair do sistema?", 
                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2))
                {
                   
                    e.Cancel = true;
                }
            
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmrelatoriocliente frm = new frmrelatoriocliente();
            frm.ShowDialog();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmrelatorioproduto frm = new frmrelatorioproduto();
            frm.ShowDialog();
        }

        private void consumoClientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmrelatorioconsumo frm = new frmrelatorioconsumo();
            frm.ShowDialog();
        
    }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show(" Deseja mesmo sair? ", "Mensagem do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncionario f = new frmFuncionario();
            f.ShowDialog();
        }

       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
         
            banco(Id);

            if (Id != 9)
            {

                funcionarioToolStripMenuItem.Enabled = false;
                relatóriosToolStripMenuItem.Enabled = false;
                sairToolStripMenuItem.Enabled = false;
                consultasToolStripMenuItem.Enabled = false;

            }

        }



        private void animaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnimal a = new frmAnimal();
            a.ShowDialog();

        }
        
                private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            pictureBox6.Visible = true;
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            pictureBox7.Visible = true;
        }

       
        private void pictureBox7_DoubleClick(object sender, EventArgs e)
        {
            frmAnimal a = new frmAnimal();
            a.ShowDialog();
        }

        private void pictureBox8_DoubleClick(object sender, EventArgs e)
        {

        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Visible = false;
            pictureBox4.Visible = true;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.Visible = true;
            pictureBox4.Visible = false;
        }

        private void pictureBox9_DoubleClick(object sender, EventArgs e)
        {
            frmconsumocliente c = new frmconsumocliente();
            c.ShowDialog();
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Visible = false;
            pictureBox3.Visible = true;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            pictureBox3.Visible = false;
        }

        private void pictureBox10_DoubleClick(object sender, EventArgs e)
        {
            frmconsumocliente c = new frmconsumocliente();
            c.ShowDialog();
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Visible = false;
            pictureBox2.Visible = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox10.Visible = true;
            pictureBox2.Visible = false;
        }

        private void pictureBox11_DoubleClick(object sender, EventArgs e)
        {

            if (MessageBox.Show(" Deseja mesmo sair? ", "Mensagem do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.Visible = false;
            pictureBox5.Visible = true;
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox11.Visible = true;
            pictureBox5.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            frmconsumocliente c = new frmconsumocliente();
            c.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            frmcliente f = new frmcliente();
            f.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            frmAgendar a = new frmAgendar();
            a.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmAnimal a = new frmAnimal();
            a.ShowDialog();
        }

        private void cadastrarLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadLogin c = new frmCadLogin();
            c.ShowDialog();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {

           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new LoginAcesso();
            f.Closed += (s, arg) => this.Close();
            f.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            banco(Id);
        }

       

        private void pagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaPagamentos frm = new frmConsultaPagamentos();
            frm.ShowDialog();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void pagamentosCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioPagamento p = new frmRelatorioPagamento();
            p.ShowDialog();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrelatoriofuncionario f = new frmrelatoriofuncionario();
            f.ShowDialog();
        }

        private void controleDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaixa caixa = new frmCaixa(0);
            caixa.ShowDialog();
        }

        private void agendamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgendar agenda = new frmAgendar();
            agenda.ShowDialog();
        }

        private void controleDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstoque estoque = new frmEstoque();
            estoque.ShowDialog();
        }

        private void frmPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
    }

