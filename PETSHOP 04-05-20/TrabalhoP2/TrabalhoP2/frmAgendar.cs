using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoP2
{
    public partial class frmAgendar : Form
    {
        public bool tem;
        Conexao conn = new Conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        String d;
        String h;
        String mesagem="";
        int[] id_produto;
        int i=0;
        Boolean status;
     
      



        private object ckgroung;

        public frmAgendar()
        {

            InitializeComponent();
            DAOAgendar query = new DAOAgendar();
            dataGridView1.DataSource = query.listaAgenda();
           
           
        }

        public void statusAg()
        {
            pbStatus.BackColor = Color.Green;
        }
        public void acionar()
        {
            listBox1.Visible = true;
            btnNotificação.Visible = true;
            status = true;
           
        }
        

        public void pesquisaragenda(String data)
        {
            DAOAgendar a = new DAOAgendar();
            cmd.CommandText = @"select * from Agenda where data = @data ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@data",data);
            cmd.Connection = conn.Abrir();
            try
            {
                listBox1.Items.Add("nº       Descrição               Data                hora");
                cmd.Connection = conn.Abrir();
                dr = cmd.ExecuteReader();

                try
                {
                    if (dr.HasRows)
                    {
                    MessageBox.Show("Há agendamento hoje! olhe no status de agendamento");
                    }
                }
                catch
                {
                   
                }
                while (dr.Read())
                {
                    i++;
                    String[] da = new String[30];
                    String[] ho = new String[30];
                    String[] desc = new String[30];

                    String dados1 = da[4] = dr.GetString(2);
                    String dados2 = ho[4] = dr.GetString(3);
                    String dados3 = desc [4] = dr.GetString(4);
                    status = true;
                   





                    listBox1.Items.Add(i + "    " + dados3  +    dados1 +"    "    +   dados2);



                  

                }
                conn.fechar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro no select");
            }
        }

        public void atualizar() { 
        
            DAOAgendar query = new DAOAgendar();
            dataGridView1.DataSource = query.listaAgenda();
        }
       
        public Agendar getListaagenda()
        {
            Agendar a = new Agendar();

            a.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            a.idCliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
            a.descricao = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            a.data = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            a.hora = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            a.id_animal = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);

            return a;
        }


        public void setAgenda(Agendar a)
        {
            txtId.Text = a.id.ToString(); ;
            txtIdcliente.Text = a.idCliente.ToString();
            mskdata.Text = a.data;
            mskhora.Text = a.hora;
            txtDescricao.Text = a.descricao;
            txtAnimalid.Text = a.id_animal.ToString();
        }

        public Agendar getAgenda()
        {
            Agendar a = new Agendar();
            a.idCliente = Convert.ToInt32(txtIdcliente.Text);
            a.data = mskdata.Text;
            a.hora = mskhora.Text;
            a.descricao = txtDescricao.Text;
            a.id_animal = Convert.ToInt32(txtAnimalid.Text);
            return a;
        }
        public Agendar getAgendas()
        {
            Agendar a = new Agendar();
            a.id = Convert.ToInt32(txtId.Text);
            a.idCliente = Convert.ToInt32(txtIdcliente.Text);
            a.data = mskdata.Text;
            a.hora = mskhora.Text;
            a.descricao = txtDescricao.Text;
            a.id_animal = Convert.ToInt32(txtAnimalid.Text);
            return a;
        }
        void Limpar()
        {
            txtId.Clear();
            txtIdcliente.Clear();
            txtDescricao.Clear();
            mskdata.Clear();
            mskhora.Clear();
            txtAnimalid.Clear();
        }
        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void botão()
        {
            btnexcluir.Enabled = false;
            btnalterar.Enabled = false;
            btnadicionar.Enabled = true;

        }
        public void botao2()
        {
            btnexcluir.Enabled = true;
            btnalterar.Enabled = true;
            btnadicionar.Enabled = false;
        }


        private void btnpesqcliente_Click(object sender, EventArgs e)
        {
            consultacliente frm = new consultacliente();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                Cliente cli = frm.GetCliente();
                txtIdcliente.Text = cli.idcliente.ToString();
            }

        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {

            try
            {
                DAOAgendar ag = new DAOAgendar();
                ag.inserir(getAgenda());
                Limpar();


            }
            catch
            {
                MessageBox.Show("Dados em Branco! ");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            setAgenda(getListaagenda());
            botao2();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            DAOAgendar a = new DAOAgendar();
            try
            {

                a.excluir(getAgendas());
                Limpar();
                botão();
            } catch
            {
                MessageBox.Show("Não foi possível excluír!");

            }
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            DAOAgendar a = new DAOAgendar();
            try
            {

                a.alterar(getAgendas());
                Limpar();
                botão();
            }
            catch
            {
                MessageBox.Show("Não foi possível alterar!");

            }
        }



        private void frmAgendar_Load(object sender, EventArgs e)
        {
            txtDescricao.Select();
            botão();
            txtAnimalid.Enabled = false;
            txtIdcliente.Enabled = false;
            txtId.Enabled = false;
            d = dtdata.Value.ToString("dd/MM/yyyy");
            h = dtdata.Value.ToString("HH:mm");
            pesquisaragenda(d);
            txtId.Enabled = false;
            btnNotificação.Visible = false;
            txtDescricao.Focus();

          
            if (status)
            {
            pbStatus.BackColor = Color.Green;
            }
            else
            {
                pbStatus.BackColor = Color.Red;

            }




        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ((DataTable)dataGridView1.DataSource).Rows.Clear();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmListaAnimal an = new frmListaAnimal();
            an.ShowDialog();

            if (an.DialogResult == DialogResult.OK)
            {
                Animal a = an.getAnimalLista();
                txtAnimalid.Text = a.id.ToString();

            }
        }
        private void btnAtualizr_Click(object sender, EventArgs e)
        {

           atualizar(); 
        }

        private void btnadicionar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void mskhora_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNotificação_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            btnNotificação.Visible = false;
            btnNotificação.Visible = false;
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtDescricao_Enter(object sender, EventArgs e)
        {
           
            txtDescricao.BackColor = System.Drawing.Color.LightBlue;
            
        }

        private void txtDescricao_Leave(object sender, EventArgs e)
        {
            txtDescricao.BackColor = System.Drawing.Color.White;
         
        }

        private void mskdata_Enter(object sender, EventArgs e)
        {
           mskdata.BackColor = System.Drawing.Color.LightBlue;
            
        
        }

        private void mskdata_Leave(object sender, EventArgs e)
        {

            mskdata.BackColor = System.Drawing.Color.White;
          
        }

        private void mskhora_Enter(object sender, EventArgs e)
        {
            mskhora.BackColor = System.Drawing.Color.LightBlue;

        }

        private void mskhora_Leave(object sender, EventArgs e)
        {
            mskhora.BackColor = System.Drawing.Color.White;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (status==true)
            {
                acionar();
              
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}